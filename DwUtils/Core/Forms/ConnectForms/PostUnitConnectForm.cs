﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DwUtils.Core.Database.Connects;

namespace DwUtils.Core.Forms.ConnectForms
{
    public partial class PostUnitConnectForm : Form
    {

        #region Private Fields

        private const int BorderSize = 2;
        private readonly PostUnitConnect _connect;

        #endregion
        

        public PostUnitConnectForm()
        {
            InitializeComponent();

            _connect = PostUnitConnect.GetConnect();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Подключение к PostUnit";

            Padding = new Padding(BorderSize);
            // Border Color
            BackColor = Color.FromArgb(45,45,48);

            WcApi.Keyboard.Keyboard.SetEnglishLanguage();
        }

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

            tbPath.Refresh();
            tbHost.Refresh();
            tbPass.Refresh();
            tbUser.Refresh();
            tbPort.Refresh();
            tbStatus.Refresh();
        }

        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #endregion

        #region Private Methods

        private void SaveConnect()
        {
            _connect.Save();
        }

        #endregion

        #region TextBox Events

        private void tbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Form Events

        private void form_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(_connect.Login))
                _connect.Login = "SYSDBA";

            if (string.IsNullOrEmpty(_connect.Password))
                _connect.Password = "masterkey";

            cbType.Items.Add("Стандартный");
            cbType.Items.Add("Встроенный");
            tbUser.CharacterCasing = CharacterCasing.Upper;

            tbHost.DataBindings.Add("Text", _connect, "Host", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPass.DataBindings.Add("Text", _connect, "Password", false, DataSourceUpdateMode.OnPropertyChanged);
            tbUser.DataBindings.Add("Text", _connect, "Login", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPath.DataBindings.Add("Text", _connect, "Path", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPort.DataBindings.Add("Text", _connect, "Port", false, DataSourceUpdateMode.OnPropertyChanged);
            cbType.DataBindings.Add("SelectedIndex", _connect, "ServerType", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();

            // Нажатие Ctrl + R
            if (e.KeyCode == Keys.R && e.Control)
                btnCheck.PerformClick();
        }

        #endregion

        #region Buttons Events

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            tbStatus.ForeColor = Color.DimGray;
            tbStatus.Text = "";

            bool status = await _connect.TestConnectAsync();
            if (status)
            {
                tbStatus.ForeColor = Color.SeaGreen;
                tbStatus.Text = "Подключено";
            }
            else
            {
                tbStatus.ForeColor = Color.Firebrick;
                tbStatus.Text = "Не подключено";
            }
        }

        private void btnGetHost_Click(object sender, EventArgs e)
        {
            string host = Dns.GetHostName();
            // ИП адресса
            List<IPAddress> ipAddresses = Dns.GetHostAddresses(host).Where(a => a.AddressFamily == AddressFamily.InterNetwork).ToList();
            tbHost.Text = ipAddresses.Count > 0 ? ipAddresses[0].ToString() : @"localhost";
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog { Filter = @"POSTUNIT.IB|POSTUNIT.IB" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName != "")
                {
                    tbPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveConnect();
            DialogResult = DialogResult.OK;
            Close();
        }

        #endregion

        
    }
}
