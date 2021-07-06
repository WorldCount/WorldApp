using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using ARM.Core.Context;
using ARM.Core.Forms.ConnectForms;

namespace ARM.Core.Forms
{
    public partial class GeneralForm : Form
    {

        readonly string _appVersion = $"{Application.ProductName} {Application.ProductVersion}";
        readonly string _appText = "EagleEye";

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

        #region Сообщения

        /// <summary>
        /// Отправляет сообщение в статус
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        private void SendStatucMessage(string message, Color color)
        {
            statusText.ForeColor = color;
            statusText.Text = message;
            timerStatus.Start();
        }

        // Сообщение: обычное
        // ReSharper disable once UnusedMember.Global
        public void NormalMessage(string message)
        {
            SendStatucMessage(message, Color.DimGray);
        }

        // Сообщение: успех
        public void SuccessMessage(string message)
        {
            SendStatucMessage(message, Color.Green);
        }

        // Сообщение: ошибка
        public void ErrorMessage(string message)
        {
            SendStatucMessage(message, Color.Firebrick);
        }

        // Сообщение: предупреждение
        public void WarningMessage(string message)
        {
            SendStatucMessage(message, Color.DarkOrange);
        }

        // Сообщение: информация
        public void InfoMessage(string message)
        {
            SendStatucMessage(message, Color.DodgerBlue);
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            statusText.Text = "";
        }

        #endregion

        private void partpostMenuItem_Click(object sender, EventArgs e)
        {
            PartPostConnectForm partPostConnectForm = new PartPostConnectForm();
            partPostConnectForm.ShowDialog(this);
        }

        private void databaseMenuItem_Click(object sender, EventArgs e)
        {
            DBConnectForm dbConnectForm = new DBConnectForm();
            dbConnectForm.ShowDialog(this);
        }

        private async void createDbMenuItem_Click(object sender, EventArgs e)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                try
                {
                    await db.Database.EnsureCreatedAsync();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show(@"Подключение к БД еще не настроено", @"Ошибка подключения", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (Npgsql.PostgresException)
                {
                    MessageBox.Show(@"Не могу подключиться к серверу БД", @"Ошибка доступа к серверу", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnSync.Enabled = !btnSync.Enabled;
        }
    }
}
