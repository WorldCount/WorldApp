using System.Drawing;
using System.Windows.Forms;

namespace Wc32Api.Widgets
{
    public class WcProgressBar : ProgressBar
    {
        public WcProgressBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
            DrawingControl.SetDoubleBuffered(this);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;

            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);

            rec.Height = rec.Height - 4;

            e.Graphics.FillRectangle(new SolidBrush(BackColor), 2, 2, rec.Width, rec.Height);
        }
    }
}
