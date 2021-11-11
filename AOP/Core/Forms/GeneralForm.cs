using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AOP.Core.Views;
using Wc32Api.Messages;
using Wc32Api.Widgets.Menus;

namespace AOP.Core.Forms
{
    public partial class GeneralForm : Form
    {
        #region Private Fields

        private readonly StatusMessage _message;
        private readonly GeneralView _view;

        #endregion

        public GeneralForm()
        {
            InitializeComponent();

            _message = new StatusMessage(statusText);
            _view = new GeneralView(this);

            // Если было обновление приложения
            if (Properties.Settings.Default.NeedUpgrade)
                _view.UpgradeSettings();

            // Загрузка настроек
            _view.LoadSettings();

            wcDropdownMenuSettings.PrimaryColor = Color.FromArgb(42, 47, 56);
            wcDropdownMenuFile.PrimaryColor = Color.FromArgb(42, 47, 56);
        }

        #region Form Config

        // Чтение переданных параметров
        private void CheckArgs()
        {
            string[] args = Environment.GetCommandLineArgs();

            // Восстановление положения окна
            if (args.Contains("-restore"))
                CenterToScreen();
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            _view.LoadPos();

            // Чтение аргументов
            CheckArgs();
        }

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _view.SaveSettings();
            _view.SavePos();
        }

        #endregion

        #region Menu Events

        private void OpenDropdownMenu(WcDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += (s, ev) => dropdownMenu_VisibleChanged(s, ev, control);
            dropdownMenu.Show(control, control.Top, control.Height);
        }

        private void dropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctrl)
        {
            WcDropdownMenu dropdownMenu = (WcDropdownMenu)sender;
            if (!DesignMode)
            {
                ctrl.BackColor = dropdownMenu.Visible ? Color.FromArgb(28, 32, 38) : Color.FromArgb(42, 47, 56);
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void configMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fileMenuItem_Click(object sender, EventArgs e)
        {
            OpenDropdownMenu(wcDropdownMenuFile, fileMenuItem);
        }

        private void settingsMenuItem_Click(object sender, EventArgs e)
        {
            OpenDropdownMenu(wcDropdownMenuSettings, settingsMenuItem);
        }

        #endregion
    }
}
