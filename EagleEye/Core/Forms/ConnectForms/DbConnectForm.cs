using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using EagleEye.Core.Storage.FileStorage;

namespace EagleEye.Core.Forms.ConnectForms
{
    public partial class DBConnectForm : Form
    {

        private readonly PostgresConnect _connect;

        public DBConnectForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $@"{Properties.Settings.Default.AppName}: Подключение к БД";

            _connect = PostgresConnect.Load() ?? new PostgresConnect();

            WcApi.Keyboard.Keyboard.SetEnglishLanguage();
        }

        private void DBConnectForm_Load(object sender, EventArgs e)
        {
            // Биндинг к форме

            tbHost.DataBindings.Add("Text", _connect, "Host", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPass.DataBindings.Add("Text", _connect, "Password", false, DataSourceUpdateMode.OnPropertyChanged);
            tbUser.DataBindings.Add("Text", _connect, "Login", false, DataSourceUpdateMode.OnPropertyChanged);
            tbDatabase.DataBindings.Add("Text", _connect, "Database", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPort.DataBindings.Add("Text", _connect, "Port", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SaveConnect()
        {
            _connect.Save();
        }

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

        private void ConnectForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            tbStatus.ForeColor = Color.DimGray;
            tbStatus.Text = "";

            // TODO: Проверка подключения к базе
            bool status = await _connect.TestConnectAsync();
            if (status)
            {
                tbStatus.ForeColor = Color.SeaGreen;
                tbStatus.Text = @"Подключено";
            }
            else
            {
                tbStatus.ForeColor = Color.Firebrick;
                tbStatus.Text = @"Не подключено";
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            string host = Dns.GetHostName();
            // ИП адресса
            List<IPAddress> ipAddresses = Dns.GetHostAddresses(host).Where(a => a.AddressFamily == AddressFamily.InterNetwork).ToList();
            tbHost.Text = ipAddresses.Count > 0 ? ipAddresses[0].ToString() : @"localhost";
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
    }
}
