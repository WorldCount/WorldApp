using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Wc32Api.Extensions.Bindings;
using WcApi.Keyboard;
using WcPostApi.Types;
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
        private List<ReportPos> _orgReportPoses;
        private List<ReportPos> _incomeReportPoses;
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

            SetDoubleBuffered();

            // Загрузка настроек
            LoadSettings();

            // Инизиализации таблиц
            InitTables();
        }

        #region Form Config

        // Загрузка настроек
        private void LoadSettings()
        {
            FillComboBoxes();
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

        #region Widgets Configs

        // Заполнение комбо-боксов
        private void FillComboBoxes()
        {
            reportComboBoxTeam.DataSource = Enum.GetValues(typeof(CalendarType));

            orgComboBoxTransType.DataSource = Enum.GetValues(typeof(TransType));
            orgComboBoxTransCategory.DataSource = Enum.GetValues(typeof(TransCategory));

            incomeComboBoxTransType.DataSource = Enum.GetValues(typeof(TransType));
            incomeComboBoxTransCategory.DataSource = Enum.GetValues(typeof(TransCategory));
        }

        // Установка буферизации
        private void SetDoubleBuffered()
        {
            #region Tables

            Wc32Api.DrawingControl.SetDoubleBuffered(reportDataGridView);
            Wc32Api.DrawingControl.SetDoubleBuffered(orgDataGridView);
            Wc32Api.DrawingControl.SetDoubleBuffered(incomeDataGridView);

            Wc32Api.DrawingControl.SetDoubleBuffered(incomePanel);

            #endregion
        }

        // Настройка таблиц
        private void InitTables()
        {
            #region Reports

            reportColumnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            reportColumnDate.Width = 140;

            reportColumnDayName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            reportColumnDayName.Width = 140;

            reportColumnType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            reportColumnType.Width = 100;

            reportColumnCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            reportColumnCount.Width = 200;

            #endregion

            #region Orgs

            // Таблица с организациями
            orgColumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            orgColumnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            orgColumnDate.Width = 140;

            orgColumnMailType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            orgColumnMailType.Width = 160;

            orgColumnMailCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            orgColumnMailCategory.Width = 130;

            orgColumnPay.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            orgColumnPay.Width = 120;

            orgColumnCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            orgColumnCount.Width = 120;

            orgColumnTransCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            orgColumnTransCategory.Width = 160;

            orgColumnTransType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            orgColumnTransType.Width = 120;

            #endregion

            #region Income

            // Таблица с доходами
            incomeColumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            incomeColumnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            incomeColumnDate.Width = 140;

            incomeColumnPay.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            incomeColumnPay.Width = 120;

            incomeColumnCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            incomeColumnCount.Width = 120;

            #endregion
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

        #region Buttons Clicks

        private void btnLoadReports_Click(object sender, EventArgs e)
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
            reportLabelCount.Text = "0";
            reportLabelPay.Text = "0";

            CalendarType type = (CalendarType)reportComboBoxTeam.SelectedItem;

            using (WorldStatContext db = new WorldStatContext())
            {
                List<Report> reports = type == CalendarType.Все ? db.Reports.Where(r => r.Date >= start && r.Date <= end).ToList() : db.Reports.Where(r => r.Date >= start && r.Date <= end && r.Type == type).ToList();

                string count = reports.Sum(r => r.Count).ToString("### ###");
                string sum = reports.Sum(r => r.Pay).ToString("C");

                reportLabelCount.Text = string.IsNullOrWhiteSpace(count) ? "0" : count;
                reportLabelPay.Text = sum;

                reportLabelDaysCount.Text = reports.Count.ToString();

                reportBindingSource.DataSource = reports.ToSortableBindingList();
            }
        }

        private async void btnLoadOrgs_Click(object sender, EventArgs e)
        {
            Firm firm = (Firm)orgComboBoxFirms.SelectedItem;
            MailType mailType = (MailType)orgComboBoxMailType.SelectedItem;
            MailCategory mailCategory = (MailCategory)orgComboBoxMailCategory.SelectedItem;
            TransCategory transCategory = (TransCategory)orgComboBoxTransCategory.SelectedItem;
            TransType transType = (TransType)orgComboBoxTransType.SelectedItem;

            long type = 9999;
            long category = 9999;

            orgLabelCount.Text = "0";
            orgLabelPay.Text = "0";
            orgLabelPosCount.Text = "0";

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

                if (orgToggleButtonGroup.Checked)
                    _orgReportPoses = await Db.LoadGroupReportPosesAsync(start, end, firm.Id, type, category, transCategory);
                else
                    _orgReportPoses = await Db.LoadReportPosesAsync(start, end, firm.Id, type, category, transType, transCategory);

                UpdateOrgReportPoses();

                string count = _orgReportPoses.Sum(r => r.Count).ToString("### ###");
                string sum = _orgReportPoses.Sum(r => r.Pay).ToString("C");

                orgLabelCount.Text = string.IsNullOrWhiteSpace(count) ? "0" : count;
                orgLabelPay.Text = sum;
                orgLabelPosCount.Text = _orgReportPoses.Count.ToString();
            }
        }

        private async void btnLoadIncomes_Click(object sender, EventArgs e)
        {
            Firm firm = (Firm)incomeComboBoxFirms.SelectedItem;
            MailType mailType = (MailType)incomeComboBoxMailType.SelectedItem;
            MailCategory mailCategory = (MailCategory)incomeComboBoxMailCategory.SelectedItem;
            TransCategory transCategory = (TransCategory)incomeComboBoxTransCategory.SelectedItem;

            long type = 9999;
            long category = 9999;

            incomeLabelCount.Text = "0";
            incomeLabelPay.Text = "0";
            incomeLabelPosCount.Text = "0";

            if (firm != null)
            {
                DateTime start;
                DateTime end;

                if (incomeDateTimePickerCalendar.Visible)
                {
                    DateTime date = incomeDateTimePickerCalendar.Value;
                    start = WcApi.Date.DateUtils.CropDate(date, day: 1);
                    end = WcApi.Date.DateUtils.CropDate(date, day: DateTime.DaysInMonth(date.Year, date.Month));
                }
                else
                {
                    start = WcApi.Date.DateUtils.CropTime(incomeDateTimePickerStart.Value);
                    end = WcApi.Date.DateUtils.CropTime(incomeDateTimePickerEnd.Value);
                }

                if (mailCategory != null)
                    category = mailCategory.Code;

                if (mailType != null)
                    type = mailType.Code;


                _incomeReportPoses = await Db.LoadGroupIncomeReportPosesAsync(start, end, firm.Id, type, category, transCategory, incomeToggleButtonGroup.Checked);
                UpdateIncomeReportPoses();

                string count = _incomeReportPoses.Sum(r => r.Count).ToString("### ###");
                string sum = _incomeReportPoses.Sum(r => r.Pay).ToString("C");

                incomeLabelCount.Text = string.IsNullOrWhiteSpace(count) ? "0" : count;
                incomeLabelPay.Text = sum;
                incomeLabelPosCount.Text = _incomeReportPoses.Count.ToString();
            }
        }

        #endregion

        #region DateTime Pickers Events

        private void reportDateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            reportDateTimePickerEnd.Value = reportDateTimePickerStart.Value;
        }

        private void orgDateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            orgDateTimePickerEnd.Value = orgDateTimePickerStart.Value;
        }

        private void incomeDateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            incomeDateTimePickerEnd.Value = incomeDateTimePickerStart.Value;
        }

        #endregion

        #region Toggle Buttons Events

        private void orgToggleButtonGroup_CheckedChanged(object sender, EventArgs e)
        {
            orgComboBoxTransType.Enabled = !orgComboBoxTransType.Enabled;
            orgColumnDate.Visible = !orgColumnDate.Visible;
            orgColumnTransType.Visible = !orgColumnTransType.Visible;
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

        private void incomeToggleButtonCalendar_CheckedChanged(object sender, EventArgs e)
        {
            if (incomeToggleButtonCalendar.Checked)
            {
                incomeDateTimePickerStart.Visible = false;
                incomeDateTimePickerEnd.Visible = false;
                incomeDateTimePickerCalendar.Visible = true;
            }
            else
            {
                incomeDateTimePickerStart.Visible = true;
                incomeDateTimePickerEnd.Visible = true;
                incomeDateTimePickerCalendar.Visible = false;
            }
        }

        private void incomeToggleButtonGroup_CheckedChanged(object sender, EventArgs e)
        {
            incomeColumnDate.Visible = !incomeColumnDate.Visible;
        }

        #endregion

        #region Others Events

        private void comboBoxFirms_Enter(object sender, EventArgs e)
        {
            Keyboard.SetRussianLanguage();
        }

        #endregion

        #region DataGrids Events

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var grid = (DataGridView)sender;
            var sortIconColor = Color.Gray;

            // Отрисовка флага сортировки
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                e.PaintBackground(e.CellBounds, false);
                TextRenderer.DrawText(e.Graphics, $"{e.FormattedValue}", e.CellStyle.Font, e.CellBounds, e.CellStyle.ForeColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);

                if (grid.SortedColumn?.Index == e.ColumnIndex)
                {
                    var sortIcon = grid.SortOrder == SortOrder.Ascending ? "▲" : "▼";
                    TextRenderer.DrawText(e.Graphics, sortIcon, e.CellStyle.Font, e.CellBounds, sortIconColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
                }

                e.Handled = true;
            }
        }

        #endregion

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
            orgAcitveMailTypeBindingSource.DataSource = null;
            orgAcitveMailTypeBindingSource.DataSource = _activeMailTypes;

            incomeAcitveMailTypeBindingSource.DataSource = null;
            incomeAcitveMailTypeBindingSource.DataSource = _activeMailTypes;
        }

        private void UpdateActiveMailCategories()
        {
            orgActiveMailCategoryBindingSource.DataSource = null;
            orgActiveMailCategoryBindingSource.DataSource = _activeMailCategories;

            incomeActiveMailCategoryBindingSource.DataSource = null;
            incomeActiveMailCategoryBindingSource.DataSource = _activeMailCategories;
        }

        private void UpdateFirms()
        {
            orgFirmBindingSource.DataSource = null;
            orgFirmBindingSource.DataSource = _firms;

            incomeFirmBindingSource.DataSource = null;
            incomeFirmBindingSource.DataSource = _firms;
        }

        private void UpdateOrgReportPoses()
        {
            orgReportPosBindingSource.DataSource = null;
            orgReportPosBindingSource.DataSource = _orgReportPoses.ToSortableBindingList();
        }

        private void UpdateIncomeReportPoses()
        {
            incomeReportPosBindingSource.DataSource = null;
            incomeReportPosBindingSource.DataSource = _incomeReportPoses.ToSortableBindingList();
        }


        #endregion

        #endregion

        private async void btnTest_Click(object sender, EventArgs e)
        {
            Firm firm = (Firm)orgComboBoxFirms.SelectedItem;
            MailType mailType = (MailType)orgComboBoxMailType.SelectedItem;
            MailCategory mailCategory = (MailCategory)orgComboBoxMailCategory.SelectedItem;
            TransCategory transCategory = (TransCategory)orgComboBoxTransCategory.SelectedItem;
            TransType transType = (TransType)orgComboBoxTransType.SelectedItem;

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

                _orgReportPoses = await Db.LoadGroupReportPosesAsync(start, end, firm.Id, type, category, transCategory);
                UpdateOrgReportPoses();

                orgLabelCount.Text = _orgReportPoses.Sum(r => r.Count).ToString();

                string count = _orgReportPoses.Sum(r => r.Count).ToString("### ###");
                string sum = _orgReportPoses.Sum(r => r.Pay).ToString("C");

                orgLabelCount.Text = string.IsNullOrWhiteSpace(count) ? "0" : count;
                orgLabelPay.Text = sum;
            }
        }
    }
}
