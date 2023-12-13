﻿using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms.Design;

namespace Tree_Gui.Custom_Controls;

[Designer(typeof(ParentControlDesigner))]
public partial class PictureFrame : Control {

    private Image? _image;
    private Rectangle? _imagePortion;
    private int _borderWidth = 2;
    private Color _borderColorOne = Color.White;
    private Color _borderColorTwo = Color.Black;
    private Rectangle _gradientRectangle = Rectangle.Empty;
    private int _gradientAngle = 45;

    [Category("_CustomPictureBox Image")]
    public Image? Image {
        get => _image;
        set {
            _image = value;
            Invalidate();
        }
    }

    [Category("_CustomPictureBox Image")]
    public Size ImageSize {
        get => _image.Size;
    }

    [Category("_CustomPictureBox Image")]
    public Rectangle? ImagePortion {
        get => _imagePortion;
        set {
            _imagePortion = value;
            Refresh();
        }
    }

    [Category("_CustomPictureBox Border")]
    public int BorderWidth {
        get => _borderWidth;
        set {
            _borderWidth = value;
            Invalidate();
        }
    }

    [Category("_CustomPictureBox Border")]
    public Color BorderColorOne {
        get => _borderColorOne; 
        set {
            _borderColorOne = value;
            Invalidate();
        }
    }

    [Category("_CustomPictureBox Border")]
    public Color BorderColorTwo {
        get => _borderColorTwo;
        set {
            _borderColorTwo = value;
            Invalidate();
        }
    }

    [Category("_CustomPictureBox Border")]
    public Rectangle GradientRectangle {
        get => _gradientRectangle;
        set {
            _gradientRectangle = value;
            Invalidate();
        }
    }

    [Category("_CustomPictureBox Border")]
    public int GradientAngle {
        get => _gradientAngle;
        set {
            _gradientAngle = value;
            Invalidate();
        }
    }

    public PictureFrame() { 
        DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e) {
        base.OnPaint(e);

        // Setup the graphics
        Graphics graphics = e.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Do not try to draw any graphics if there is no image
        // This would cause an error within the designer which is awkward to resolve
        if (Image is not null && ImagePortion is not null) {
            // Draw the specified portion of the background image
            e.Graphics.DrawImage(Image, DisplayRectangle, (Rectangle)ImagePortion, GraphicsUnit.Pixel);
        }

        // Create a circular display region
        using GraphicsPath regionPath = new();
        regionPath.AddEllipse(DisplayRectangle);
        Region = new Region(regionPath);

        if (BorderWidth > 0 && GradientRectangle != Rectangle.Empty) {
            using Pen borderPen = new(new LinearGradientBrush(GradientRectangle, BorderColorOne, BorderColorTwo, GradientAngle), BorderWidth);
            graphics.DrawEllipse(borderPen, regionPath.GetBounds());
        }


        // Draw a border around the form that is the same colour as the background to achieve a smooth border
        // This strange arragement of graphics operations is required to remove any artefacts, which I deem unacceptable
        using Pen smoothingPen = new(Parent!.BackColor, 2);
        using Pen backingPen = new(Parent!.BackColor, 2);
        graphics.DrawEllipse(smoothingPen, Rectangle.Inflate(DisplayRectangle, -1, -1));
        graphics.SmoothingMode = SmoothingMode.None;
        graphics.DrawEllipse(backingPen, DisplayRectangle);
    }

    [Flags]
    public enum BorderStyle {
        None,
        Rectangle,
        Ellipse
    }
}