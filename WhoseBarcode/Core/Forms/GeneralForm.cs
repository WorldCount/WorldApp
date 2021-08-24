using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NLog;
using WcPostApi.Barcodes;
using WhoseBarcode.Core.Database;
using WhoseBarcode.Core.Database.Models;

namespace WhoseBarcode.Core.Forms
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
            // Таблица со ШПИ
            barcodeColumnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnDate.Width = 140;

            barcodeColumnBarcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnBarcode.Width = 160;

            barcodeColumnOps.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnOps.Width = 80;

            barcodeColumnMonth.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnMonth.Width = 80;

            barcodeColumnNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnNum.Width = 80;

            barcodeColumnSeria.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnSeria.Width = 80;

            barcodeColumnState.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnState.Width = 140;

            barcodeColumnFirmName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Таблица с диапазонами

            rangeColumnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnId.Width = 60;

            rangeColumnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnDate.Width = 140;

            rangeColumnOps.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnOps.Width = 80;

            rangeColumnMonth.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnMonth.Width = 80;

            rangeColumnSeria.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnSeria.Width = 80;

            rangeColumnCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rangeColumnCount.Width = 140;
   
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
                LoadBarcode();
                barcodeTextBoxBarcode.SelectAll();
            }
        }

        private void barcodeTextBoxBarcode_Enter(object sender, EventArgs e)
        {
            WcApi.Keyboard.Keyboard.SetEnglishLanguage();
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
           LoadBarcode();
           barcodeTextBoxBarcode.Focus();
           barcodeTextBoxBarcode.SelectAll();
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

        #endregion

        #region Private Methods

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
        }

        private async void LoadBarcode()
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
                        dbBarcodeBindingSource.DataSource = null;
                        _barcodes = await _dataBase.GetBarcodesAsync(barcode);

                        barcodeLabelCount.Text = _barcodes.Count.ToString();
                        barcodeLabelFreeCount.Text = _barcodes.Count(b => b.StateId == 1).ToString();
                        barcodeLabelBusyCount.Text = _barcodes.Count(b => b.StateId == 2).ToString();

                        dbBarcodeBindingSource.DataSource = _barcodes;
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

        #endregion

        #region ContextMenu Event

        private async void toRangeMenuItem_Click(object sender, EventArgs e)
        {
            if(_selectBarcode == null)
                return;


            dbRangeBindingSource.DataSource = null;

            try
            {
                _ranges = await _dataBase.GetRangesAsync(_selectBarcode.RangeId);

                rangeLabelCount.Text = _ranges.Count.ToString();
                dbRangeBindingSource.DataSource = _ranges;

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
            
        }


        #endregion

        
    }
}
