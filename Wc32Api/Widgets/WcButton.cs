using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Wc32Api.Widgets
{
    public class WcButton : Button
    {
        private int _borderRadius = 4;
        private float _borderThickness = 1;
        private Color _borderColor = Color.Silver;

        [Category("Appearance")]
        [Description("Defines the radius of the controls RoundedCorners.")]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                if (_borderRadius == value)
                    return;
                _borderRadius = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Defines the radius of the controls RoundedCorners.")]
        public float BorderThickness
        {
            get => _borderThickness;
            set
            {
                if (_borderThickness == value)
                    return;
                _borderThickness = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Defines the radius of the controls RoundedCorners.")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                if (_borderColor == value)
                    return;
                _borderColor = value;
                Invalidate();
            }
        }

        GraphicsPath GetRoundPath(RectangleF rect, int radius)
        {
            float m = 2.75F;
            float r2 = radius / 2f;
            GraphicsPath graphPath = new GraphicsPath();

            graphPath.AddArc(rect.X + m, rect.Y + m, radius, radius, 180, 90);
            graphPath.AddLine(rect.X + r2 + m, rect.Y + m, rect.Width - r2 - m, rect.Y + m);
            graphPath.AddArc(rect.X + rect.Width - radius - m, rect.Y + m, radius, radius, 270, 90);
            graphPath.AddLine(rect.Width - m, rect.Y + r2, rect.Width - m, rect.Height - r2 - m);
            graphPath.AddArc(rect.X + rect.Width - radius - m, rect.Y + rect.Height - radius - m, radius, radius, 0, 90);
            graphPath.AddLine(rect.Width - r2 - m, rect.Height - m, rect.X + r2 - m, rect.Height - m);
            graphPath.AddArc(rect.X + m, rect.Y + rect.Height - radius - m, radius, radius, 90, 90);
            graphPath.AddLine(rect.X + m, rect.Height - r2 - m, rect.X + m, rect.Y + r2 + m);

            graphPath.CloseFigure();
            return graphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, Width, Height);
            GraphicsPath graphPath = GetRoundPath(Rect, _borderRadius);

            Region = new Region(graphPath);
            using (Pen pen = new Pen(_borderColor, _borderThickness))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, graphPath);
            }
        }
    }
}
