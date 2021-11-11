using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using Newtonsoft.Json;
using Wc32Api.Extensions.Bindings;
using Wc32Api.Messages;
using WcApi.Keyboard;
using WcPostApi.Types;
using WorldStat.Core.Database;
using WorldStat.Core.Database.Contexts;
using WorldStat.Core.Database.Models;
using WorldStat.Core.Forms.DataForms;
using WorldStat.Core.Forms.TypeForms;
using WorldStat.Core.Libs;
using WorldStat.Core.PrintDocuments;
using WorldStat.Core.Reports.Models;
using WorldStat.Core.Storage;
using WorldStat.Core.Types;

namespace WorldStat.Core.Forms
{
    public partial class GeneralForm : Form
    {

        #region Private Field

        private string _yaToken;
        private string _yaReportFmDir;
        private string _yaReportOrigDir ;

        private string[] _reportsPaths;
        private List<Firm> _firms;
        private List<ReportPos> _orgReportPoses;
        private List<ReportPos> _incomeReportPoses;
        private List<MailCategory> _mailCategories;
        private List<MailType> _mailTypes;
        private List<MailCategory> _activeMailCategories;
        private List<MailType> _activeMailTypes;
        private List<DispathReport> _dispathReports;
        private readonly StatusMessage _statusMessage;

        private string _printerName;

        private bool _isAdmin = false;

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

            _statusMessage = new StatusMessage(statusText);

            SetDoubleBuffered();

            // Загрузка настроек
            LoadSettings();

            // Инизиализации таблиц
            InitTables();

            AutoUpdater.Proxy = null;
            AutoUpdater.ParseUpdateInfoEvent += AutoUpdater_ParseUpdateInfoEvent;

            tabsControl.TabPages.Remove(tabCharts);
            importCalendarMenuItem.Enabled = _isAdmin;
        }

        #region Form Config

        // Загрузка настроек
        private void LoadSettings()
        {
            FillComboBoxes();
            reportTextBoxUnloadDir.Text = Properties.Settings.Default.UnloadReportsDir;
            _yaToken = Properties.Settings.Default.YaToken;

            _printerName = Properties.Settings.Default.LastPrinterName;

            SetPrinterSettings();
        }

