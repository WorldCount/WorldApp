using System;
using System.Drawing;
using System.Windows.Forms;

namespace DwUtils.Core.Forms
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Настройки";
        }

        #region Private Methods

                private void LoadConfigs()
        {
            lkTbApiUrl.Text = Properties.Settings.Default.LkApiUrl;
        }

        private void SaveConfig()
        {
            Properties.Settings.Default.LkApiUrl = lkTbApiUrl.Text.Trim();
            Properties.Settings.Default.Save();
        }

        #endregion

        #region Widgets Events

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveConfig();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

        #region Form Events

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private void form_Load(object sender, EventArgs e)
        {
            LoadConfigs();

            if (!Properties.Settings.Default.IsAdmin)
            {
                lkTbApiUrl.ReadOnly = true;
                lkTbApiUrl.BackColor = Color.Gainsboro;
            }
        }

        #endregion

        
    }
}
