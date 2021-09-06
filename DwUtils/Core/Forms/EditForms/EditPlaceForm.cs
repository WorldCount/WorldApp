using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DwUtils.Core.Database.Models;

namespace DwUtils.Core.Forms.EditForms
{
    public partial class EditPlaceForm : Form
    {

        #region Private Fields

        private const int BorderSize = 2;
        private Place _selectPlace;
        private readonly List<Place> _places;

        #endregion

        public EditPlaceForm(List<Place> places)
        {
            InitializeComponent();

            _places = places;

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Изменение участка";

            Padding = new Padding(BorderSize);
            // Border Color
            BackColor = Color.FromArgb(45, 45, 48);
        }


        #region Public Properties

        public Place Place => _selectPlace;

        #endregion

        #region Design

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
                    if (Padding.Top != BorderSize)
                        Padding = new Padding(BorderSize);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void form_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #endregion

        #region Form Events

        private void form_Load(object sender, EventArgs e)
        {
            placeBindingSource.DataSource = _places;
            _selectPlace = (Place)cbPlace.SelectedItem;
        }

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        #endregion

        #region Button Events

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        #endregion

        #region Other Events

        private void cbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectPlace = (Place) cbPlace.SelectedItem;
        }

        #endregion

    }
}
