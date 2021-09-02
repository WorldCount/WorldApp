using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DwUtils.Core.Database;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Forms.ConnectForms;

namespace DwUtils.Core.Forms
{
    public partial class GeneralForm : Form
    {
        #region Private Fields

        private bool _debugMode;
        private Db _database;
        private string _lkState;

        #endregion

        public GeneralForm()
        {
            InitializeComponent();

            // Если было обновление приложения
            if (Properties.Settings.Default.NeedUpgrade)
                UpgradeSettings();

            // ReSharper disable once VirtualMemberCallInConstructor
            // ReSharper disable once LocalizableElement
            Text = $"{Properties.Settings.Default.AppName} {Application.ProductVersion}";

            // Загрузка настроек
            LoadSettings();
        }

        #region Form Config

        // Загрузка настроек
        private void LoadSettings()
        {
            _debugMode = Properties.Settings.Default.DebugMode;
            btnDebug.Checked = Properties.Settings.Default.DebugMode;
            _database = new Db(PostItemConnect.GetConnect(), PostUnitConnect.GetConnect(), _debugMode);

            int lastTabIndex = Properties.Settings.Default.LastTabIndex;
            tabControl.SelectedIndex = lastTabIndex >= tabControl.TabCount ? 0 : lastTabIndex;

            _lkState = Properties.Settings.Default.LkApiUrl;

            CheckLkState();
        }

        // Сохранение настроек
        private void SaveSettings()
        {
            Properties.Settings.Default.LastTabIndex = tabControl.SelectedIndex;
            Properties.Settings.Default.Save();

            if (_database != null && !string.IsNullOrEmpty(_lkState))
            {
                _database.SetLkApiUrl(_lkState);
            }
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

                Location = Settings.FormsPosition.Default.GeneralFormLocation;
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

            LoadPos();

            // Чтение аргументов
            CheckArgs();
        }

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            SavePos();
        }

        #endregion

        #region Messages

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

        #region Private Methods

        private async void CheckLkState()
        {
            if (_database != null)
            {
                string state = await _database.GetLkApiUrlAsync();
                toggleLoadLk.Checked = !string.IsNullOrEmpty(state);
            }
        }

        #endregion

        #region Menu Events
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void connectPostUnitMenuItem_Click(object sender, EventArgs e)
        {
            PostUnitConnectForm postUnitConnectForm = new PostUnitConnectForm();

            if (postUnitConnectForm.ShowDialog(this) == DialogResult.OK)
                _database = new Db(PostItemConnect.GetConnect(), PostUnitConnect.GetConnect(), _debugMode);
        }

        private void connectPostItemMenuItem_Click(object sender, EventArgs e)
        {
            PostItemConnectForm postItemConnectForm = new PostItemConnectForm();

            if (postItemConnectForm.ShowDialog(this) == DialogResult.OK)
                _database = new Db(PostItemConnect.GetConnect(), PostUnitConnect.GetConnect(), _debugMode);
        }

        private void configMenuItem_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            if (configForm.ShowDialog(this) == DialogResult.OK)
                _lkState = Properties.Settings.Default.LkApiUrl;
        }

        #endregion

        #region Toggle Events

        private void btnDebug_CheckedChanged(object sender, EventArgs e)
        {
            _debugMode = btnDebug.Checked;
            Properties.Settings.Default.DebugMode = _debugMode;
            _database = new Db(PostItemConnect.GetConnect(), PostUnitConnect.GetConnect(), _debugMode);
            Properties.Settings.Default.Save();
        }

        private async void toggleLoadLk_CheckedChanged(object sender, EventArgs e)
        {
            bool res;

            if (toggleLoadLk.Checked)
                res = await _database.SetLkApiUrlAsync(_lkState);
            else
                res = await _database.SetLkApiUrlAsync("");

            if(res)
                SuccessMessage("Статус загрузки ЛК изменен.");
            else
                ErrorMessage("Ошибка изменения статуса ЛК.");
        }

        #endregion

        private async void btnLoadFreeRpo_Click(object sender, EventArgs e)
        {
            freeRpoLabelCount.Text = "0";

            List <FreeRpo> rpos = await _database.GetFreeRposAsync();
            freeRpoBindingSource.DataSource = null;
            freeRpoBindingSource.DataSource = rpos;

            if (rpos != null)
                freeRpoLabelCount.Text = rpos.Count.ToString();
        }
    }
}
