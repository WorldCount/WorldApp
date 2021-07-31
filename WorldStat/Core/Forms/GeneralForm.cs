using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WorldStat.Core.Database.Contexts;
using WorldStat.Core.Database.Models;
using WorldStat.Core.Parsers;
using WorldStat.Core.Storage;

namespace WorldStat.Core.Forms
{
    public partial class GeneralForm : Form
    {

        #region Private Field

        private string[] _reportsPaths;

        #endregion

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

            // Загрузка настроек
            LoadSettings();
        }

        #region Form Config

        // Загрузка настроек
        private void LoadSettings()
        {
        }

        // Сохранение настроек
        private void SaveSettings()
        {

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

        private async void GeneralForm_Load(object sender, EventArgs e)
        {

            LoadPos();

            // Чтение аргументов
            CheckArgs();

            if (!File.Exists(PathManager.DatabasePath))
                using (var db = new WorldStatContext())
                {
                    try
                    {
                        await db.Database.EnsureCreatedAsync();
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show(@"Не могу создать базу данных", @"Ошибка создания БД", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
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

        #region Menu Event

        private void loadFrankReportMenuItem_Click(object sender, EventArgs e)
        {

            string lastDir = Properties.Settings.Default.LastOpenDir;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true, Filter = @"Все файлы (*.*)|*.*|Отчеты (*.xls)|*.xls", RestoreDirectory = false
            };

            if (!string.IsNullOrEmpty(lastDir))
                openFileDialog.InitialDirectory = Directory.Exists(lastDir) ? lastDir : @"C:\";
            else
                openFileDialog.InitialDirectory = @"C:\";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                _reportsPaths = openFileDialog.FileNames;

                if (_reportsPaths.Length > 0)
                {
                    Properties.Settings.Default.LastOpenDir = Path.GetDirectoryName(_reportsPaths[0]);
                    Properties.Settings.Default.Save();
                }

                ParseReports();
            }

            openFileDialog = null;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Private Methods

        private void ParseReports()
        {
            LoadReportForm loadReportForm = new LoadReportForm(_reportsPaths);
            loadReportForm.ShowDialog(this);

            loadReportForm = null;


            //string json = JsonConvert.SerializeObject(dictKeys, Formatting.Indented);
            //string jsonData = JsonConvert.SerializeObject(mailCodes, Formatting.Indented);
            //File.WriteAllText(Path.Combine(PathManager.DataDir, "data.json"), json);
            //File.WriteAllText(Path.Combine(PathManager.DataDir, "mailCodes.json"), jsonData);
        }

        #endregion

        private void btnLoadReport_Click(object sender, EventArgs e)
        {

            DateTime date = dateTimePickerReport.Value;
            DateTime start = WcApi.Date.DateUtils.CropDate(date, day: 1);
            DateTime end = WcApi.Date.DateUtils.CropDate(date, day: DateTime.DaysInMonth(date.Year, date.Month));

            reportBindingSource.DataSource = null;
            labelCount.Text = "0";
            labelPay.Text = "0";

            using (WorldStatContext db = new WorldStatContext())
            {

                var reports = db.Reports.Where(r => r.Date >= start && r.Date <= end).ToList();

                labelCount.Text = reports.Sum(r => r.Count).ToString("### ###");
                labelPay.Text = reports.Sum(r => r.Pay).ToString("C");

                reportBindingSource.DataSource = reports;
            }
        }
    }
}
