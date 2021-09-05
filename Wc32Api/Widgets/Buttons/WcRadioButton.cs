using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Wc32Api.Widgets.Buttons
{
    public class WcRadioButton : RadioButton
    {
        #region Private Fields

        private Color _checkedColor = Color.SeaGreen;
        private Color _unCheckedColor = Color.FromArgb(53, 58, 66);
        private Color _disableColor = Color.FromArgb(53, 58, 66);

        #endregion

        public WcRadioButton()
        {
            MinimumSize = new Size(0, 21);
        }

        #region Properties

        [Category("WcRadioButton - Appearance")]
        public Color CheckedColor
        {
            get => _checkedColor;
            set
            {
                _checkedColor = value;
                Invalidate();
            }
        }

        [Category("WcRadioButton - Appearance")]
        public Color UnCheckedColor
        {
            get => _unCheckedColor;
            set
            {
                _unCheckedColor = value;
                Invalidate();
            }
        }

        [Category("WcRadioButton - Appearance")]
        public Color DisableColor
        {
            get => _disableColor;
            set
            {
                _disableColor = value;
                Invalidate();
            }
        }

        #endregion

        #region Overridden Methods

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            float rbBorderSize = 18F;
            float rbCheckSize = 12F;

            RectangleF rectRbBorder = new RectangleF
            {
                X = 0.5F,
                Y = (Height - rbBorderSize) / 2, // Center
                Width = rbBorderSize,
                Height = rbBorderSize
            };

            RectangleF rectRbCheck = new RectangleF
            {
                X = rectRbBorder.X + ((rectRbBorder.Width - rbCheckSize) / 2), // Center
                Y = (Height - rbCheckSize) / 2, // Center
                Width = rbCheckSize,
                Height = rbCheckSize
            };

            // Drawing
            using (Pen penBorder = new Pen(_checkedColor, 1.6F))
            using (SolidBrush brushRbCheck = new SolidBrush(_checkedColor))
            using (SolidBrush brushText = new SolidBrush(ForeColor))
            {
                // Draw surface
                graphics.Clear(BackColor);
                // Draw Radio Button
                if (Checked)
                {
                    graphics.DrawEllipse(penBorder, rectRbBorder);
                    graphics.FillEllipse(brushRbCheck, rectRbCheck);
                }
                else
                {
                    penBorder.Color = _unCheckedColor;
                    graphics.DrawEllipse(penBorder, rectRbBorder);
                }

                if (!Enabled)
                {
                    brushRbCheck.Color = _disableColor;
                    graphics.FillEllipse(brushRbCheck, rectRbBorder);
                    Font font = new Font(Font.Name, Font.Size, FontStyle.Strikeout);
                    // ReSharper disable once PossibleLossOfFraction
                    graphics.DrawString(Text, font, brushText, rbBorderSize + 8, (Height - TextRenderer.MeasureText(Text, font).Height) / 2);
                }
                else
                {
                    // ReSharper disable once PossibleLossOfFraction
                    graphics.DrawString(Text, Font, brushText, rbBorderSize + 8, (Height - TextRenderer.MeasureText(Text, Font).Height) / 2);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Width = TextRenderer.MeasureText(Text, Font).Width + 30;

        }

        #endregion
    }
}
