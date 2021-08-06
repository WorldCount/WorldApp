using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WorldStat.Core.Database;
using WorldStat.Core.Database.Contexts;
using WorldStat.Core.Database.Models;
using WorldStat.Core.Forms.DataForms;
using WorldStat.Core.Forms.TypeForms;
using WorldStat.Core.Storage;
using WorldStat.Core.Types;

namespace WorldStat.Core.Forms
{
    public partial class GeneralForm : Form
    {

        #region Private Field

        private string[] _reportsPaths;
        private List<Firm> _firms;
        private List<ReportPos> _reportPoses;
        private List<MailCategory> _mailCategories;
        private List<MailType> _mailTypes;
        private List<MailCategory> _activeMailCategories;
        private List<MailType> _activeMailTypes;

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

            Wc32Api.DrawingControl.SetDoubleBuffered(dataGridViewReport);
            Wc32Api.DrawingControl.SetDoubleBuffered(panelStat);

            // Загрузка настроек
            LoadSettings();

            //
            InitTable();
        }

        #region Form Config

        // Загрузка настроек
        private void LoadSettings()
        {
            comboBoxCalendar.DataSource = Enum.GetValues(typeof(CalendarType));
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
            {
                await Task.Run(() =>
                {
                    CreateDbForm createDbForm = new CreateDbForm();

                    Invoke(new Action(() => { createDbForm.ShowDialog(this); }));
                });
            }

            FirstQuery();

            await LoadDataAsync();
            UpdateData();

            _toggleButtonLocation = orgToggleButtonCalendar.Location;
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

        #region Table Config

        private void InitTable()
        {
            // Общая таблица
            reportDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            reportDateDataGridViewTextBoxColumn.Width = 140;

            reportDayNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            reportDayNameDataGridViewTextBoxColumn.Width = 140;

            reportTypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            reportTypeDataGridViewTextBoxColumn.Width = 100;

            reportCountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            reportCountDataGridViewTextBoxColumn.Width = 200;

            // Таблица с организациями
            firmNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            firmDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            firmDateDataGridViewTextBoxColumn.Width = 140;

            firmMailTypeDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            firmMailTypeDataGridViewCheckBoxColumn.Width = 160;

            firmMailCategoryDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            firmMailCategoryDataGridViewCheckBoxColumn.Width = 130;

            firmPayDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            firmPayDataGridViewTextBoxColumn.Width = 120;

            firmCountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            firmCountDataGridViewTextBoxColumn.Width = 100;

            firmTransCategoryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            firmTransCategoryDataGridViewTextBoxColumn.Width = 160;

            firmTransTypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            firmTransTypeDataGridViewTextBoxColumn.Width = 120;
        }

        #endregion

        #region Private Methods

        private async void FirstQuery()
        {
            await Task.Run(() => { 
                using (WorldStatContext db = new WorldStatContext())
                {
                    try
                    {
                        var entity = db.MailCodes.Last();
                    }
                    catch
                    {
                        //
                    }
                }
            });
        }

        #endregion

        #region Events

        private void btnLoadReport_Click(object sender, EventArgs e)
        {

            DateTime start;
            DateTime end;

            if (reportDateTimePickerCalendar.Visible)
            {
                DateTime date = reportDateTimePickerCalendar.Value;
                start = WcApi.Date.DateUtils.CropDate(date, day: 1);
                end = WcApi.Date.DateUtils.CropDate(date, day: DateTime.DaysInMonth(date.Year, date.Month));
            }
            else
            {
                start = WcApi.Date.DateUtils.CropTime(reportDateTimePickerStart.Value);
                end = WcApi.Date.DateUtils.CropTime(reportDateTimePickerEnd.Value);
            }

            reportBindingSource.DataSource = null;
            labelCount.Text = "0";
            labelPay.Text = "0";

            CalendarType type = (CalendarType)comboBoxCalendar.SelectedItem;

            using (WorldStatContext db = new WorldStatContext())
            {
                List<Report> reports;

                reports = type == CalendarType.Все ? db.Reports.Where(r => r.Date >= start && r.Date <= end).ToList() : db.Reports.Where(r => r.Date >= start && r.Date <= end && r.Type == type).ToList();

                string count = reports.Sum(r => r.Count).ToString("### ###");
                string sum = reports.Sum(r => r.Pay).ToString("C");

                labelCount.Text = string.IsNullOrWhiteSpace(count) ? "0" : count;
                labelPay.Text = sum;

                labelDaysCount.Text = reports.Count.ToString();

                reportBindingSource.DataSource = reports;
            }
        }

        private void orgDateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            orgDateTimePickerEnd.Value = orgDateTimePickerStart.Value;
        }

