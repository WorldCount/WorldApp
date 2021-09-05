using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WcDesingApp.Core.Forms
{
    public partial class WcForm : Form
    {

        #region Private Fields

        private int _borderSize = 2;

        #endregion

        public WcForm()
        {
            InitializeComponent();

            Padding = new Padding(_borderSize);
            // Border Color
            BackColor = Color.FromArgb(53, 56, 58);
        }

        #region Design

        #region Public Properties

        [Browsable(true)]
        [Category("WcForm - Appearance")]
        public int BorderSize
        {
            get => _borderSize;
            set => _borderSize = value;
        }

        #endregion

        #region Overriddes Properties

        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                labelTitle.Text = value;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        #endregion

        #region Extension

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        #region Overriddes Methods

        protected override void WndProc(ref Message m)
        {
            // ReSharper disable once InconsistentNaming
            const int WM_NCCALCSIZE = 0x0083;
            // ReSharper disable once InconsistentNaming
            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;

            // ReSharper disable once InconsistentNaming
            const int HTCLIENT = 1;
            // ReSharper disable once InconsistentNaming
            const int HTLEFT = 10;
            // ReSharper disable once InconsistentNaming
            const int HTRIGHT = 11;
            // ReSharper disable once InconsistentNaming
            const int HTTOP = 12;
            // ReSharper disable once InconsistentNaming
            const int HTTOPLEFT = 13;
            // ReSharper disable once InconsistentNaming
            const int HTTOPRIGHT = 14;
            // ReSharper disable once InconsistentNaming
            const int HTBOTTOM = 15;
            // ReSharper disable once InconsistentNaming
            const int HTBOTTOMLEFT = 16;
            // ReSharper disable once InconsistentNaming
            const int HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);

                if (WindowState == FormWindowState.Normal)
                {
                    if ((int)m.Result == HTCLIENT)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = PointToClient(screenPoint);

                        if (clientPoint.Y <= resizeAreaSize)
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTTOPLEFT;
                            else if (clientPoint.X < (Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTTOP;
                            else
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (Size.Height - resizeAreaSize))
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (Width - resizeAreaSize))
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTBOTTOM;
                            else
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }

                return;
            }

            // Remove border
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            base.WndProc(ref m);
        }

        #endregion

        #region Private Methods

        private void AdjustForm()
        {
            switch (WindowState)
            {
                case FormWindowState.Maximized:
                    Padding = new Padding(8, 8, 8, 0);
                    break;

                case FormWindowState.Normal:
                    if (Padding.Top != _borderSize)
                        Padding = new Padding(_borderSize);
                    break;
            }
        }

        #endregion

        #region Form Extends Event

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #endregion


    }
}