        // Сохранение настроек
        private void SaveSettings()
        {
            string printerName = comboBoxPrinters.SelectedText;

            if (!string.IsNullOrEmpty(printerName))
                Properties.Settings.Default.LastPrinterName = printerName;

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

            if (args.Contains("-admin"))
                _isAdmin = true;
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

            Wc32Api.DrawingControl.SetDoubleBuffered(orgComboBoxFirms);
            Wc32Api.DrawingControl.SetDoubleBuffered(statComboBoxFirms);
            Wc32Api.DrawingControl.SetDoubleBuffered(incomeComboBoxFirms);

            Wc32Api.DrawingControl.SetDoubleBuffered(reportDataGridView);
            Wc32Api.DrawingControl.SetDoubleBuffered(orgDataGridView);
            Wc32Api.DrawingControl.SetDoubleBuffered(incomeDataGridView);
            Wc32Api.DrawingControl.SetDoubleBuffered(statDataGridView);

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

            #region Stat

            // Таблица со статистикой

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
                        // ReSharper disable once AssignmentIsFullyDiscarded
                        _ = db.MailCodes.Last();
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

        #region Buttons Events

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
            TransType transType = (TransType) incomeComboBoxTransType.SelectedItem;

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


                _incomeReportPoses = await Db.LoadGroupIncomeReportPosesAsync(start, end, firm.Id, type, category, transCategory, transType, incomeToggleButtonGroup.Checked);
                UpdateIncomeReportPoses();

                string count = _incomeReportPoses.Sum(r => r.Count).ToString("### ###");
                string sum = _incomeReportPoses.Sum(r => r.Pay).ToString("C");

                incomeLabelCount.Text = string.IsNullOrWhiteSpace(count) ? "0" : count;
                incomeLabelPay.Text = sum;
                incomeLabelPosCount.Text = _incomeReportPoses.Count.ToString();
            }
        }

        private async void btnLoadStat_Click(object sender, EventArgs e)
        {
            Firm firm = (Firm)statComboBoxFirms.SelectedItem;
            if (firm != null)
            {
                DateTime start;
                DateTime end;

                if (statDateTimePickerCalendar.Visible)
                {
                    DateTime date = statDateTimePickerCalendar.Value;
                    start = WcApi.Date.DateUtils.CropDate(date, day: 1);
                    end = WcApi.Date.DateUtils.CropDate(date, day: DateTime.DaysInMonth(date.Year, date.Month));
                }
                else
                {
                    start = WcApi.Date.DateUtils.CropTime(statDateTimePickerStart.Value);
                    end = WcApi.Date.DateUtils.CropTime(statDateTimePickerEnd.Value);
                }

                List<ReportPos> reportPoses = await Db.LoadDispathReportPosesAsync(start, end, firm.Id);
                DispathReportRepository repository = new DispathReportRepository(reportPoses);
                _dispathReports = repository.ToDispathReports();

                UpdateDispathReports();
            }
        }

        private void btnOpenUnloadDir_Click(object sender, EventArgs e)
        {
            string dir = reportTextBoxUnloadDir.Text;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(dir))
                folderBrowserDialog.SelectedPath = dir;

            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                Properties.Settings.Default.UnloadReportsDir = folderBrowserDialog.SelectedPath;
                reportTextBoxUnloadDir.Text = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            TabPage selectPage = tabsControl.SelectedTab;

            if (selectPage == tabReports)
                PrintReports();
            else if (selectPage == tabOrgs)
                PrintOrgs();
            else if (selectPage == tabIncomes)
                PrintIncomes();
            else if (selectPage == tabStats)
                PrintStats();
            else
            {
                selectPage = null;
                return;
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

        private void statDateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            statDateTimePickerEnd.Value = statDateTimePickerStart.Value;
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

        private void statToggleButtonCalendar_CheckedChanged(object sender, EventArgs e)
        {
            if (statToggleButtonCalendar.Checked)
            {
                statDateTimePickerStart.Visible = false;
                statDateTimePickerEnd.Visible = false;
                statDateTimePickerCalendar.Visible = true;
            }
            else
            {
                statDateTimePickerStart.Visible = true;
                statDateTimePickerEnd.Visible = true;
                statDateTimePickerCalendar.Visible = false;
            }
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
        private void statDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                DispathReport report = ((List<DispathReport>)dispathReportBindingSource.DataSource)[e.RowIndex];
                if (report != null)
                {
                    if (report.IsHeader)
                    {
                        statDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DimGray;
                        statDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (report.IsSubheader)
                    {
                        statDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                        statDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void reportDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = reportDataGridView.HitTest(e.X, e.Y).RowIndex;
                int currentMouseOverCol = reportDataGridView.HitTest(e.X, e.Y).ColumnIndex;

                if (currentMouseOverRow >= 0 && currentMouseOverCol >= 0)
                {
                    reportDataGridView.ClearSelection();
                    reportDataGridView.Rows[currentMouseOverRow].Cells[currentMouseOverCol].Selected = true;

                    Report report = GetReportByRowIndex(currentMouseOverRow);

                    if (report != null)
                    {
                        reportContextMenuUnload.Text = $"Выгрузить отчет за '{report.Date.ToShortDateString()}'";
                        reportContextMenuUnload.Enabled = true;
                        reportContextMenuUnload.Tag = report;

                        reportContextMenuUploadYandexDisk.Text = $"Выгрузить отчет за '{report.Date.ToShortDateString()}' на Яндекс";
                        reportContextMenuUploadYandexDisk.Enabled = _isAdmin;
                        reportContextMenuUploadYandexDisk.Tag = report;
                    }
                    else
                    {
                        reportContextMenuUnload.Text = "Выгрузить отчет";
                        reportContextMenuUnload.Enabled = false;
                        reportContextMenuUnload.Tag = null;

                        reportContextMenuUploadYandexDisk.Text = "Выгрузить отчет на Яндекс";
                        reportContextMenuUploadYandexDisk.Enabled = false;
                        reportContextMenuUploadYandexDisk.Tag = null;
                    }

                    reportContextMenu.Show(reportDataGridView, new Point(e.X, e.Y));
                }
            }
        }

        #endregion

        #region Menu Events

        private void loadFrankReportMenuItem_Click(object sender, EventArgs e)
        {

            string lastDir = Properties.Settings.Default.LastOpenDir;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = @"Отчеты (*.xls)|*.xls|Все файлы (*.*)|*.*",
                RestoreDirectory = false
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
                }
            }
        }

        private async void firmsMenuItem_Click(object sender, EventArgs e)
        {
            FirmsForm firmsForm = new FirmsForm();
            firmsForm.ShowDialog(this);

            _firms = await Db.LoadAllFirmsAsync();
            UpdateFirms();
        }

        private async void createDbMenuItem_Click(object sender, EventArgs e)
        {
            CreateDbForm createDbForm = new CreateDbForm();
            createDbForm.ShowDialog(this);

            await LoadDataAsync();
            UpdateData();
        }

        private async void mailCategoryMenuItem_Click(object sender, EventArgs e)
        {
            MailCategoryForm mailCategoryForm = new MailCategoryForm();
            mailCategoryForm.ShowDialog(this);

            _activeMailCategories = await Db.LoadActiveMailCategoriesAsync();
            UpdateActiveMailCategories();
        }

        private async void mailTypeMenuItem_Click(object sender, EventArgs e)
        {
            MailTypeForm mailTypeForm = new MailTypeForm();
            mailTypeForm.ShowDialog(this);

            _activeMailTypes = await Db.LoadActiveMailTypesAsync();
            UpdateActiveMailTypes();
        }

        private void mailCodeMenuItem_Click(object sender, EventArgs e)
        {
            MailCodeForm mailCodeForm = new MailCodeForm();
            mailCodeForm.ShowDialog(this);
        }

        private void updateMenuItem_Click(object sender, EventArgs e)
        {
            AutoUpdater.ShowRemindLaterButton = false;
            AutoUpdater.ReportErrors = true;
            AutoUpdater.Start("https://worldcount.ru/updates/repo/WorldStat/update.json");
        }

        #endregion

        #region Context Menu Events

        private async void reportContextMenuUnload_Click(object sender, EventArgs e)
        {
            Report report = (Report)reportContextMenuUnload.Tag;
            if (report != null)
            {
                List<ReportPos> reportPoses = await Db.GetReportPosesByReportIdAsync(report.Id);
                DispathReportRepository repository = new DispathReportRepository(reportPoses);

                await Task.Run(() =>
                {
                    repository.SaveToFile(Path.Combine(reportTextBoxUnloadDir.Text, $"{report.Date.ToShortDateString()}.txt"), report.Date.ToShortDateString());
                });

                _statusMessage.SuccessMessage("Готово!");
            }

            reportContextMenuUnload.Tag = null;
        }

        private async void reportContextMenuUnloadAll_Click(object sender, EventArgs e)
        {
            try
            {
                List<Report> reports = ((SortableBindingList<Report>)reportBindingSource.DataSource).ToList();

                foreach (Report report in reports)
                {
                    List<ReportPos> reportPoses = await Db.GetReportPosesByReportIdAsync(report.Id);
                    DispathReportRepository repository = new DispathReportRepository(reportPoses);

                    await Task.Run(() =>
                    {
                        repository.SaveToFile(Path.Combine(reportTextBoxUnloadDir.Text, $"{report.Date.ToShortDateString()}.txt"), report.Date.ToShortDateString());
                    });
                }

                _statusMessage.SuccessMessage("Готово!");
            }
            catch
            {
                //
            }
        }

        private async void reportContextMenuUploadYandexDisk_Click(object sender, EventArgs e)
        {
            Report report = (Report)reportContextMenuUploadYandexDisk.Tag;

            if (report != null)
            {
                List<ReportPos> reportPoses = await Db.GetReportPosesByReportIdAsync(report.Id);
                DispathReportRepository repository = new DispathReportRepository(reportPoses);

                string tempReportPath = Path.Combine(PathManager.TempReportsDir, $"{report.Date.ToShortDateString()}.txt");
                string reserveReportPath = Path.Combine(PathManager.ReserveReportsDir, $"{report.Date:MM}.{report.Date:yyyy}", $"{report.Date.ToShortDateString()}.xls");

                string reportDir = $"{WcApi.Date.DateUtils.GetMonthName(report.Date)} {report.Date.Year}";

                YaDiskClient client = new YaDiskClient(_yaToken);

                if (string.IsNullOrEmpty(_yaReportFmDir))
                    _yaReportFmDir = await client.CreateReportDir(reportDir, "ОТЧЕТ ПО ФМ");

                if (string.IsNullOrEmpty(_yaReportOrigDir))
                    _yaReportOrigDir = await client.CreateReportDir(reportDir, "ОРИГИНАЛ");

                await Task.Run(() =>
                {
                    repository.SaveToFile(tempReportPath, report.Date.ToShortDateString());
                });

                if (await client.UploadFile(tempReportPath, $"{_yaReportFmDir}/{report.Date.ToShortDateString()}.txt"))
                    _statusMessage.SuccessMessage("Выгрузка отчета завершена!");

                if (File.Exists(reserveReportPath))
                    if (await client.UploadFile(reserveReportPath, $"{_yaReportOrigDir}/{report.Date.ToShortDateString()}.xls"))
                        _statusMessage.SuccessMessage("Выгрузка оригинального отчета завершена!");
            }

            reportContextMenuUploadYandexDisk.Tag = null;
        }

        #endregion

        #region Updater

        private void AutoUpdater_ParseUpdateInfoEvent(ParseUpdateInfoEventArgs args)
        {
            dynamic json = JsonConvert.DeserializeObject(args.RemoteData);
            args.UpdateInfo = new UpdateInfoEventArgs
            {
                CurrentVersion = json.version,
                ChangelogURL = json.changelog,
                DownloadURL = json.url,
                Mandatory = new Mandatory
                {
                    Value = json.mandatory.value
                },
                CheckSum = new CheckSum
                {
                    Value = json.checksum.value,
                    HashingAlgorithm = json.checksum.hashingAlgorithm
                }
            };
        }

        #endregion

        #endregion

        #region Private Methods

        private void SetPrinterSettings()
        {
            PrinterSettings.StringCollection printers = PrinterSettings.InstalledPrinters;
            PrinterSettings printerSettings = new PrinterSettings();

            if (string.IsNullOrEmpty(_printerName))
                _printerName = printerSettings.PrinterName;

            foreach (string printer in printers)
                comboBoxPrinters.Items.Add(printer);

            if (!string.IsNullOrEmpty(_printerName) || comboBoxPrinters.FindString(_printerName) > -1)
                printerSettings.PrinterName = _printerName;

            int index = comboBoxPrinters.FindString(printerSettings.PrinterName);
            if (index != -1)
                comboBoxPrinters.SelectedIndex = index;
        }

        private void ParseReports()
        {
            LoadReportForm loadReportForm = new LoadReportForm(_reportsPaths);
            loadReportForm.ShowDialog(this);
        }

        private Report GetReportByRowIndex(int rowIndex)
        {
            try
            {
                List<Report> reports = ((SortableBindingList<Report>)reportBindingSource.DataSource).ToList();

                if (reports.Count > 0)
                {
                    return reports[rowIndex];
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        #region Prints

        private void PrintReports()
        {
            btnPrint.Enabled = false;
            CalendarType type = (CalendarType)reportComboBoxTeam.SelectedItem;

            string dateString = "";

            if (reportDateTimePickerCalendar.Visible)
            {
                dateString = WcApi.Date.DateUtils.GetMonthName(reportDateTimePickerCalendar.Value);
            }
            else
            {
                DateTime start = WcApi.Date.DateUtils.CropTime(reportDateTimePickerStart.Value);
                DateTime end = WcApi.Date.DateUtils.CropTime(reportDateTimePickerEnd.Value);
                dateString = start == end ? $"{start:dd.MM.yyyy}" : $"{start:dd.MM.yyyy} - {end:dd.MM.yyyy}";
            }

            List<Report> reports = new List<Report>();

            try
            {
                reports = ((SortableBindingList<Report>)reportBindingSource.DataSource).ToList();
            }
            catch
            {
                btnPrint.Enabled = true;
                _statusMessage.ErrorMessage("Нет данных для печати");
                return;
            }

            string printerName = (string)comboBoxPrinters.SelectedItem;

            string reportTitle = "ОБЩИЙ ОТЧЕТ";
            string reportSubTitle = $"Период: {dateString}, Смена: {type}";

            string count = reports.Sum(r => r.Count).ToString("### ###");
            string sum = reports.Sum(r => r.Pay).ToString("N2");

            ReportPrintDocument document = new ReportPrintDocument(reports, count, sum, reportLabelDaysCount.Text)
            {
                PrintLogo = true,
                PrintNumPageInfo = true,
                ReportTitle = reportTitle,
                ReportSubTitle = reportSubTitle,
                PrinterSettings = { Copies = (short)numericUpDownCopies.Value }
            };

            if (!string.IsNullOrEmpty(printerName))
                document.PrinterSettings.PrinterName = printerName;

            document.Print();
            numericUpDownCopies.Value = 1;
            btnPrint.Enabled = true;
            _statusMessage.SuccessMessage("Отчет ушел на печать");
        }

        private void PrintOrgs()
        {
            btnPrint.Enabled = false;

            Firm firm = (Firm)orgComboBoxFirms.SelectedItem;
            MailType mailType = (MailType)orgComboBoxMailType.SelectedItem;
            MailCategory mailCategory = (MailCategory)orgComboBoxMailCategory.SelectedItem;
            TransCategory transCategory = (TransCategory)orgComboBoxTransCategory.SelectedItem;
            TransType transType = (TransType)orgComboBoxTransType.SelectedItem;


            if (firm == null || mailType == null || mailCategory == null)
            {
                btnPrint.Enabled = true;
                _statusMessage.ErrorMessage("Загруженны не полные данные.");
                return;
            }

            List<ReportPos> reports = new List<ReportPos>();

            try
            {
                reports = ((SortableBindingList<ReportPos>)orgReportPosBindingSource.DataSource).ToList();
            }
            catch
            {
                btnPrint.Enabled = true;
                _statusMessage.ErrorMessage("Нет данных для печати");
                return;
            }

            string dateString = "";

            if (orgDateTimePickerCalendar.Visible)
            {
                dateString = WcApi.Date.DateUtils.GetMonthName(orgDateTimePickerCalendar.Value);
            }
            else
            {
                DateTime start = WcApi.Date.DateUtils.CropTime(orgDateTimePickerStart.Value);
                DateTime end = WcApi.Date.DateUtils.CropTime(orgDateTimePickerEnd.Value);
                dateString = start == end ? $"{start:dd.MM.yyyy}" : $"{start:dd.MM.yyyy} - {end:dd.MM.yyyy}";
            }

            string reportTitle = $"ОТЧЕТ ПО ОРГАНИЗАЦИИ: {firm.ShortName}";
            if (orgToggleButtonGroup.Checked)
                reportTitle = $"ГРУППИРОВАННЫЙ ОТЧЕТ ПО ОРГАНИЗАЦИИ: {firm.ShortName}";

            string reportSubTitle = $"Период: {dateString}, Тип: {mailType.ShortName}, " +
                                    $"Категория: {mailCategory.ShortName}, Класс: {transCategory}, Пересылка: {transType}";

            string printerName = (string)comboBoxPrinters.SelectedItem;

            string count = reports.Sum(r => r.Count).ToString("### ###");
            string sum = reports.Sum(r => r.Pay).ToString("N2");

            OrgPrintDocument document = new OrgPrintDocument(reports, count, sum,
                orgLabelPosCount.Text, orgToggleButtonGroup.Checked, _mailCategories, _mailTypes)
            {
                PrintLogo = true,
                PrintNumPageInfo = true,
                ReportTitle = reportTitle,
                ReportSubTitle = reportSubTitle,
                PrinterSettings = { Copies = (short)numericUpDownCopies.Value }
            };

            if (!string.IsNullOrEmpty(printerName))
                document.PrinterSettings.PrinterName = printerName;

            document.Print();
            numericUpDownCopies.Value = 1;
            btnPrint.Enabled = true;
            _statusMessage.SuccessMessage("Отчет ушел на печать");
        }

        private void PrintIncomes()
        {
            btnPrint.Enabled = false;

            Firm firm = (Firm)incomeComboBoxFirms.SelectedItem;
            MailType mailType = (MailType)incomeComboBoxMailType.SelectedItem;
            MailCategory mailCategory = (MailCategory)incomeComboBoxMailCategory.SelectedItem;
            TransCategory transCategory = (TransCategory)incomeComboBoxTransCategory.SelectedItem;
            TransType transType = (TransType)incomeComboBoxTransType.SelectedItem;

            if (firm == null || mailType == null || mailCategory == null)
            {
                btnPrint.Enabled = true;
                _statusMessage.ErrorMessage("Загруженны не полные данные.");
                return;
            }

            List<ReportPos> reports = new List<ReportPos>();

            try
            {
                reports = ((SortableBindingList<ReportPos>)incomeReportPosBindingSource.DataSource).ToList();
            }
            catch
            {
                btnPrint.Enabled = true;
                _statusMessage.ErrorMessage("Нет данных для печати");
                return;
            }

            string dateString = "";

            if (incomeDateTimePickerCalendar.Visible)
            {
                dateString = WcApi.Date.DateUtils.GetMonthName(incomeDateTimePickerCalendar.Value);
            }
            else
            {
                DateTime start = WcApi.Date.DateUtils.CropTime(incomeDateTimePickerStart.Value);
                DateTime end = WcApi.Date.DateUtils.CropTime(incomeDateTimePickerEnd.Value);
                dateString = start == end ? $"{start:dd.MM.yyyy}" : $"{start:dd.MM.yyyy} - {end:dd.MM.yyyy}";
            }

            string reportTitle = $"ОТЧЕТ ПО ДОХОДУ: {firm.ShortName}";
            if (orgToggleButtonGroup.Checked)
                reportTitle = $"ГРУППИРОВАННЫЙ ОТЧЕТ ПО ДОХОДУ: {firm.ShortName}";

            string reportSubTitle = $"Период: {dateString}, Тип: {mailType.ShortName}, " +
                                    $"Категория: {mailCategory.ShortName}, Класс: {transCategory}, Пересылка: {transType}";

            string printerName = (string)comboBoxPrinters.SelectedItem;

            string count = reports.Sum(r => r.Count).ToString("### ###");
            string sum = reports.Sum(r => r.Pay).ToString("N2");

            IncomePrintDocument document = new IncomePrintDocument(reports, count, sum, incomeLabelPosCount.Text,
                incomeToggleButtonGroup.Checked)
            {
                PrintLogo = true,
                PrintNumPageInfo = true,
                ReportTitle = reportTitle,
                ReportSubTitle = reportSubTitle,
                PrinterSettings = { Copies = (short)numericUpDownCopies.Value }
            };

            if (!string.IsNullOrEmpty(printerName))
                document.PrinterSettings.PrinterName = printerName;

            document.Print();
            numericUpDownCopies.Value = 1;
            btnPrint.Enabled = true;
            _statusMessage.SuccessMessage("Отчет ушел на печать");
        }

        private void PrintStats()
        {
            btnPrint.Enabled = false;

            Firm firm = (Firm)statComboBoxFirms.SelectedItem;
            if (firm == null)
            {
                btnPrint.Enabled = true;
                _statusMessage.ErrorMessage("Загруженны не полные данные.");
                return;
            }

            string dateString = "";

            if (statDateTimePickerCalendar.Visible)
            {
                dateString = WcApi.Date.DateUtils.GetMonthName(statDateTimePickerCalendar.Value);
            }
            else
            {
                DateTime start = WcApi.Date.DateUtils.CropTime(statDateTimePickerStart.Value);
                DateTime end = WcApi.Date.DateUtils.CropTime(statDateTimePickerEnd.Value);
                dateString = start == end ? $"{start:dd.MM.yyyy}" : $"{start:dd.MM.yyyy} - {end:dd.MM.yyyy}";
            }

            string reportTitle = $"СТАТИСТИКА: {firm.ShortName}";
            string reportSubTitle = $"Период: {dateString}";
            string printerName = (string)comboBoxPrinters.SelectedItem;

            if (statDataGridView.RowCount == 0)
            {
                btnPrint.Enabled = true;
                _statusMessage.ErrorMessage("Нет данных для печати");
                return;
            }


            StatPrintDocument document = new StatPrintDocument(statDataGridView)
            {
                PrintLogo = true,
                PrintNumPageInfo = true,
                ReportTitle = reportTitle,
                ReportSubTitle = reportSubTitle,
                PrinterSettings = { Copies = (short)numericUpDownCopies.Value }
            };

            if (!string.IsNullOrEmpty(printerName))
                document.PrinterSettings.PrinterName = printerName;

            document.Print();
            numericUpDownCopies.Value = 1;
            _statusMessage.SuccessMessage("Отчет ушел на печать");

            btnPrint.Enabled = true;
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

            statFirmBindingSource.DataSource = null;
            statFirmBindingSource.DataSource = _firms;
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

        private void UpdateDispathReports()
        {
            dispathReportBindingSource.DataSource = null;
            dispathReportBindingSource.DataSource = _dispathReports;
        }


        #endregion

        #endregion

        #endregion

    }
}