        private async void btnLoadReportFirms_Click(object sender, EventArgs e)
        {
            Firm firm = (Firm)comboBoxFirms.SelectedItem;
            MailType mailType = (MailType)comboBoxFirmsMailType.SelectedItem;
            MailCategory mailCategory = (MailCategory)comboBoxFirmsMailCategory.SelectedItem;

            long type = 9999;
            long category = 9999;

            if (firm != null)
            {
                DateTime start;
                DateTime end;

                if (orgDateTimePickerCalendar.Visible)
                {
                    DateTime date = orgDateTimePickerCalendar.Value;
                    start = WcApi.Date.DateUtils.CropDate(date, day: 1);
                    end = WcApi.Date.DateUtils.CropDate(date, day: DateTime.DaysInMonth(date.Year, date.Month));
                }
                else
                {
                    start = WcApi.Date.DateUtils.CropTime(orgDateTimePickerStart.Value);
                    end = WcApi.Date.DateUtils.CropTime(orgDateTimePickerEnd.Value);
                }

                if (mailCategory != null)
                    category = mailCategory.Code;

                if (mailType != null)
                    type = mailType.Code;

                _reportPoses = await Db.LoadReportPosesAsync(start, end, firm.Id, type, category);
                UpdateReportPoses();

                labelFirmCount.Text = _reportPoses.Sum(r => r.Count).ToString();

                string count = _reportPoses.Sum(r => r.Count).ToString("### ###");
                string sum = _reportPoses.Sum(r => r.Pay).ToString("C");

                labelFirmCount.Text = string.IsNullOrWhiteSpace(count) ? "0" : count;
                labelFirmPay.Text = sum;
            }
        }

        private void reportToggleButtonCalendar_CheckedChanged(object sender, EventArgs e)
        {
            if (reportToggleButton.Checked)
            {
                reportDateTimePickerStart.Visible = false;
                reportDateTimePickerEnd.Visible = false;
                reportDateTimePickerCalendar.Visible = true;
            }
            else
            {
                reportDateTimePickerStart.Visible = true;
                reportDateTimePickerEnd.Visible = true;
                reportDateTimePickerCalendar.Visible = false;
            }
        }

        private void orgToggleButtonCalendar_CheckedChanged(object sender, EventArgs e)
        {
            if (orgToggleButtonCalendar.Checked)
            {
                orgDateTimePickerStart.Visible = false;
                orgDateTimePickerEnd.Visible = false;
                orgDateTimePickerCalendar.Visible = true;
            }
            else
            {
                orgDateTimePickerStart.Visible = true;
                orgDateTimePickerEnd.Visible = true;
                orgDateTimePickerCalendar.Visible = false;
            }
        }

        private void comboBoxFirms_Enter(object sender, EventArgs e)
        {
            WcApi.Keyboard.Keyboard.SetRussianLanguage();
        }

        #endregion

        #region Menu Events

        private void loadFrankReportMenuItem_Click(object sender, EventArgs e)
        {

            string lastDir = Properties.Settings.Default.LastOpenDir;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true, Filter = @"Отчеты (*.xls)|*.xls|Все файлы (*.*)|*.*", RestoreDirectory = false
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

        private void importCalendarMenuItem_Click(object sender, EventArgs e)
        {
            string lastDir = Properties.Settings.Default.LastOpenDir;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = @"Экспорт календаря (*.json)|*.json|Все файлы (*.*)|*.*",
                RestoreDirectory = false
            };

            if (!string.IsNullOrEmpty(lastDir))
                openFileDialog.InitialDirectory = Directory.Exists(lastDir) ? lastDir : @"C:\";
            else
                openFileDialog.InitialDirectory = @"C:\";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string path = openFileDialog.FileName;

                if (!string.IsNullOrEmpty(path))
                {
                    string data = File.ReadAllText(Path.Combine(PathManager.DataDir, path));
                    List<Calendar> calendars = JsonConvert.DeserializeObject<List<Calendar>>(data);

                    LoadCalendarForm loadCalendarForm = new LoadCalendarForm(calendars);
                    loadCalendarForm.ShowDialog(this);

                    loadCalendarForm = null;
                }
            }

