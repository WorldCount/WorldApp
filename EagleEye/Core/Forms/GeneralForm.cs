using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace EagleEye.Core.Forms
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();

            WebRequest.DefaultWebProxy = null;

            // Если было обновление приложения
            if (Properties.Settings.Default.NeedUpgrade)
                UpgradeSettings();

            // ReSharper disable once VirtualMemberCallInConstructor
            // ReSharper disable once LocalizableElement
            Text = $"{Properties.Settings.Default.AppName} {Application.ProductVersion}";

            LoadPos();

            // Загрузка настроек
            LoadSettings();

            // Чтение аргументов
            CheckArgs();
        }

        #region Настройка формы

        // Загрузка настроек
        private void LoadSettings()
        {
            // Последняя активная вкладка
            try
            {
                tabsControl.SelectedIndex = Properties.Settings.Default.ActiveTab;
            }
            catch
            {
                tabsControl.SelectedIndex = 0;
            }
        }

        // Сохранение настроек
        private void SaveSettings()
        {
            // Последняя активная вкладка
            int tabIndex = tabsControl.SelectedIndex;
            Properties.Settings.Default.ActiveTab = tabIndex;

            Properties.Settings.Default.Save();
        }

        // Перенос настроек предыдущей сборки в новую
        private void UpgradeSettings()
        {
            Properties.Settings.Default.Upgrade();
            Properties.Settings.Default.NeedUpgrade = false;
            Properties.Settings.Default.Save();
        }

        // Загрузка расположения окна
        private void LoadPos()
        {
            int width = Settings.FormsPosition.Default.GeneralFormSize.Width;
            int height = Settings.FormsPosition.Default.GeneralFormSize.Height;

            if (width == 0 || height == 0)
            {
                // Первый старт
                StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                WindowState = Settings.FormsPosition.Default.GeneralFormState;

                // Нам не нужно свернутое окно при запуске
                if (WindowState == FormWindowState.Minimized)
                    WindowState = FormWindowState.Normal;

                this.Location = Settings.FormsPosition.Default.GeneralFormLocation;
                Size = Settings.FormsPosition.Default.GeneralFormSize;
            }
        }

        // Сохранение расположения окна
        private void SavePos()
        {
            Settings.FormsPosition.Default.GeneralFormState = WindowState;

            if (WindowState == FormWindowState.Normal)
            {
                Settings.FormsPosition.Default.GeneralFormLocation = Location;
                Settings.FormsPosition.Default.GeneralFormSize = Size;
            }
            else
            {
                // Если форма свернута или развернута
                Settings.FormsPosition.Default.GeneralFormLocation = RestoreBounds.Location;
                Settings.FormsPosition.Default.GeneralFormSize = RestoreBounds.Size;
            }

            Settings.FormsPosition.Default.Save();
        }

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

        }

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            SavePos();
        }

        #endregion


    }
}
