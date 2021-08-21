using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
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
        }

        private void InitTables()
        {
            // Таблица со ШПИ
            barcodeColumnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnDate.Width = 140;

            barcodeColumnBarcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnBarcode.Width = 160;

            barcodeColumnMonth.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnMonth.Width = 80;

            barcodeColumnNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnNum.Width = 80;

            barcodeColumnSeria.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnSeria.Width = 80;

            barcodeColumnState.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barcodeColumnState.Width = 140;

            barcodeColumnFirmName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        #region Private Methods

        private void LoadBarcode()
        {
            if (barcodeLabelError.Visible)
                barcodeLabelError.Visible = false;

            string barcode = barcodeTextBoxBarcode.Text.Trim();

            if (barcode.Length >= 13)
            {

                if (!PostBarcodeGenerator.IsValid(barcode))
                {
                    barcodeLabelError.Text = $"Невалидный ШПИ. Контрольный разряд должен быть - [{PostBarcodeGenerator.GenControlRank(barcode)}]";
                    barcodeLabelError.Visible = true;
                }
                else
                {
                    dbBarcodeBindingSource.DataSource = null;
                    _barcodes = _dataBase.GetBarcodes(barcode);
                    barcodeLabelCount.Text = _barcodes.Count.ToString();
                    dbBarcodeBindingSource.DataSource = _barcodes;
                }
            }
            else
            {
                barcodeLabelError.Text = $"Неверная длина ШПИ. Длина должна быть 13 или 14 символов. Сейчас - [{barcode.Length}]";
                barcodeLabelError.Visible = true;
            }
        }

        #endregion
    }
}
