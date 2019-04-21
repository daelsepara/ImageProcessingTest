
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed MainLayout;

	private global::Gtk.EventBox ImageEventBox;

	private global::Gtk.Image imageBox;

	private global::Gtk.Button selectImageButton;

	private global::Gtk.Button quitButton;

	private global::Gtk.SpinButton cannyThreshold;

	private global::Gtk.Label cannyThresholdLabel;

	private global::Gtk.SpinButton linkingThreshold;

	private global::Gtk.Label linkingThresholdLabel;

	private global::Gtk.SpinButton minArea;

	private global::Gtk.Label minAreaLabel;

	private global::Gtk.SpinButton maxArea;

	private global::Gtk.Label maxAreaLabel;

	private global::Gtk.SpinButton minDist;

	private global::Gtk.Label minDistLabel;

	private global::Gtk.SpinButton circleAccumulatorThreshold;

	private global::Gtk.Label circleAccumulatorThresholdLabel;

	private global::Gtk.SpinButton minRadius;

	private global::Gtk.Label minRadiusLabel;

	private global::Gtk.SpinButton maxRadius;

	private global::Gtk.Label maxRadiusLabel;

	private global::Gtk.ColorButton markerColor;

	private global::Gtk.Label colorButtonLabel;

	private global::Gtk.SpinButton markerSize;

	private global::Gtk.Label markerSizeLabel;

	private global::Gtk.SpinButton dp;

	private global::Gtk.Label dpLabel;

	private global::Gtk.Button detectCirclesButton;

	private global::Gtk.Button detectBlobsButton;

	private global::Gtk.Button blobDetectorButton;

	private global::Gtk.Button simpleBlobDetector;

	private global::Gtk.CheckButton subtractBg;

	private global::Gtk.CheckButton imgInvert;

	private global::Gtk.CheckButton downUpSample;

	private global::Gtk.CheckButton gaussianBlur;

	private global::Gtk.SpinButton sx;

	private global::Gtk.SpinButton sy;

	private global::Gtk.Label sxLabel;

	private global::Gtk.Label syLabel;

	private global::Gtk.SpinButton sigmaX;

	private global::Gtk.SpinButton sigmaY;

	private global::Gtk.Label sigmaXLabel;

	private global::Gtk.Label sigmaYLabel;

	private global::Gtk.CheckButton normalize;

	private global::Gtk.Button saveBlobsButton;

	private global::Gtk.Button saveProcessedImage;

	private global::Gtk.ToggleButton SelectMode;

	private global::Gtk.Fixed editRegionLayout;

	private global::Gtk.Label regionWidthLabel;

	private global::Gtk.SpinButton widthScaleNumeric;

	private global::Gtk.HScale widthScale;

	private global::Gtk.SpinButton heightScaleNumeric;

	private global::Gtk.HScale heightScale;

	private global::Gtk.Label regionHeightLabel;

	private global::Gtk.SpinButton dxScaleNumeric;

	private global::Gtk.Label dxLabel;

	private global::Gtk.SpinButton dyScaleNumeric;

	private global::Gtk.Label dyLabel;

	private global::Gtk.HScale dxScale;

	private global::Gtk.HScale dyScale;

	private global::Gtk.Button closeEditButton;

	private global::Gtk.Button ClearSelected;

	private global::Gtk.Button detectFacesButton;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.WidthRequest = 1280;
		this.HeightRequest = 720;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Blob Detection Test Suite");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		this.AllowGrow = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.MainLayout = new global::Gtk.Fixed();
		this.MainLayout.WidthRequest = 1280;
		this.MainLayout.HeightRequest = 720;
		this.MainLayout.Name = "MainLayout";
		this.MainLayout.HasWindow = false;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.ImageEventBox = new global::Gtk.EventBox();
		this.ImageEventBox.WidthRequest = 800;
		this.ImageEventBox.HeightRequest = 600;
		this.ImageEventBox.Name = "ImageEventBox";
		// Container child ImageEventBox.Gtk.Container+ContainerChild
		this.imageBox = new global::Gtk.Image();
		this.imageBox.WidthRequest = 800;
		this.imageBox.HeightRequest = 600;
		this.imageBox.Name = "imageBox";
		this.ImageEventBox.Add(this.imageBox);
		this.MainLayout.Add(this.ImageEventBox);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.ImageEventBox]));
		w2.X = 20;
		w2.Y = 20;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.selectImageButton = new global::Gtk.Button();
		this.selectImageButton.WidthRequest = 120;
		this.selectImageButton.HeightRequest = 30;
		this.selectImageButton.Name = "selectImageButton";
		this.selectImageButton.UseUnderline = true;
		this.selectImageButton.FocusOnClick = false;
		this.selectImageButton.Label = global::Mono.Unix.Catalog.GetString("select image");
		this.MainLayout.Add(this.selectImageButton);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.selectImageButton]));
		w3.X = 840;
		w3.Y = 20;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.quitButton = new global::Gtk.Button();
		this.quitButton.Name = "quitButton";
		this.quitButton.UseUnderline = true;
		this.quitButton.Label = global::Mono.Unix.Catalog.GetString("Quit");
		this.MainLayout.Add(this.quitButton);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.quitButton]));
		w4.X = 20;
		w4.Y = 625;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.cannyThreshold = new global::Gtk.SpinButton(0D, 1000D, 1D);
		this.cannyThreshold.WidthRequest = 120;
		this.cannyThreshold.Name = "cannyThreshold";
		this.cannyThreshold.Adjustment.PageIncrement = 10D;
		this.cannyThreshold.ClimbRate = 1D;
		this.cannyThreshold.Numeric = true;
		this.MainLayout.Add(this.cannyThreshold);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.cannyThreshold]));
		w5.X = 840;
		w5.Y = 60;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.cannyThresholdLabel = new global::Gtk.Label();
		this.cannyThresholdLabel.Name = "cannyThresholdLabel";
		this.cannyThresholdLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Canny threshold");
		this.MainLayout.Add(this.cannyThresholdLabel);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.cannyThresholdLabel]));
		w6.X = 970;
		w6.Y = 65;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.linkingThreshold = new global::Gtk.SpinButton(0D, 1000D, 1D);
		this.linkingThreshold.WidthRequest = 120;
		this.linkingThreshold.Name = "linkingThreshold";
		this.linkingThreshold.Adjustment.PageIncrement = 10D;
		this.linkingThreshold.ClimbRate = 1D;
		this.linkingThreshold.Numeric = true;
		this.MainLayout.Add(this.linkingThreshold);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.linkingThreshold]));
		w7.X = 840;
		w7.Y = 90;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.linkingThresholdLabel = new global::Gtk.Label();
		this.linkingThresholdLabel.Name = "linkingThresholdLabel";
		this.linkingThresholdLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Linking threshold");
		this.MainLayout.Add(this.linkingThresholdLabel);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.linkingThresholdLabel]));
		w8.X = 970;
		w8.Y = 95;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.minArea = new global::Gtk.SpinButton(0D, 100000D, 1D);
		this.minArea.WidthRequest = 120;
		this.minArea.Name = "minArea";
		this.minArea.Adjustment.PageIncrement = 100D;
		this.minArea.ClimbRate = 1D;
		this.minArea.Numeric = true;
		this.MainLayout.Add(this.minArea);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.minArea]));
		w9.X = 840;
		w9.Y = 120;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.minAreaLabel = new global::Gtk.Label();
		this.minAreaLabel.Name = "minAreaLabel";
		this.minAreaLabel.LabelProp = global::Mono.Unix.Catalog.GetString("minimum area");
		this.MainLayout.Add(this.minAreaLabel);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.minAreaLabel]));
		w10.X = 970;
		w10.Y = 125;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.maxArea = new global::Gtk.SpinButton(0D, 100000D, 1D);
		this.maxArea.WidthRequest = 120;
		this.maxArea.Name = "maxArea";
		this.maxArea.Adjustment.PageIncrement = 100D;
		this.maxArea.ClimbRate = 1D;
		this.maxArea.Numeric = true;
		this.MainLayout.Add(this.maxArea);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.maxArea]));
		w11.X = 840;
		w11.Y = 150;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.maxAreaLabel = new global::Gtk.Label();
		this.maxAreaLabel.Name = "maxAreaLabel";
		this.maxAreaLabel.LabelProp = global::Mono.Unix.Catalog.GetString("maximum area");
		this.MainLayout.Add(this.maxAreaLabel);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.maxAreaLabel]));
		w12.X = 970;
		w12.Y = 155;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.minDist = new global::Gtk.SpinButton(0D, 1000D, 1D);
		this.minDist.WidthRequest = 120;
		this.minDist.Name = "minDist";
		this.minDist.Adjustment.PageIncrement = 10D;
		this.minDist.ClimbRate = 1D;
		this.minDist.Numeric = true;
		this.MainLayout.Add(this.minDist);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.minDist]));
		w13.X = 840;
		w13.Y = 180;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.minDistLabel = new global::Gtk.Label();
		this.minDistLabel.Name = "minDistLabel";
		this.minDistLabel.LabelProp = global::Mono.Unix.Catalog.GetString("minimum distance between circles");
		this.MainLayout.Add(this.minDistLabel);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.minDistLabel]));
		w14.X = 971;
		w14.Y = 184;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.circleAccumulatorThreshold = new global::Gtk.SpinButton(0D, 1000D, 1D);
		this.circleAccumulatorThreshold.WidthRequest = 120;
		this.circleAccumulatorThreshold.Name = "circleAccumulatorThreshold";
		this.circleAccumulatorThreshold.Adjustment.PageIncrement = 10D;
		this.circleAccumulatorThreshold.ClimbRate = 1D;
		this.circleAccumulatorThreshold.Numeric = true;
		this.circleAccumulatorThreshold.Value = 6D;
		this.MainLayout.Add(this.circleAccumulatorThreshold);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.circleAccumulatorThreshold]));
		w15.X = 840;
		w15.Y = 210;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.circleAccumulatorThresholdLabel = new global::Gtk.Label();
		this.circleAccumulatorThresholdLabel.Name = "circleAccumulatorThresholdLabel";
		this.circleAccumulatorThresholdLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Hough circle threshold");
		this.MainLayout.Add(this.circleAccumulatorThresholdLabel);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.circleAccumulatorThresholdLabel]));
		w16.X = 970;
		w16.Y = 215;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.minRadius = new global::Gtk.SpinButton(0D, 1000D, 1D);
		this.minRadius.WidthRequest = 120;
		this.minRadius.Name = "minRadius";
		this.minRadius.Adjustment.PageIncrement = 10D;
		this.minRadius.ClimbRate = 1D;
		this.minRadius.Numeric = true;
		this.MainLayout.Add(this.minRadius);
		global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.minRadius]));
		w17.X = 840;
		w17.Y = 240;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.minRadiusLabel = new global::Gtk.Label();
		this.minRadiusLabel.Name = "minRadiusLabel";
		this.minRadiusLabel.LabelProp = global::Mono.Unix.Catalog.GetString("minimum circle radius");
		this.MainLayout.Add(this.minRadiusLabel);
		global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.minRadiusLabel]));
		w18.X = 970;
		w18.Y = 245;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.maxRadius = new global::Gtk.SpinButton(0D, 1000D, 1D);
		this.maxRadius.WidthRequest = 120;
		this.maxRadius.Name = "maxRadius";
		this.maxRadius.Adjustment.PageIncrement = 10D;
		this.maxRadius.ClimbRate = 1D;
		this.maxRadius.Numeric = true;
		this.MainLayout.Add(this.maxRadius);
		global::Gtk.Fixed.FixedChild w19 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.maxRadius]));
		w19.X = 840;
		w19.Y = 270;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.maxRadiusLabel = new global::Gtk.Label();
		this.maxRadiusLabel.Name = "maxRadiusLabel";
		this.maxRadiusLabel.LabelProp = global::Mono.Unix.Catalog.GetString("maximum circle radius");
		this.MainLayout.Add(this.maxRadiusLabel);
		global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.maxRadiusLabel]));
		w20.X = 970;
		w20.Y = 275;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.markerColor = new global::Gtk.ColorButton();
		this.markerColor.WidthRequest = 120;
		this.markerColor.Events = ((global::Gdk.EventMask)(784));
		this.markerColor.Name = "markerColor";
		this.markerColor.FocusOnClick = false;
		this.MainLayout.Add(this.markerColor);
		global::Gtk.Fixed.FixedChild w21 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.markerColor]));
		w21.X = 840;
		w21.Y = 360;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.colorButtonLabel = new global::Gtk.Label();
		this.colorButtonLabel.Name = "colorButtonLabel";
		this.colorButtonLabel.LabelProp = global::Mono.Unix.Catalog.GetString("marker color");
		this.MainLayout.Add(this.colorButtonLabel);
		global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.colorButtonLabel]));
		w22.X = 970;
		w22.Y = 365;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.markerSize = new global::Gtk.SpinButton(0D, 100D, 1D);
		this.markerSize.WidthRequest = 120;
		this.markerSize.Name = "markerSize";
		this.markerSize.Adjustment.PageIncrement = 10D;
		this.markerSize.ClimbRate = 1D;
		this.markerSize.Numeric = true;
		this.MainLayout.Add(this.markerSize);
		global::Gtk.Fixed.FixedChild w23 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.markerSize]));
		w23.X = 840;
		w23.Y = 330;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.markerSizeLabel = new global::Gtk.Label();
		this.markerSizeLabel.Name = "markerSizeLabel";
		this.markerSizeLabel.LabelProp = global::Mono.Unix.Catalog.GetString("markerSize");
		this.MainLayout.Add(this.markerSizeLabel);
		global::Gtk.Fixed.FixedChild w24 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.markerSizeLabel]));
		w24.X = 970;
		w24.Y = 335;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.dp = new global::Gtk.SpinButton(0D, 100D, 1D);
		this.dp.WidthRequest = 120;
		this.dp.Name = "dp";
		this.dp.Adjustment.PageIncrement = 10D;
		this.dp.ClimbRate = 1D;
		this.dp.Numeric = true;
		this.MainLayout.Add(this.dp);
		global::Gtk.Fixed.FixedChild w25 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.dp]));
		w25.X = 840;
		w25.Y = 300;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.dpLabel = new global::Gtk.Label();
		this.dpLabel.Name = "dpLabel";
		this.dpLabel.LabelProp = global::Mono.Unix.Catalog.GetString("dp (image / accumulator)");
		this.MainLayout.Add(this.dpLabel);
		global::Gtk.Fixed.FixedChild w26 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.dpLabel]));
		w26.X = 970;
		w26.Y = 305;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.detectCirclesButton = new global::Gtk.Button();
		this.detectCirclesButton.WidthRequest = 120;
		this.detectCirclesButton.Name = "detectCirclesButton";
		this.detectCirclesButton.UseUnderline = true;
		this.detectCirclesButton.FocusOnClick = false;
		this.detectCirclesButton.Label = global::Mono.Unix.Catalog.GetString("Hough circles");
		this.MainLayout.Add(this.detectCirclesButton);
		global::Gtk.Fixed.FixedChild w27 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.detectCirclesButton]));
		w27.X = 840;
		w27.Y = 395;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.detectBlobsButton = new global::Gtk.Button();
		this.detectBlobsButton.WidthRequest = 120;
		this.detectBlobsButton.Name = "detectBlobsButton";
		this.detectBlobsButton.UseUnderline = true;
		this.detectBlobsButton.FocusOnClick = false;
		this.detectBlobsButton.Label = global::Mono.Unix.Catalog.GetString("Edge/Polygon");
		this.MainLayout.Add(this.detectBlobsButton);
		global::Gtk.Fixed.FixedChild w28 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.detectBlobsButton]));
		w28.X = 840;
		w28.Y = 425;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.blobDetectorButton = new global::Gtk.Button();
		this.blobDetectorButton.WidthRequest = 120;
		this.blobDetectorButton.Name = "blobDetectorButton";
		this.blobDetectorButton.UseUnderline = true;
		this.blobDetectorButton.FocusOnClick = false;
		this.blobDetectorButton.Label = global::Mono.Unix.Catalog.GetString("Blobs");
		this.MainLayout.Add(this.blobDetectorButton);
		global::Gtk.Fixed.FixedChild w29 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.blobDetectorButton]));
		w29.X = 840;
		w29.Y = 455;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.simpleBlobDetector = new global::Gtk.Button();
		this.simpleBlobDetector.WidthRequest = 120;
		this.simpleBlobDetector.Name = "simpleBlobDetector";
		this.simpleBlobDetector.UseUnderline = true;
		this.simpleBlobDetector.FocusOnClick = false;
		this.simpleBlobDetector.Label = global::Mono.Unix.Catalog.GetString("Simple");
		this.MainLayout.Add(this.simpleBlobDetector);
		global::Gtk.Fixed.FixedChild w30 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.simpleBlobDetector]));
		w30.X = 840;
		w30.Y = 485;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.subtractBg = new global::Gtk.CheckButton();
		this.subtractBg.CanFocus = true;
		this.subtractBg.Name = "subtractBg";
		this.subtractBg.Label = global::Mono.Unix.Catalog.GetString("sub background");
		this.subtractBg.DrawIndicator = true;
		this.subtractBg.UseUnderline = true;
		this.MainLayout.Add(this.subtractBg);
		global::Gtk.Fixed.FixedChild w31 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.subtractBg]));
		w31.X = 970;
		w31.Y = 395;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.imgInvert = new global::Gtk.CheckButton();
		this.imgInvert.CanFocus = true;
		this.imgInvert.Name = "imgInvert";
		this.imgInvert.Label = global::Mono.Unix.Catalog.GetString("invert");
		this.imgInvert.DrawIndicator = true;
		this.imgInvert.UseUnderline = true;
		this.MainLayout.Add(this.imgInvert);
		global::Gtk.Fixed.FixedChild w32 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.imgInvert]));
		w32.X = 970;
		w32.Y = 425;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.downUpSample = new global::Gtk.CheckButton();
		this.downUpSample.CanFocus = true;
		this.downUpSample.Name = "downUpSample";
		this.downUpSample.Label = global::Mono.Unix.Catalog.GetString("down/up sampling");
		this.downUpSample.DrawIndicator = true;
		this.downUpSample.UseUnderline = true;
		this.downUpSample.FocusOnClick = false;
		this.MainLayout.Add(this.downUpSample);
		global::Gtk.Fixed.FixedChild w33 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.downUpSample]));
		w33.X = 970;
		w33.Y = 455;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.gaussianBlur = new global::Gtk.CheckButton();
		this.gaussianBlur.Name = "gaussianBlur";
		this.gaussianBlur.Label = global::Mono.Unix.Catalog.GetString("Guassian Filter");
		this.gaussianBlur.DrawIndicator = true;
		this.gaussianBlur.UseUnderline = true;
		this.gaussianBlur.FocusOnClick = false;
		this.MainLayout.Add(this.gaussianBlur);
		global::Gtk.Fixed.FixedChild w34 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.gaussianBlur]));
		w34.X = 970;
		w34.Y = 485;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.sx = new global::Gtk.SpinButton(0D, 100D, 1D);
		this.sx.WidthRequest = 120;
		this.sx.Name = "sx";
		this.sx.Adjustment.PageIncrement = 10D;
		this.sx.ClimbRate = 1D;
		this.sx.Numeric = true;
		this.MainLayout.Add(this.sx);
		global::Gtk.Fixed.FixedChild w35 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.sx]));
		w35.X = 840;
		w35.Y = 550;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.sy = new global::Gtk.SpinButton(0D, 100D, 1D);
		this.sy.WidthRequest = 120;
		this.sy.Name = "sy";
		this.sy.Adjustment.PageIncrement = 10D;
		this.sy.ClimbRate = 1D;
		this.sy.Numeric = true;
		this.MainLayout.Add(this.sy);
		global::Gtk.Fixed.FixedChild w36 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.sy]));
		w36.X = 840;
		w36.Y = 580;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.sxLabel = new global::Gtk.Label();
		this.sxLabel.Name = "sxLabel";
		this.sxLabel.LabelProp = global::Mono.Unix.Catalog.GetString("kernel width");
		this.MainLayout.Add(this.sxLabel);
		global::Gtk.Fixed.FixedChild w37 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.sxLabel]));
		w37.X = 970;
		w37.Y = 555;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.syLabel = new global::Gtk.Label();
		this.syLabel.Name = "syLabel";
		this.syLabel.LabelProp = global::Mono.Unix.Catalog.GetString("kernel height");
		this.MainLayout.Add(this.syLabel);
		global::Gtk.Fixed.FixedChild w38 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.syLabel]));
		w38.X = 970;
		w38.Y = 585;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.sigmaX = new global::Gtk.SpinButton(0D, 100D, 1D);
		this.sigmaX.WidthRequest = 120;
		this.sigmaX.Name = "sigmaX";
		this.sigmaX.Adjustment.PageIncrement = 10D;
		this.sigmaX.ClimbRate = 1D;
		this.sigmaX.Numeric = true;
		this.MainLayout.Add(this.sigmaX);
		global::Gtk.Fixed.FixedChild w39 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.sigmaX]));
		w39.X = 840;
		w39.Y = 610;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.sigmaY = new global::Gtk.SpinButton(0D, 100D, 1D);
		this.sigmaY.WidthRequest = 120;
		this.sigmaY.Name = "sigmaY";
		this.sigmaY.Adjustment.PageIncrement = 10D;
		this.sigmaY.ClimbRate = 1D;
		this.sigmaY.Numeric = true;
		this.MainLayout.Add(this.sigmaY);
		global::Gtk.Fixed.FixedChild w40 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.sigmaY]));
		w40.X = 840;
		w40.Y = 640;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.sigmaXLabel = new global::Gtk.Label();
		this.sigmaXLabel.Name = "sigmaXLabel";
		this.sigmaXLabel.LabelProp = global::Mono.Unix.Catalog.GetString("stdev (X)");
		this.MainLayout.Add(this.sigmaXLabel);
		global::Gtk.Fixed.FixedChild w41 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.sigmaXLabel]));
		w41.X = 970;
		w41.Y = 615;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.sigmaYLabel = new global::Gtk.Label();
		this.sigmaYLabel.Name = "sigmaYLabel";
		this.sigmaYLabel.LabelProp = global::Mono.Unix.Catalog.GetString("stdev (Y)");
		this.MainLayout.Add(this.sigmaYLabel);
		global::Gtk.Fixed.FixedChild w42 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.sigmaYLabel]));
		w42.X = 970;
		w42.Y = 645;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.normalize = new global::Gtk.CheckButton();
		this.normalize.CanFocus = true;
		this.normalize.Name = "normalize";
		this.normalize.Label = global::Mono.Unix.Catalog.GetString("normalize");
		this.normalize.DrawIndicator = true;
		this.normalize.UseUnderline = true;
		this.MainLayout.Add(this.normalize);
		global::Gtk.Fixed.FixedChild w43 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.normalize]));
		w43.X = 1120;
		w43.Y = 395;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.saveBlobsButton = new global::Gtk.Button();
		this.saveBlobsButton.Name = "saveBlobsButton";
		this.saveBlobsButton.UseUnderline = true;
		this.saveBlobsButton.FocusOnClick = false;
		this.saveBlobsButton.Label = global::Mono.Unix.Catalog.GetString("Save Blobs");
		this.MainLayout.Add(this.saveBlobsButton);
		global::Gtk.Fixed.FixedChild w44 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.saveBlobsButton]));
		w44.X = 60;
		w44.Y = 625;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.saveProcessedImage = new global::Gtk.Button();
		this.saveProcessedImage.Name = "saveProcessedImage";
		this.saveProcessedImage.UseUnderline = true;
		this.saveProcessedImage.FocusOnClick = false;
		this.saveProcessedImage.Label = global::Mono.Unix.Catalog.GetString("Save Processed Image");
		this.MainLayout.Add(this.saveProcessedImage);
		global::Gtk.Fixed.FixedChild w45 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.saveProcessedImage]));
		w45.X = 150;
		w45.Y = 625;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.SelectMode = new global::Gtk.ToggleButton();
		this.SelectMode.WidthRequest = 120;
		this.SelectMode.Name = "SelectMode";
		this.SelectMode.UseUnderline = true;
		this.SelectMode.FocusOnClick = false;
		this.SelectMode.Label = global::Mono.Unix.Catalog.GetString("Ellipse / Box");
		this.MainLayout.Add(this.SelectMode);
		global::Gtk.Fixed.FixedChild w46 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.SelectMode]));
		w46.X = 320;
		w46.Y = 625;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.editRegionLayout = new global::Gtk.Fixed();
		this.editRegionLayout.WidthRequest = 800;
		this.editRegionLayout.HeightRequest = 50;
		this.editRegionLayout.Name = "editRegionLayout";
		this.editRegionLayout.HasWindow = false;
		// Container child editRegionLayout.Gtk.Fixed+FixedChild
		this.regionWidthLabel = new global::Gtk.Label();
		this.regionWidthLabel.Name = "regionWidthLabel";
		this.regionWidthLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Width</b>");
		this.regionWidthLabel.UseMarkup = true;
		this.editRegionLayout.Add(this.regionWidthLabel);
		global::Gtk.Fixed.FixedChild w47 = ((global::Gtk.Fixed.FixedChild)(this.editRegionLayout[this.regionWidthLabel]));
		w47.Y = 5;
		// Container child editRegionLayout.Gtk.Fixed+FixedChild
		this.widthScaleNumeric = new global::Gtk.SpinButton(2D, 1000D, 1D);
		this.widthScaleNumeric.Name = "widthScaleNumeric";
		this.widthScaleNumeric.Adjustment.PageIncrement = 10D;
		this.widthScaleNumeric.ClimbRate = 1D;
		this.widthScaleNumeric.Numeric = true;
		this.widthScaleNumeric.Value = 2D;
		this.editRegionLayout.Add(this.widthScaleNumeric);
		global::Gtk.Fixed.FixedChild w48 = ((global::Gtk.Fixed.FixedChild)(this.editRegionLayout[this.widthScaleNumeric]));
		w48.X = 50;
		// Container child editRegionLayout.Gtk.Fixed+FixedChild
		this.widthScale = new global::Gtk.HScale(null);
		this.widthScale.WidthRequest = 100;
		this.widthScale.Name = "widthScale";
		this.widthScale.Adjustment.Lower = 2D;
		this.widthScale.Adjustment.Upper = 1000D;
		this.widthScale.Adjustment.PageIncrement = 10D;
		this.widthScale.Adjustment.StepIncrement = 1D;
		this.widthScale.DrawValue = false;
		this.widthScale.Digits = 0;
		this.widthScale.ValuePos = ((global::Gtk.PositionType)(2));
		this.editRegionLayout.Add(this.widthScale);
		global::Gtk.Fixed.FixedChild w49 = ((global::Gtk.Fixed.FixedChild)(this.editRegionLayout[this.widthScale]));
		w49.X = 120;
		// Container child editRegionLayout.Gtk.Fixed+FixedChild
		this.heightScaleNumeric = new global::Gtk.SpinButton(2D, 1000D, 1D);
		this.heightScaleNumeric.Name = "heightScaleNumeric";
		this.heightScaleNumeric.Adjustment.PageIncrement = 10D;
		this.heightScaleNumeric.ClimbRate = 1D;
		this.heightScaleNumeric.Numeric = true;
		this.heightScaleNumeric.Value = 2D;
		this.editRegionLayout.Add(this.heightScaleNumeric);
		global::Gtk.Fixed.FixedChild w50 = ((global::Gtk.Fixed.FixedChild)(this.editRegionLayout[this.heightScaleNumeric]));
		w50.X = 50;
		w50.Y = 30;
		// Container child editRegionLayout.Gtk.Fixed+FixedChild
		this.heightScale = new global::Gtk.HScale(null);
		this.heightScale.WidthRequest = 100;
		this.heightScale.CanFocus = true;
		this.heightScale.Name = "heightScale";
		this.heightScale.Adjustment.Lower = 2D;
		this.heightScale.Adjustment.Upper = 1000D;
		this.heightScale.Adjustment.PageIncrement = 10D;
		this.heightScale.Adjustment.StepIncrement = 1D;
		this.heightScale.DrawValue = false;
		this.heightScale.Digits = 0;
		this.heightScale.ValuePos = ((global::Gtk.PositionType)(2));
		this.editRegionLayout.Add(this.heightScale);
		global::Gtk.Fixed.FixedChild w51 = ((global::Gtk.Fixed.FixedChild)(this.editRegionLayout[this.heightScale]));
		w51.X = 120;
		w51.Y = 30;
		// Container child editRegionLayout.Gtk.Fixed+FixedChild
		this.regionHeightLabel = new global::Gtk.Label();
		this.regionHeightLabel.Name = "regionHeightLabel";
		this.regionHeightLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Height</b>");
		this.regionHeightLabel.UseMarkup = true;
		this.editRegionLayout.Add(this.regionHeightLabel);
		global::Gtk.Fixed.FixedChild w52 = ((global::Gtk.Fixed.FixedChild)(this.editRegionLayout[this.regionHeightLabel]));
		w52.Y = 35;
		// Container child editRegionLayout.Gtk.Fixed+FixedChild
		this.dxScaleNumeric = new global::Gtk.SpinButton(-800D, 1600D, 1D);
		this.dxScaleNumeric.Name = "dxScaleNumeric";
		this.dxScaleNumeric.Adjustment.PageIncrement = 10D;
		this.dxScaleNumeric.ClimbRate = 1D;
		this.dxScaleNumeric.Numeric = true;
		this.editRegionLayout.Add(this.dxScaleNumeric);
		global::Gtk.Fixed.FixedChild w53 = ((global::Gtk.Fixed.FixedChild)(this.editRegionLayout[this.dxScaleNumeric]));
		w53.X = 250;
		// Container child editRegionLayout.Gtk.Fixed+FixedChild
		this.dxLabel = new global::Gtk.Label();
		this.dxLabel.Name = "dxLabel";
		this.dxLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>X</b>");
		this.dxLabel.UseMarkup = true;
		this.editRegionLayout.Add(this.dxLabel);
		global::Gtk.Fixed.FixedChild w54 = ((global::Gtk.Fixed.FixedChild)(this.editRegionLayout[this.dxLabel]));
		w54.X = 230;
		w54.Y = 5;
		// Container child editRegionLayout.Gtk.Fixed+FixedChild
		this.dyScaleNumeric = new global::Gtk.SpinButton(-800D, 1600D, 1D);
		this.dyScaleNumeric.Name = "dyScaleNumeric";
		this.dyScaleNumeric.Adjustment.PageIncrement = 10D;
		this.dyScaleNumeric.ClimbRate = 1D;
		this.dyScaleNumeric.Numeric = true;
		this.editRegionLayout.Add(this.dyScaleNumeric);
		global::Gtk.Fixed.FixedChild w55 = ((global::Gtk.Fixed.FixedChild)(this.editRegionLayout[this.dyScaleNumeric]));
		w55.X = 250;
		w55.Y = 30;
		// Container child editRegionLayout.Gtk.Fixed+FixedChild
		this.dyLabel = new global::Gtk.Label();
		this.dyLabel.Name = "dyLabel";
		this.dyLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Y</b>");
		this.dyLabel.UseMarkup = true;
		this.editRegionLayout.Add(this.dyLabel);
		global::Gtk.Fixed.FixedChild w56 = ((global::Gtk.Fixed.FixedChild)(this.editRegionLayout[this.dyLabel]));
		w56.X = 230;
		w56.Y = 35;
		// Container child editRegionLayout.Gtk.Fixed+FixedChild
		this.dxScale = new global::Gtk.HScale(null);
		this.dxScale.WidthRequest = 100;
		this.dxScale.Name = "dxScale";
		this.dxScale.Adjustment.Lower = -800D;
		this.dxScale.Adjustment.Upper = 1600D;
		this.dxScale.Adjustment.PageIncrement = 10D;
		this.dxScale.Adjustment.StepIncrement = 1D;
		this.dxScale.DrawValue = false;
		this.dxScale.Digits = 0;
		this.dxScale.ValuePos = ((global::Gtk.PositionType)(2));
		this.editRegionLayout.Add(this.dxScale);
		global::Gtk.Fixed.FixedChild w57 = ((global::Gtk.Fixed.FixedChild)(this.editRegionLayout[this.dxScale]));
		w57.X = 320;
		// Container child editRegionLayout.Gtk.Fixed+FixedChild
		this.dyScale = new global::Gtk.HScale(null);
		this.dyScale.WidthRequest = 100;
		this.dyScale.Name = "dyScale";
		this.dyScale.Adjustment.Lower = -800D;
		this.dyScale.Adjustment.Upper = 1600D;
		this.dyScale.Adjustment.PageIncrement = 10D;
		this.dyScale.Adjustment.StepIncrement = 1D;
		this.dyScale.DrawValue = false;
		this.dyScale.Digits = 0;
		this.dyScale.ValuePos = ((global::Gtk.PositionType)(2));
		this.editRegionLayout.Add(this.dyScale);
		global::Gtk.Fixed.FixedChild w58 = ((global::Gtk.Fixed.FixedChild)(this.editRegionLayout[this.dyScale]));
		w58.X = 320;
		w58.Y = 30;
		// Container child editRegionLayout.Gtk.Fixed+FixedChild
		this.closeEditButton = new global::Gtk.Button();
		this.closeEditButton.Name = "closeEditButton";
		this.closeEditButton.UseUnderline = true;
		this.closeEditButton.FocusOnClick = false;
		this.closeEditButton.Label = global::Mono.Unix.Catalog.GetString("Close");
		this.editRegionLayout.Add(this.closeEditButton);
		global::Gtk.Fixed.FixedChild w59 = ((global::Gtk.Fixed.FixedChild)(this.editRegionLayout[this.closeEditButton]));
		w59.X = 440;
		this.MainLayout.Add(this.editRegionLayout);
		global::Gtk.Fixed.FixedChild w60 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.editRegionLayout]));
		w60.X = 20;
		w60.Y = 660;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.ClearSelected = new global::Gtk.Button();
		this.ClearSelected.Name = "ClearSelected";
		this.ClearSelected.UseUnderline = true;
		this.ClearSelected.FocusOnClick = false;
		this.ClearSelected.Label = global::Mono.Unix.Catalog.GetString("Clear Selection");
		this.MainLayout.Add(this.ClearSelected);
		global::Gtk.Fixed.FixedChild w61 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.ClearSelected]));
		w61.X = 445;
		w61.Y = 625;
		// Container child MainLayout.Gtk.Fixed+FixedChild
		this.detectFacesButton = new global::Gtk.Button();
		this.detectFacesButton.WidthRequest = 120;
		this.detectFacesButton.Name = "detectFacesButton";
		this.detectFacesButton.UseUnderline = true;
		this.detectFacesButton.FocusOnClick = false;
		this.detectFacesButton.Label = global::Mono.Unix.Catalog.GetString("Faces");
		this.MainLayout.Add(this.detectFacesButton);
		global::Gtk.Fixed.FixedChild w62 = ((global::Gtk.Fixed.FixedChild)(this.MainLayout[this.detectFacesButton]));
		w62.X = 840;
		w62.Y = 515;
		this.Add(this.MainLayout);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 1280;
		this.DefaultHeight = 720;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.ImageEventBox.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler(this.ImageButtonPress);
		this.ImageEventBox.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler(this.ImageButtonRelease);
		this.ImageEventBox.MotionNotifyEvent += new global::Gtk.MotionNotifyEventHandler(this.ImageMotionNotify);
		this.selectImageButton.Clicked += new global::System.EventHandler(this.OnSelectImageButtonClicked);
		this.quitButton.Clicked += new global::System.EventHandler(this.OnQuitButtonClicked);
		this.markerSize.ValueChanged += new global::System.EventHandler(this.OnMarkerSizeValueChanged);
		this.detectCirclesButton.Clicked += new global::System.EventHandler(this.OnDetectCirclesButtonClicked);
		this.detectBlobsButton.Clicked += new global::System.EventHandler(this.OnDetectBlobsButtonClicked);
		this.blobDetectorButton.Clicked += new global::System.EventHandler(this.OnBlobDetectorButtonClicked);
		this.simpleBlobDetector.Clicked += new global::System.EventHandler(this.OnSimpleBlobDetectorClicked);
		this.subtractBg.Toggled += new global::System.EventHandler(this.OnSubtractBgToggled);
		this.imgInvert.Toggled += new global::System.EventHandler(this.OnImgInvertToggled);
		this.downUpSample.Toggled += new global::System.EventHandler(this.OnDownUpSampleToggled);
		this.gaussianBlur.Toggled += new global::System.EventHandler(this.OnGaussianBlurToggled);
		this.sx.ValueChanged += new global::System.EventHandler(this.OnSxValueChanged);
		this.sy.ValueChanged += new global::System.EventHandler(this.OnSyValueChanged);
		this.sigmaX.ValueChanged += new global::System.EventHandler(this.OnSigmaXValueChanged);
		this.sigmaY.ValueChanged += new global::System.EventHandler(this.OnSigmaYValueChanged);
		this.normalize.Toggled += new global::System.EventHandler(this.OnNormalizeToggled);
		this.saveBlobsButton.Clicked += new global::System.EventHandler(this.OnSaveBlobsButtonClicked);
		this.saveProcessedImage.Clicked += new global::System.EventHandler(this.OnSaveProcessedImageClicked);
		this.SelectMode.Toggled += new global::System.EventHandler(this.ToggleSelectMode);
		this.widthScaleNumeric.ValueChanged += new global::System.EventHandler(this.NumericResizeEvent);
		this.widthScale.ValueChanged += new global::System.EventHandler(this.ScaleResizeEvent);
		this.heightScaleNumeric.ValueChanged += new global::System.EventHandler(this.NumericResizeEvent);
		this.heightScale.ValueChanged += new global::System.EventHandler(this.ScaleResizeEvent);
		this.dxScaleNumeric.ValueChanged += new global::System.EventHandler(this.NumericMoveEvent);
		this.dyScaleNumeric.ValueChanged += new global::System.EventHandler(this.NumericMoveEvent);
		this.dxScale.ValueChanged += new global::System.EventHandler(this.ScaleMoveEvent);
		this.dyScale.ValueChanged += new global::System.EventHandler(this.ScaleMoveEvent);
		this.closeEditButton.Clicked += new global::System.EventHandler(this.CloseEdit);
		this.ClearSelected.Clicked += new global::System.EventHandler(this.ClearRegions);
		this.detectFacesButton.Clicked += new global::System.EventHandler(this.OnDetectFacesButtonClicked);
	}
}
