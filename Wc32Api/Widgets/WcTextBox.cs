using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Wc32Api.Widgets
{
    [DefaultEvent("_TextChanged")]
    public partial class WcTextBox : UserControl
    {
        #region Private Fields

        private Color _borderColor = Color.SeaGreen;
        private Color _borderFocusColor = Color.Firebrick;
        private int _borderSize = 2;
        private bool _underlinedStyle;
        private bool _isFocused;


        private Color _enableForeColor;
        private Color _enableBackColor;
        private Color _disableForeColor = Color.DimGray;
        private Color _disableBackColor = Color.DarkGray;
        private Color _disableBorderColor = Color.DimGray;

        #endregion

        public WcTextBox()
        {
            InitializeComponent();
        }

        #region Events

        [Category("WcTextBox")]
        // ReSharper disable once InconsistentNaming
        public event EventHandler _TextChanged;

        #endregion

        #region Public Properties

        [Browsable(false)]
        public override string Text { get; set; }

        [Category("WcTextBox - Appearance")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        [Category("WcTextBox - Appearance")]
        public Color BorderFocusColor
        {
            get => _borderFocusColor;
            set
            {
                _borderFocusColor = value;
                Invalidate();
            }
        }

        [Category("WcTextBox - Appearance")]
        public int BorderSize
        {
            get => _borderSize;
            set
            {
                _borderSize = value;
                Invalidate();
            }
        }

        [Category("WcTextBox - Appearance")]
        public bool UnderlinedStyle
        {
            get => _underlinedStyle;
            set
            {
                _underlinedStyle = value;
                Invalidate();
            }
        }

        [Category("WcTextBox - Appearance")]
        public bool UsePasswordChar
        {
            get => textBox.UseSystemPasswordChar;
            set => textBox.UseSystemPasswordChar = value;
        }

        [Category("WcTextBox - Appearance")]
        public char PasswordChar
        {
            get => textBox.PasswordChar;
            set => textBox.PasswordChar = value;
        }

        [Category("WcTextBox - Appearance")]
        public bool Multiline
        {
            get => textBox.Multiline;
            set => textBox.Multiline = value;
        }

        [Category("WcTextBox - Appearance")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                textBox.BackColor = value;
            }
        }

        [Category("WcTextBox - Appearance")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                textBox.ForeColor = value;
            }
        }

        [Category("WcTextBox - Appearance")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                textBox.Font = value;

                if(DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("WcTextBox - Data")]
        public string Texts
        {
            get => textBox.Text; 
            set => textBox.Text = value;
        }

        [Category("WcTextBox - Appearance Disable")]
        public Color DisableForeColor
        {
            get => _disableForeColor;
            set => _disableForeColor = value;
        }

        [Category("WcTextBox - Appearance Disable")]
        public Color DisableBackColor
        {
            get => _disableBackColor;
            set => _disableBackColor = value;
        }

        [Category("WcTextBox - Appearance Disable")]
        public Color DisableBorderColor
        {
            get => _disableBorderColor;
            set => _disableBorderColor = value;
        }

        [Category("WcTextBox - Appearance Format")]
        public CharacterCasing CharacterCasing
        {
            get => textBox.CharacterCasing;
            set => textBox.CharacterCasing = value;
        }

        #endregion

        #region Overidden Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;

            // Draw border
            using (Pen penBorder = new Pen(_borderColor, _borderSize))
            {

                if (!Enabled)
                    penBorder.Color = DisableBorderColor;

                penBorder.Alignment = PenAlignment.Inset;

                if (!_isFocused)
                {

                    if (_underlinedStyle)
                        graphics.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                    else
                        graphics.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
                }
                else
                {
                    penBorder.Color = !Enabled ? DisableBorderColor : _borderFocusColor;

                    if (_underlinedStyle)
                        graphics.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                    else
                        graphics.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if(DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        #endregion

        #region Private Methods

        private void UpdateControlHeight()
        {
            if (textBox.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
                textBox.Multiline = true;
                textBox.MinimumSize = new Size(0, txtHeight);
                textBox.Multiline = false;

                Height = textBox.Height + Padding.Top + Padding.Bottom;
            }
        }

        #endregion

        #region TextBox Event
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            _TextChanged?.Invoke(sender, e);
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void textBox_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void textBox_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            OnEnter(e);
            _isFocused = true;
            Invalidate();
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            OnLeave(e);
            _isFocused = false;
            Invalidate();
        }
        #endregion

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            if (!Enabled)
            {
                _enableForeColor = ForeColor;
                _enableBackColor = BackColor;
            }

            if (Enabled)
            {
                ForeColor = _enableForeColor;
                BackColor = _enableBackColor;
            }
            else
            {
                ForeColor = _disableBackColor;
                BackColor = _disableBackColor;
            }
        }
    }
}