            openFileDialog = null;
        }

        private async void firmsMenuItem_Click(object sender, EventArgs e)
        {
            FirmsForm firmsForm = new FirmsForm();
            firmsForm.ShowDialog(this);

            _firms = await Db.LoadAllFirmsAsync();
            UpdateFirms();

            firmsForm = null;
        }

        private async void createDbMenuItem_Click(object sender, EventArgs e)
        {
            CreateDbForm createDbForm = new CreateDbForm();
            createDbForm.ShowDialog(this);

            await LoadDataAsync();
            UpdateData();

            createDbForm = null;
        }

        private async void mailCategoryMenuItem_Click(object sender, EventArgs e)
        {
            MailCategoryForm mailCategoryForm = new MailCategoryForm();
            mailCategoryForm.ShowDialog(this);

            _activeMailCategories = await Db.LoadActiveMailCategoriesAsync();
            UpdateActiveMailCategories();

            mailCategoryForm = null;
        }

        private async void mailTypeMenuItem_Click(object sender, EventArgs e)
        {
            MailTypeForm mailTypeForm = new MailTypeForm();
            mailTypeForm.ShowDialog(this);

            _activeMailTypes = await Db.LoadActiveMailTypesAsync();
            UpdateActiveMailTypes();

            mailTypeForm = null;
        }

        private void mailCodeMenuItem_Click(object sender, EventArgs e)
        {
            MailCodeForm mailCodeForm = new MailCodeForm();
            mailCodeForm.ShowDialog(this);

            mailCodeForm = null;
        }

        #endregion

        #region Private Methods

        private void ParseReports()
        {
            LoadReportForm loadReportForm = new LoadReportForm(_reportsPaths);
            loadReportForm.ShowDialog(this);

            loadReportForm = null;
        }

        #endregion

        #region Datas

        #region Load Datas

        private async Task LoadDataAsync()
        {
            _activeMailTypes = await Db.LoadActiveMailTypesAsync();
            _activeMailCategories = await Db.LoadActiveMailCategoriesAsync();
            _mailTypes = await Db.LoadAllMailTypesAsync();
            _mailCategories = await Db.LoadAllMailCategoriesAsync();
            _firms = await Db.LoadAllFirmsAsync();
        }
        #endregion

        #region Update Datas

        private void UpdateData()
        {
            UpdateFirms();
            UpdateMailCategories();
            UpdateMailTypes();
            UpdateActiveMailCategories();
            UpdateActiveMailTypes();
        }

        private void UpdateMailTypes()
        {
            mailTypeBindingSource.DataSource = null;
            mailTypeBindingSource.DataSource = _mailTypes;
        }

        private void UpdateMailCategories()
        {
            mailCategoryBindingSource.DataSource = null;
            mailCategoryBindingSource.DataSource = _mailCategories;
        }

        private void UpdateActiveMailTypes()
        {
            acitveMailTypeBindingSource.DataSource = null;
            acitveMailTypeBindingSource.DataSource = _activeMailTypes;
        }

        private void UpdateActiveMailCategories()
        {
            activeMailCategoryBindingSource.DataSource = null;
            activeMailCategoryBindingSource.DataSource = _activeMailCategories;
        }

        private void UpdateFirms()
        {
            firmBindingSource.DataSource = null;
            firmBindingSource.DataSource = _firms;
        }

        private void UpdateReportPoses()
        {
            reportPosBindingSource.DataSource = null;
            reportPosBindingSource.DataSource = _reportPoses;
        }

        #endregion

        #endregion

        
    }
}
