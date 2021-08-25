using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NLog;
using WcPostApi.Barcodes;
using WhoseIsBarcode.Core.Database;
using WhoseIsBarcode.Core.Database.Models;
using WhoseIsBarcode.Core.Database.Requests;
using WhoseIsBarcode.Core.Filters;
using WhoseIsBarcode.Core.Forms;

namespace WhoseIsBarcode.Core.Forms
{
    public partial class GeneralForm : Form
    {

        #region Private Fields

        private DataBase _dataBase;
        private bool _debugMode;

        private List<DbBarcode> _barcodes;
        private List<DbRange> _ranges;

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private DbBarcode _selectBarcode;
        private DbRange _selectRange;

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

            // Настройка таблиц
            InitTables();
        }

        #region Form Config

        // Загрузка настроек
        private void LoadSettings()
        {
            _debugMode = Properties.Settings.Default.DebugMode;
            btnDebug.Checked = Properties.Settings.Default.DebugMode;
            _dataBase = new DataBase(Connect.GetConnect(), _debugMode);

            int lastTabsIndex = Properties.Settings.Default.LastTabIndex;
            tabControl.SelectedIndex = lastTabsIndex >= tabControl.TabCount ? 0 : Properties.Settings.Default.LastTabIndex;
        }

        private void InitTables()
        {
            Wc32Api.DrawingControl.SetDoubleBuffered(barcodeDataGridView);
            Wc32Api.DrawingControl.SetDoubleBuffered(rangeDataGridView);

            // Таблица со ШПИ
            barcodeColumnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnDate.Width = 140;

            barcodeColumnBarcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnBarcode.Width = 160;

            barcodeColumnOps.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnOps.Width = 80;

            barcodeColumnMonth.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnMonth.Width = 60;

            barcodeColumnNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnNum.Width = 90;

            barcodeColumnSeria.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnSeria.Width = 60;

            barcodeColumnState.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnState.Width = 140;

            barcodeColumnFirmName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Таблица с диапазонами
            rangeColumnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnDate.Width = 140;

            rangeColumnExternal.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnExternal.Width = 60;

            rangeColumnOps.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnOps.Width = 80;

            rangeColumnMonth.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnMonth.Width = 60;

            rangeColumnSeria.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnSeria.Width = 60;

            rangeColumnFirstNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnFirstNum.Width = 90;

            rangeColumnLastNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnLastNum.Width = 90;

            rangeColumnCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnCount.Width = 70;

            rangeColumnFreeCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnFreeCount.Width = 70;

            rangeColumnBusyCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnBusyCount.Width = 70;

            rangeColumnFirmName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // Сохранение настроек
        private void SaveSettings()
        {
            Properties.Settings.Default.LastTabIndex = tabControl.SelectedIndex;
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
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {

            LoadPos();

            // Чтение аргументов
            CheckArgs();

            TestDbConnection();

            FillTypeBox();

            LoadFirms();
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

        #region Menu Events

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void connectItem_Click(object sender, EventArgs e)
        {
            ConnectForm connectForm = new ConnectForm();
            if (connectForm.ShowDialog(this) == DialogResult.OK)
            {
                _dataBase = new DataBase(Connect.GetConnect(), _debugMode);
            }
        }

        #endregion

        #region TextBox Events

        private void barcodeTextBoxBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindBarcode();
                barcodeTextBoxBarcode.SelectAll();
            }
        }

        private void barcodeTextBoxBarcode_Enter(object sender, EventArgs e)
        {
            WcApi.Keyboard.Keyboard.SetEnglishLanguage();
        }

        private void tbFilter__TextChanged(object sender, EventArgs e)
        {
            string q = tbFilter.Text.ToUpper();

            if (tabControl.SelectedTab == tabBarcodes)
            {
                if (!string.IsNullOrEmpty(q) && _barcodes != null)
                {
                    List<DbBarcode> filtered = _barcodes.Where(f => f.Barcode.Contains(q) 
                                                                    || f.State.ToUpper().Contains(q)).ToList();
                    dbBarcodeBindingSource.DataSource = filtered;
                    UpdateBarcodesInfo(filtered);
                }
                else
                {
                    dbBarcodeBindingSource.DataSource = _barcodes;
                    UpdateBarcodesInfo(_barcodes);
                }
            }

            if (tabControl.SelectedTab == tabRanges)
            {
                if (!string.IsNullOrEmpty(q) && _ranges != null)
                {
                    List<DbRange> filtered = _ranges.Where(f => f.ExtName.ToUpper().Contains(q) 
                                                                || f.Ops.Contains(q) || f.MonthName.Contains(q) 
                                                                || f.SeriaName.Contains(q) || f.FirstNum.Contains(q) 
                                                                || f.LastNum.Contains(q) || f.FirmName.Contains(q)).ToList();
                    dbRangeBindingSource.DataSource = filtered;
                    UpdateRangesInfo(filtered);
                }
                else
                {
                    dbRangeBindingSource.DataSource = _ranges;
                    UpdateRangesInfo(_ranges);
                }
            }
        }

        private void tbFilter_Enter(object sender, EventArgs e)
        {
            WcApi.Keyboard.Keyboard.SetRussianLanguage();
        }

        #endregion

        #region Buttons Event

        private void btnDebug_CheckedChanged(object sender, EventArgs e)
        {
            _debugMode = btnDebug.Checked;
            Properties.Settings.Default.DebugMode = _debugMode;
            _dataBase = new DataBase(Connect.GetConnect(), _debugMode);
            Properties.Settings.Default.Save();
        }

        private void btnLoadBarcode_Click(object sender, EventArgs e)
        {
           FindBarcode();
           barcodeTextBoxBarcode.Focus();
           barcodeTextBoxBarcode.SelectAll();
        }

        private void btnLoadRange_Click(object sender, EventArgs e)
        {
            DbFirm firm = (DbFirm) rangeComboBoxFirm.SelectedItem;
            if (firm != null)
            {
                RangeRequest request = new RangeRequest { Firm = firm };

                if (rangeToggleLimit.Checked)
                    request.Limit = (int) rangeLimitNum.Value;

                ExternalType type = (ExternalType) rangeComboBoxType.SelectedItem;
                if (type != null)
                    request.External = type.Value;

                if (rangeToggleCalendar.Checked)
                {
                    DateTime start;
                    DateTime end;

                    if (rangeDateTimePickerCalendar.Visible)
                    {
                        DateTime date = rangeDateTimePickerCalendar.Value;
                        start = WcApi.Date.DateUtils.CropDate(date, day: 1);
                        end = WcApi.Date.DateUtils.CropDate(date, day: DateTime.DaysInMonth(date.Year, date.Month));
                    }
                    else
                    {
                        start = WcApi.Date.DateUtils.CropTime(rangeDateTimePickerStart.Value);
                        end = WcApi.Date.DateUtils.CropTime(rangeDateTimePickerEnd.Value);
                    }

                    request.ByDate = rangeToggleCalendar.Checked;
                    request.StartDate = start;
                    request.EndDate = end;
                }

                LoadRanges(request);
            }
        }

        private void rangeToggleLimit_CheckedChanged(object sender, EventArgs e)
        {
            rangeLimitNum.Visible = rangeToggleLimit.Checked;
        }

        private void rangeToggleCalendar_CheckedChanged(object sender, EventArgs e)
        {
            if (rangeToggleCalendar.Checked)
            {
                rangeDateTimePickerStart.Enabled = true;
                rangeDateTimePickerEnd.Enabled = true;
                rangeDateTimePickerCalendar.Enabled = true;
            }
            else
            {
                rangeDateTimePickerStart.Enabled = false;
                rangeDateTimePickerEnd.Enabled = false;
                rangeDateTimePickerCalendar.Enabled = false;
            }
        }

        private void rangeToggleDateFormat_CheckedChanged(object sender, EventArgs e)
        {
            if (rangeToggleDateFormat.Checked)
            {
                rangeDateTimePickerCalendar.Visible = false;
                rangeDateTimePickerStart.Visible = true;
                rangeDateTimePickerEnd.Visible = true;
            }
            else
            {
                rangeDateTimePickerCalendar.Visible = true;
                rangeDateTimePickerStart.Visible = false;
                rangeDateTimePickerEnd.Visible = false;
            }
        }

        #endregion

        #region DataGrid Event

        private void barcodeDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = barcodeDataGridView.HitTest(e.X, e.Y).RowIndex;
                int currentMouseOverCol = barcodeDataGridView.HitTest(e.X, e.Y).ColumnIndex;

                if (currentMouseOverRow >= 0 && currentMouseOverCol >= 0)
                {
                    barcodeDataGridView.ClearSelection();
                    barcodeDataGridView.Rows[currentMouseOverRow].Cells[currentMouseOverCol].Selected = true;

                    _selectBarcode = GetDbBarcodeByRowIndex(currentMouseOverRow);

                    if (_selectBarcode != null)
                    {
                        toRangeMenuItem.Enabled = true;
                        loadFromRangeMenuItem.Enabled = true;
                    }
                    else
                    {
                        toRangeMenuItem.Enabled = false;
                        loadFromRangeMenuItem.Enabled = false;
                    }

                    barcodeContextMenu.Show(barcodeDataGridView, new Point(e.X, e.Y));
                }
            }
        }

        private void rangeDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = rangeDataGridView.HitTest(e.X, e.Y).RowIndex;
                int currentMouseOverCol = rangeDataGridView.HitTest(e.X, e.Y).ColumnIndex;

                if (currentMouseOverRow >= 0 && currentMouseOverCol >= 0)
                {
                    rangeDataGridView.ClearSelection();
                    rangeDataGridView.Rows[currentMouseOverRow].Cells[currentMouseOverCol].Selected = true;

                    _selectRange = GetDbRangeByRowIndex(currentMouseOverRow);

                    if (_selectRange != null)
                    {
                        allbarcodesMenuItem.Enabled = true;
                    }
                    else
                    {
                        allbarcodesMenuItem.Enabled = false;
                    }

                    rangeContextMenu.Show(rangeDataGridView, new Point(e.X, e.Y));
                }
            }
        }

        #endregion

        #region Private Methods

        private void FillTypeBox()
        {
            List<ExternalType> types = new List<ExternalType>
            {
                new ExternalType {Name = "ВСЕ", Value = 'A'},
                new ExternalType {Name = "Внутренние", Value = 'F'},
                new ExternalType {Name = "МЖД", Value = 'T'}
            };

            externalTypeBindingSource.DataSource = types;
        }

        private async void TestDbConnection()
        {
            if (_dataBase != null)
            {
                bool connect = await Connect.GetConnect().TestConnectAsync();
                if (!connect)
                {
                    ConnectForm connectForm = new ConnectForm();
                    if (connectForm.ShowDialog(this) == DialogResult.OK)
                    {
                        _dataBase = new DataBase(Connect.GetConnect(), _debugMode);
                    }
                }
                else
                    SuccessMessage("Подключение к БД - Ok.");
            }
            else
                ErrorMessage("Пустое подключение к БД.");
        }

        private async void LoadFirms()
        {
            if (_dataBase != null)
            {
                dbFirmBindingSource.DataSource = null;
                List<DbFirm> firms = await _dataBase.GetFirmsAsync();
                firms?.Insert(0, new DbFirm { InnId = 0, Name = "ВСЕ" });
                dbFirmBindingSource.DataSource = firms;
                SuccessMessage("Список организаций загружен.");
            }
            else
                ErrorMessage("Пустое подключение к БД.");
        }

        private async void LoadRanges(RangeRequest request)
        {
            dbRangeBindingSource.DataSource = null;
            ClearRangesInfo();

            _ranges = await _dataBase.GetRangesAsync(request);

            UpdateRangesInfo(_ranges);
            dbRangeBindingSource.DataSource = _ranges;
        }

        private async void LoadBarcodes(BarcodeRequest request)
        {
            dbBarcodeBindingSource.DataSource = null;
            ClearBarcodesInfo();

            _barcodes = await _dataBase.GetBarcodesAsync(request);

            UpdateBarcodesInfo(_barcodes);
            dbBarcodeBindingSource.DataSource = _barcodes;
        }

        private void ClearBarcodesInfo()
        {
            barcodeLabelCount.Text = "0";
            barcodeLabelFreeCount.Text = "0";
            barcodeLabelBusyCount.Text = "0";
            tbFilter.Text = "";
        }

        private void ClearRangesInfo()
        {
            rangeLabelRangeCount.Text = "0";
            rangeLabelBarcodeCount.Text = "0";
            rangeLabelBarcodeFree.Text = "0";
            rangeLabelBarcodeBusy.Text = "0";
            tbFilter.Text = "";
        }

        private void UpdateBarcodesInfo(List<DbBarcode> barcodes)
        {
            if (barcodes != null)
            {
                barcodeLabelCount.Text = barcodes.Count.ToString();
                barcodeLabelFreeCount.Text = barcodes.Count(b => b.StateId == 1).ToString();
                barcodeLabelBusyCount.Text = barcodes.Count(b => b.StateId == 2).ToString();
            }
        }

        private void UpdateRangesInfo(List<DbRange> ranges)
        {
            if (ranges != null)
            {
                rangeLabelRangeCount.Text = ranges.Count.ToString();
                rangeLabelBarcodeCount.Text = ranges.Sum(r => r.Count).ToString();
                rangeLabelBarcodeFree.Text = ranges.Sum(r => r.FreeCount).ToString();
                rangeLabelBarcodeBusy.Text = ranges.Sum(r => r.BusyCount).ToString();
            }
        }

        private void FindBarcode()
        {
            if (barcodeLabelError.Visible)
                barcodeLabelError.Visible = false;

            string barcode = barcodeTextBoxBarcode.Text.Trim();

            if (barcode.Length >= 13)
            {
                try
                {
                    if (!PostBarcodeGenerator.IsValid(barcode))
                    {
                        barcodeLabelError.Text = $"Невалидный ШПИ. Контрольный разряд должен быть - [{PostBarcodeGenerator.GenControlRank(barcode)}]";
                        barcodeLabelError.Visible = true;
                    }
                    else
                    {
                        BarcodeRequest request = new BarcodeRequest { Barcode = barcode };
                        LoadBarcodes(request);
                    }
                }
                catch (Exception e)
                {
                    if (_debugMode)
                    {
                        Logger.Error($"Ошибка получения [DbBarcode] - '{barcode}'");
                        Logger.Error(e);
                    }

                    ErrorMessage("Неверный ШПИ.");
                }
            }
            else
            {
                barcodeLabelError.Text = $"Неверная длина ШПИ. Длина должна быть 13 или 14 символов. Сейчас - [{barcode.Length}]";
                barcodeLabelError.Visible = true;
            }
        }

        private DbBarcode GetDbBarcodeByRowIndex(int rowIndex)
        {
            try
            {
                List<DbBarcode> barcodes = (List<DbBarcode>) dbBarcodeBindingSource.DataSource;
                if (barcodes.Count > 0)
                    return barcodes[rowIndex];
            }
            catch (Exception e)
            {
                if (_debugMode)
                {
                    Logger.Error("Ошибка получения [DbBarcode]");
                    Logger.Error(e);
                }

                ErrorMessage("Ошибка получения данных по индексу строки");

                return null;
            }

            return null;
        }

        private DbRange GetDbRangeByRowIndex(int rowIndex)
        {
            try
            {
                List<DbRange> ranges = (List<DbRange>) dbRangeBindingSource.DataSource;
                if (ranges.Count > 0)
                    return ranges[rowIndex];
            }
            catch (Exception e)
            {
                if (_debugMode)
                {
                    Logger.Error("Ошибка получения [DbRange]");
                    Logger.Error(e);
                }

                ErrorMessage("Ошибка получения данных по индексу строки");

                return null;
            }

            return null;
        }

        #endregion

        #region ContextMenu Event

        private void toRangeMenuItem_Click(object sender, EventArgs e)
        {
            if(_selectBarcode == null)
                return;

            dbRangeBindingSource.DataSource = null;

            try
            {
                RangeRequest request = new RangeRequest { RangeId = _selectBarcode.RangeId };
                LoadRanges(request);
                tabControl.SelectedTab = tabRanges;
            }
            catch (Exception exception)
            {
                if (_debugMode)
                {
                    Logger.Error($"Ошибка получения [DbRanges] - Id: {_selectBarcode.RangeId}");
                    Logger.Error(exception);
                }

                ErrorMessage("Ошибка получения данных по Id диапазона");
            }
        }

        private void loadFromRangeMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectBarcode == null)
                return;

            try
            {
                BarcodeRequest request = new BarcodeRequest { RangeId = _selectBarcode.RangeId };
                LoadBarcodes(request);
            }
            catch (Exception exception)
            {
                if (_debugMode)
                {
                    Logger.Error($"Ошибка получения [List<DbBarcode>] - RangeId: {_selectBarcode.RangeId}");
                    Logger.Error(exception);
                }

                ErrorMessage("Ошибка получения данных по Id диапазона");
            }
        }

        private void allbarcodesMenuItem_Click(object sender, EventArgs e)
        {
            if(_selectRange == null)
                return;

            try
            {
                ClearBarcodesInfo();
                BarcodeRequest request = new BarcodeRequest { RangeId = _selectRange.Id };
                LoadBarcodes(request);
                tabControl.SelectedTab = tabBarcodes;
            }
            catch (Exception exception)
            {
                if (_debugMode)
                {
                    Logger.Error($"Ошибка получения [List<DbBarcode>] - RangeId: {_selectBarcode.RangeId}");
                    Logger.Error(exception);
                }

                ErrorMessage("Ошибка получения данных по Id диапазона");
            }
        }

        #endregion

        #region Other Widgets Events

        private void rangeComboBoxFirm_Enter(object sender, EventArgs e)
        {
            WcApi.Keyboard.Keyboard.SetRussianLanguage();
        }

        private void rangeDateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            rangeDateTimePickerEnd.Value = rangeDateTimePickerStart.Value;
        }

        #endregion
    }
}
