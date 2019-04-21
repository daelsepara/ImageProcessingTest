using Gdk;
using GLib;
using Gtk;
using System;
using System.IO;
using System.Threading;

public partial class MainWindow : Gtk.Window
{
    FileChooserDialog ImageLoader;
    FileChooserDialog ImageSaver;
    FileChooserDialog FolderChooser;
    Pixbuf OriginalImage;

    OpenCV cv = new OpenCV();

    bool IsSelecting;
    bool IsDragging;

    int X0, Y0, X1, Y1;
    int prevX, prevY;

    bool editEnabled;

    bool ControlsActive;

    bool CommandControl;

    Mutex Rendering = new Mutex();

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        InitializeComponents();

        InitializeDefaults();

        DisableControls();

        InitializeSelectionMode();

        InitializeSelected();

        EnableControls();

        Idle.Add(new IdleHandler(OnIdleUpdate));
    }


    void DisableControls()
    {
        ControlsActive = false;
    }

    void EnableControls()
    {
        ControlsActive = true;
    }

    void InitializeSelected()
    {
        DisableEditSignals();

        if (GtkSelection.Selected > 0)
        {
            SetupEditRegion(GtkSelection.Selected);
            SetupEditRegionLocations(GtkSelection.Selected);
            editRegionLayout.Show();
        }

        EnableEditSignals();
    }

    void InitializeSelectionMode()
    {
        if (GtkSelection.Selection.EllipseMode)
        {
            SelectMode.Active = false;
            SelectMode.Label = "Ellipse Mode";
        }
        else
        {
            SelectMode.Active = false;
            SelectMode.Label = "Box Mode";
        }

        HideEdit();
    }

    void Redraw(Gtk.Image background)
    {
        if (background == null)
            return;

        var dest = background.GdkWindow;
        var gc = new Gdk.GC(dest);

        dest.DrawPixbuf(gc, background.Pixbuf, 0, 0, 0, 0, background.WidthRequest, background.HeightRequest, RgbDither.None, 0, 0);

        if (IsSelecting)
            GtkSelection.Draw(gc, dest, X0, Y0, X1, Y1);
    }

    protected void ImageButtonPress(object o, ButtonPressEventArgs args)
    {
        X0 = Convert.ToInt32(args.Event.X);
        Y0 = Convert.ToInt32(args.Event.Y);

        X1 = X0;
        Y1 = Y0;

        if (args.Event.Button == 3)
        {
            IsSelecting = false;
            IsDragging = false;

            HideEdit();

            GtkSelection.Selection.Update(X0, Y0);
        }
        else
        {
            if (args.Event.Button == 1)
            {
                GtkSelection.Selected = GtkSelection.Selection.Find(X0, Y0);

                if (GtkSelection.Selected > 0)
                {
                    IsDragging = true;

                    InitializeSelected();

                    prevX = X0;
                    prevY = Y0;
                }
                else
                {
                    HideEdit();

                    IsSelecting = true;
                }
            }
        }
    }

    protected void ImageButtonRelease(object o, ButtonReleaseEventArgs args)
    {
        if (IsSelecting)
        {
            IsSelecting = false;

            GtkSelection.Selection.Add(X0, Y0, X1, Y1);
        }

        if (IsDragging)
        {
            IsDragging = false;
        }
    }

    protected void ImageMotionNotify(object o, MotionNotifyEventArgs args)
    {
        if (!IsSelecting && !IsDragging) return;

        X1 = Convert.ToInt32(args.Event.X);
        Y1 = Convert.ToInt32(args.Event.Y);

        if (IsDragging)
            Move();
    }

    protected void Move()
    {
        var dx = X1 - prevX;
        var dy = Y1 - prevY;

        prevX = X1;
        prevY = Y1;

        GtkSelection.Selection.Move(dx, dy, GtkSelection.Selected);

        SetupEditRegionLocations(GtkSelection.Selected);
    }

    protected void SetupEditRegion(int Region)
    {
        if (Region > 0)
        {
            GtkSelection.Selection.Size(Region, out int width, out int height);
            SetupEditRegionLocations(GtkSelection.Selected);

            widthScale.Value = width;
            heightScale.Value = height;
            widthScaleNumeric.Value = width;
            heightScaleNumeric.Value = height;
        }
    }

    protected void SetupEditRegionLocations(int Region)
    {
        if (Region > 0)
        {
            GtkSelection.Selection.Location(Region, out int x, out int y);

            dxScale.Value = x;
            dxScaleNumeric.Value = x;
            dyScale.Value = y;
            dyScaleNumeric.Value = y;
        }
    }

    protected void DisableEditSignals()
    {
        editEnabled = false;
    }

    protected void EnableEditSignals()
    {
        editEnabled = true;
    }

    protected void RenderImage()
    {
        if (OriginalImage != null)
        {
            using (Pixbuf pb = GtkSelection.Render(OriginalImage.ScaleSimple(imageBox.WidthRequest, imageBox.HeightRequest, InterpType.Bilinear), cv, markerColor.Color, GtkSelection.Selected, GtkSelection.SelectedColor, false, true))
            {
                Scale(pb, imageBox.Pixbuf);
            }
        }

        CollectGarbage();
    }

    void Scale(Pixbuf source, Pixbuf target)
    {
        if (source != null && target != null)
            source.Scale(target, 0, 0, target.Width, target.Height, 0, 0, 1.0, 1.0, InterpType.Bilinear);
    }

    bool OnIdleUpdate()
    {
        Rendering.WaitOne();

        RenderImage();

        Redraw(imageBox);

        Rendering.ReleaseMutex();

        return true;
    }

    protected void HideEdit()
    {
        editRegionLayout.Hide();
        GtkSelection.Selected = 0;
        DisableEditSignals();
    }

    protected void ClearRegions()
    {
        GtkSelection.Selection.Clear();
        HideEdit();
    }

    protected void ClearRegions(object o, EventArgs e)
    {
        if (ControlsActive)
        {
            ClearRegions();
        }
    }

    protected void ToggleSelectMode(object o, EventArgs e)
    {
        if (ControlsActive)
        {
            if (SelectMode.Active)
            {
                SelectMode.Label = "Box Mode";
                GtkSelection.Selection.EllipseMode = false;
            }
            else
            {
                SelectMode.Label = "Ellipse Mode";
                GtkSelection.Selection.EllipseMode = true;
            }

            HideEdit();
        }
    }

    void CollectGarbage()
    {
        System.GC.Collect();
        System.GC.WaitForPendingFinalizers();
    }

    protected void ScaleResizeEvent(object o, EventArgs e)
    {
        if (ControlsActive && editEnabled)
            ScaleResize();
    }

    protected void ScaleResize()
    {
        if (ControlsActive && GtkSelection.Selected > 0)
        {
            int width = Convert.ToInt32(widthScale.Value);
            int height = Convert.ToInt32(heightScale.Value);

            GtkSelection.Selection.ReSize(GtkSelection.Selected, width, height);

            widthScaleNumeric.Value = width;
            heightScaleNumeric.Value = height;
        }
    }

    protected void NumericResizeEvent(object o, EventArgs e)
    {
        if (ControlsActive && editEnabled)
            NumericResize();
    }

    protected void NumericResize()
    {
        if (ControlsActive && GtkSelection.Selected > 0)
        {
            int width = Convert.ToInt32(widthScaleNumeric.Value);
            int height = Convert.ToInt32(heightScaleNumeric.Value);

            GtkSelection.Selection.ReSize(GtkSelection.Selected, width, height);

            widthScale.Value = width;
            heightScale.Value = height;
        }
    }

    protected void ScaleMove()
    {
        if (ControlsActive && GtkSelection.Selected > 0)
        {
            GtkSelection.Selection.Location(GtkSelection.Selected, out int x, out int y);

            GtkSelection.Selection.Move(Convert.ToInt32(dxScale.Value) - x, Convert.ToInt32(dyScale.Value) - y, GtkSelection.Selected);

            SetupEditRegionLocations(GtkSelection.Selected);
        }
    }

    protected void NumericMove()
    {
        if (ControlsActive && GtkSelection.Selected > 0)
        {
            GtkSelection.Selection.Location(GtkSelection.Selected, out int x, out int y);

            GtkSelection.Selection.Move(Convert.ToInt32(dxScaleNumeric.Value) - x, Convert.ToInt32(dyScaleNumeric.Value) - y, GtkSelection.Selected);

            SetupEditRegionLocations(GtkSelection.Selected);
        }
    }

    protected void ScaleMoveEvent(object o, EventArgs e)
    {
        if (ControlsActive && editEnabled)
            ScaleMove();
    }

    protected void NumericMoveEvent(object o, EventArgs e)
    {
        if (ControlsActive && editEnabled)
            NumericMove();
    }

    protected void CloseEdit(object o, EventArgs e)
    {
        if (ControlsActive)
        {
            HideEdit();
        }
    }

    protected void InitializeComponents()
    {
        var filters = new FileFilter();

        filters.AddPattern("*.png");
        filters.AddPattern("*.jpg");

        ImageLoader = new FileChooserDialog(
            "Choose the Image to open",
            this,
            FileChooserAction.Open,
            "Open", ResponseType.Accept,
            "Cancel", ResponseType.Cancel
        );

        ImageLoader.AddFilter(filters);

        ImageSaver = new FileChooserDialog(
            "Save Processed Image",
            this,
            FileChooserAction.Save,
            "Save", ResponseType.Accept,
            "Cancel", ResponseType.Cancel
        );

        ImageSaver.AddFilter(filters);

        FolderChooser = new FileChooserDialog(
            "Choose the folder where blob images will be saved",
            this,
            FileChooserAction.SelectFolder,
            "Save", ResponseType.Accept,
            "Cancel", ResponseType.Cancel
        );
    }


    protected void InitializeDefaults()
    {
        cannyThreshold.Value = 90.0;

        linkingThreshold.Value = 60.0;

        minArea.Value = 20.0;

        maxArea.Value = 10000.0;

        minDist.Value = 20.0;

        circleAccumulatorThreshold.Value = 120.0;

        minRadius.Value = 5.0;

        maxRadius.Value = 500.0;

        dp.Value = 2.0;

        markerSize.Value = 2.0;

        markerColor.Color = new Color(255, 0, 0);

        subtractBg.Active = false;

        imgInvert.Active = false;

        subtractBg.Active = cv.SubtractBackground;

        downUpSample.Active = cv.DownUpSample;

        imgInvert.Active = cv.Invert;

        gaussianBlur.Active = cv.Blur;

        normalize.Active = cv.Normalize;

        sx.Value = cv.sx;
        sy.Value = cv.sy;
        sigmaX.Value = cv.sigmaX;
        sigmaY.Value = cv.sigmaY;

        OriginalImage = new Pixbuf(Colorspace.Rgb, false, 8, imageBox.WidthRequest, imageBox.HeightRequest);
        OriginalImage.Fill(0);

        imageBox.Pixbuf = OriginalImage.Copy().ScaleSimple(imageBox.WidthRequest, imageBox.HeightRequest, InterpType.Bilinear);
    }

    protected void OnDeleteEvent(object o, DeleteEventArgs a)
    {
        Quit();

        a.RetVal = true;
    }

    protected void RenderImage(Pixbuf pixbuf)
    {
        if (pixbuf == null)
            return;

        if (imageBox.Pixbuf != null)
            imageBox.Pixbuf.Dispose();

        imageBox.Pixbuf = pixbuf.Copy().ScaleSimple(imageBox.WidthRequest, imageBox.HeightRequest, InterpType.Bilinear);
    }

    protected void OnSelectImageButtonClicked(object o, EventArgs e)
    {
        LoadImage(ImageLoader, "Load Image", ref OriginalImage);
    }

    protected void OnQuitButtonClicked(object o, EventArgs e)
    {
        Quit();
    }

    protected void Quit()
    {
        if (OriginalImage != null)
            OriginalImage.Dispose();

        if (ImageLoader != null)
            ImageLoader.Dispose();

        if (ImageSaver != null)
            ImageSaver.Dispose();

        if (FolderChooser != null)
            FolderChooser.Dispose();

        Application.Quit();
    }

    protected void OnDetectCirclesButtonClicked(object o, EventArgs e)
    {
        HideEdit();

        Application.Invoke(delegate
        {
            using (var mat = cv.ToMat(OriginalImage))
            {
                cv.DetectCirclesMat(
                    mat,
                    dp.Value,
                    minDist.Value,
                    cannyThreshold.Value,
                    circleAccumulatorThreshold.Value,
                    Convert.ToInt32(minRadius.Value),
                    Convert.ToInt32(maxRadius.Value),
                    GtkSelection.Selection,
                    Convert.ToDouble(imageBox.WidthRequest) / OriginalImage.Width,
                    Convert.ToDouble(imageBox.HeightRequest) / OriginalImage.Height
                );
            }
        });
    }

    protected void OnDetectBlobsButtonClicked(object o, EventArgs e)
    {
        HideEdit();

        Application.Invoke(delegate
        {
            using (var mat = cv.ToMat(OriginalImage))
            {
                GtkSelection.Selected = 0;

                cv.DetectBlobsMat(
                    mat,
                    cannyThreshold.Value,
                    linkingThreshold.Value,
                    minArea.Value,
                    maxArea.Value,
                    GtkSelection.Selection,
                    Convert.ToDouble(imageBox.WidthRequest) / OriginalImage.Width,
                    Convert.ToDouble(imageBox.HeightRequest) / OriginalImage.Height
                );
            }
        });
    }

    protected void OnBlobDetectorButtonClicked(object o, EventArgs e)
    {
        HideEdit();

        Application.Invoke(delegate
        {
            using (var mat = cv.ToMat(OriginalImage))
            {
                cv.BlobDetectorMat(
                    mat,
                    Convert.ToInt32(minArea.Value),
                    Convert.ToInt32(maxArea.Value),
                    GtkSelection.Selection,
                    Convert.ToDouble(imageBox.WidthRequest) / OriginalImage.Width,
                    Convert.ToDouble(imageBox.HeightRequest) / OriginalImage.Height
                );
            }
        });
    }

    protected void OnSimpleBlobDetectorClicked(object o, EventArgs e)
    {
        HideEdit();

        Application.Invoke(delegate
        {
            var parameters = new Emgu.CV.Features2D.SimpleBlobDetectorParams
            {
                MinArea = Convert.ToInt32(minArea.Value),
                MaxArea = Convert.ToInt32(maxArea.Value),
                FilterByArea = true
            };

            cv.InitSimpleBlobDetector(parameters);

            using (var mat = cv.ToMat(OriginalImage))
            {

                cv.SimpleBlobDetectionMat(
                    mat,
                    GtkSelection.Selection,
                    Convert.ToDouble(imageBox.WidthRequest) / OriginalImage.Width,
                    Convert.ToDouble(imageBox.HeightRequest) / OriginalImage.Height
                );
            }
        });
    }

    protected void OnSubtractBgToggled(object o, EventArgs e)
    {
        cv.SubtractBackground = subtractBg.Active;
    }

    protected void OnDownUpSampleToggled(object o, EventArgs e)
    {
        cv.DownUpSample = downUpSample.Active;
    }

    protected void OnImgInvertToggled(object o, EventArgs e)
    {
        cv.Invert = imgInvert.Active;
    }

    protected void OnGaussianBlurToggled(object o, EventArgs e)
    {
        cv.Blur = gaussianBlur.Active;
    }

    protected void OnSxValueChanged(object o, EventArgs e)
    {
        sx.Value = sx.ValueAsInt;
        cv.sx = sx.ValueAsInt;
    }

    protected void OnSyValueChanged(object o, EventArgs e)
    {
        sy.Value = sy.ValueAsInt;
        cv.sy = sy.ValueAsInt;
    }

    protected void OnSigmaXValueChanged(object o, EventArgs e)
    {
        cv.sigmaX = sx.Value;
    }

    protected void OnSigmaYValueChanged(object o, EventArgs e)
    {
        cv.sigmaY = sy.Value;
    }

    protected void OnNormalizeToggled(object o, EventArgs e)
    {
        cv.Normalize = normalize.Active;
    }

    protected void OnSaveBlobsButtonClicked(object o, EventArgs e)
    {
        // Add most recent directory
        if (!string.IsNullOrEmpty(FolderChooser.CurrentFolder))
        {
            if (Directory.Exists(FolderChooser.CurrentFolder))
            {
                FolderChooser.SetCurrentFolder(FolderChooser.CurrentFolder);
            }
        }
        else if (!string.IsNullOrEmpty(ImageLoader.Filename))
        {
            var directory = System.IO.Path.GetDirectoryName(ImageLoader.Filename);

            if (Directory.Exists(directory))
            {
                FolderChooser.SetCurrentFolder(directory);
            }
        }

        if (FolderChooser.Run() == Convert.ToInt32(ResponseType.Accept))
        {
            var blobs = GtkSelection.Selection.BoundingBoxes();

            if (!string.IsNullOrEmpty(FolderChooser.CurrentFolder) && !string.IsNullOrEmpty(ImageLoader.Filename) && blobs.Count > 0)
            {
                var basefile = System.IO.Path.GetFileNameWithoutExtension(ImageLoader.Filename);

                var index = 1;

                foreach (var rectangle in blobs)
                {
                    var ScaleX = Convert.ToDouble(OriginalImage.Width) / imageBox.WidthRequest;
                    var ScaleY = Convert.ToDouble(OriginalImage.Height) / imageBox.HeightRequest;

                    var width = Convert.ToInt32(Math.Abs(rectangle.X1 - rectangle.X0) * ScaleX);
                    var height = Convert.ToInt32(Math.Abs(rectangle.Y1 - rectangle.Y0) * ScaleY);
                    var top = Convert.ToInt32(Math.Min(rectangle.Y0, rectangle.Y1) * ScaleY);
                    var left = Convert.ToInt32(Math.Min(rectangle.X0, rectangle.X1) * ScaleX);

                    var area = new Pixbuf(Colorspace.Rgb, false, 8, width, height);

                    if (OriginalImage != null)
                    {
                        OriginalImage.CopyArea(left, top, width, height, area, 0, 0);
                        area.Save(String.Format("{0}/{1}-blob-{2}.png", FolderChooser.CurrentFolder, basefile, index.ToString("D4")), "png");
                    }

                    area.Dispose();

                    index++;
                }
            }
        }

        FolderChooser.Hide();
    }

    protected void OnSaveProcessedImageClicked(object o, EventArgs e)
    {
        if (ControlsActive && GtkSelection.Selection.Count() > 0)
        {
            ImageSaver.Title = "Save Processed Image";

            if (!string.IsNullOrEmpty(ImageSaver.Filename))
            {
                var directory = System.IO.Path.GetDirectoryName(ImageSaver.Filename);

                if (Directory.Exists(directory))
                {
                    ImageSaver.SetCurrentFolder(directory);
                }
            }

            if (ImageSaver.Run() == (int)ResponseType.Accept)
            {
                if (!string.IsNullOrEmpty(ImageSaver.Filename))
                {
                    var FileName = ImageSaver.Filename;

                    if (!FileName.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                        FileName += ".png";

                    var ScaleX = Convert.ToDouble(OriginalImage.Width) / imageBox.WidthRequest;
                    var ScaleY = Convert.ToDouble(OriginalImage.Height) / imageBox.HeightRequest;

                    using (Pixbuf pb = GtkSelection.Render(OriginalImage, cv, GtkSelection.MarkerColor, GtkSelection.Selected, GtkSelection.SelectedColor, false, true, ScaleX, ScaleY))
                    {
                        if (imageBox.Pixbuf != null && pb != null)
                        {
                            pb.Save(FileName, "png");
                        }
                    }
                }
            }

            ImageSaver.Hide();
        }
    }

    protected void OnKeyPressEvent(object o, KeyPressEventArgs e)
    {
        var key = e.Event.Key;

        if (key == Gdk.Key.Meta_L || key == Gdk.Key.Meta_R || key == Gdk.Key.Control_L || key == Gdk.Key.Control_L)
        {
            CommandControl = true;
        }
        else
        {
            if (CommandControl && (key == Gdk.Key.Q || key == Gdk.Key.q))
            {
                Quit();
            }

            if (CommandControl && (key == Gdk.Key.S || key == Gdk.Key.s))
            {
                if (ImageSaver != null && OriginalImage != null)
                {
                    SaveImage(ImageSaver, "Save Image", OriginalImage);
                }
            }
        }
    }

    protected void OnKeyReleaseEvent(object o, KeyReleaseEventArgs e)
    {
        CommandControl = false;
    }

    protected void SaveImage(FileChooserDialog dialog, string title, Pixbuf pixbuf)
    {
        dialog.Title = title;

        if (!string.IsNullOrEmpty(dialog.Filename))
        {
            var directory = System.IO.Path.GetDirectoryName(dialog.Filename);

            if (Directory.Exists(directory))
            {
                dialog.SetCurrentFolder(directory);
            }
        }

        if (dialog.Run() == Convert.ToInt32(ResponseType.Accept))
        {
            if (!string.IsNullOrEmpty(dialog.Filename))
            {
                var FileName = dialog.Filename;

                if (!FileName.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                    FileName += ".png";

                pixbuf.Save(FileName, "png");
            }
        }

        dialog.Hide();
    }

    protected void LoadImage(FileChooserDialog dialog, string title, ref Pixbuf pixbuf)
    {
        dialog.Title = title;

        if (!string.IsNullOrEmpty(dialog.Filename))
        {
            var directory = System.IO.Path.GetDirectoryName(dialog.Filename);

            if (Directory.Exists(directory))
            {
                dialog.SetCurrentFolder(directory);
            }
        }

        if (dialog.Run() == Convert.ToInt32(ResponseType.Accept))
        {
            if (!string.IsNullOrEmpty(dialog.Filename))
            {
                var FileName = dialog.Filename;

                if (pixbuf != null)
                    pixbuf.Dispose();

                pixbuf = new Pixbuf(FileName);

                if (pixbuf != null)
                    RenderImage(pixbuf);

                ClearRegions();
            }
        }

        dialog.Hide();
    }

    protected void OnMarkerSizeValueChanged(object o, EventArgs e)
    {
        GtkSelection.MarkerSize = Convert.ToInt32(markerSize.Value);
    }
}
