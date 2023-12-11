using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using Tree_Gui.Custom_Controls;
using System.Windows.Forms;

namespace Tree_Gui.Custom_Controls {
    public partial class CustomButton : Button {
        #region Custom properties

        private Color _borderColour = Color.White;
        [Category("_CustomButton Appearance")]
        public Color BorderColor {
            get => _borderColour;
            set {
                _borderColour = value;
                Invalidate();
            }
        }

        private int _borderWidth = 0;
        [Category("_CustomButton Appearance")]
        public int BorderWidth {
            get => _borderWidth;
            set {
                _borderWidth = value;
                Invalidate();
            }
        }

        private int _cornerRadius = 0;
        [Category("_CustomButton Appearance")]
        public int CornerRadius {
            get => _cornerRadius;
            set {
                _cornerRadius = value;
                Invalidate();
            }
        }

        #endregion

        public CustomButton() {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.White;
            ForeColor = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;

            Rectangle rectangleSurface = ClientRectangle;
            Rectangle borders = Rectangle.Inflate(rectangleSurface, -BorderWidth, -BorderWidth);

            int smoothSize = BorderWidth > 0 ? BorderWidth : 2;

            if (CornerRadius > 2) {
                using GraphicsPath pathSurface = CustomControlGraphics.GetRoundedRectGraphicPath(rectangleSurface, CornerRadius);
                using GraphicsPath pathBorder = CustomControlGraphics.GetRoundedRectGraphicPath(borders, CornerRadius - BorderWidth);
                using Pen penSurface = new(Parent.BackColor, smoothSize);
                using Pen penBorder = new(BorderColor, BorderWidth);

                graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Region = new Region(pathSurface);

                graphics.DrawPath(penSurface, pathSurface);

                if (BorderWidth >= 1) graphics.DrawPath(penBorder, pathBorder);
            }
            else {
                graphics.SmoothingMode = SmoothingMode.None;
                Region = new Region(rectangleSurface);

                if (BorderWidth <= 1) return;

                using Pen penBorder = new(BorderColor, BorderWidth);

                penBorder.Alignment = PenAlignment.Inset;
                graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
            }
        }
        
        protected override void OnBackColorChanged(EventArgs e) {
            base.OnBackColorChanged(e);
            Invalidate();
        }
    }
}
