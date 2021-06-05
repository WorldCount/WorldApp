using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Wc32Api.Widgets
{
    public class WcButton : Button
    {
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float m = 2.75F;
            float r2 = radius / 2f;
            GraphicsPath graphPath = new GraphicsPath();

            graphPath.AddArc(Rect.X + m, Rect.Y + m, radius, radius, 180, 90);
            graphPath.AddLine(Rect.X + r2 + m, Rect.Y + m, Rect.Width - r2 - m, Rect.Y + m);
            graphPath.AddArc(Rect.X + Rect.Width - radius - m, Rect.Y + m, radius, radius, 270, 90);
            graphPath.AddLine(Rect.Width - m, Rect.Y + r2, Rect.Width - m, Rect.Height - r2 - m);
            graphPath.AddArc(Rect.X + Rect.Width - radius - m, Rect.Y + Rect.Height - radius - m, radius, radius, 0, 90);
            graphPath.AddLine(Rect.Width - r2 - m, Rect.Height - m, Rect.X + r2 - m, Rect.Height - m);
            graphPath.AddArc(Rect.X + m, Rect.Y + Rect.Height - radius - m, radius, radius, 90, 90);
            graphPath.AddLine(Rect.X + m, Rect.Height - r2 - m, Rect.X + m, Rect.Y + r2 + m);

            graphPath.CloseFigure();
            return graphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int borderRadius = 4;
            float borderThickness = 1;
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, Width, Height);
            GraphicsPath graphPath = GetRoundPath(Rect, borderRadius);

            Region = new Region(graphPath);
            using (Pen pen = new Pen(Color.Silver, borderThickness))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, graphPath);
            }
        }
    }
}
