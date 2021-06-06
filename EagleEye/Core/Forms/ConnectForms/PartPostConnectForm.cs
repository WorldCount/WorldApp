using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace EagleEye.Core.Forms.ConnectForms
{
    public partial class PartPostConnectForm : Form
    {
        public PartPostConnectForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $@"{Properties.Settings.Default.AppName}: Подключение";


            // TODO: Доделать инициализацию

            WcApi.Keyboard.Keyboard.SetEnglishLanguage();
        }

        private void PartPostConnectForm_Load(object sender, EventArgs e)
        {
            // TODO: Биндинг к форме
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
            // TODO: Проверка подключения к партионной почте
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            string host = Dns.GetHostName();
            // ИП адресса
            List<IPAddress> ipAddresses = Dns.GetHostAddresses(host).Where(a => a.AddressFamily == AddressFamily.InterNetwork).ToList();
            tbHost.Text = ipAddresses.Count > 0 ? ipAddresses[0].ToString() : @"localhost";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog { Filter = @"PARTPOST.IB|PARTPOST.IB" };
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
            // TODO: Сделать сохранение - SaveConnect();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
