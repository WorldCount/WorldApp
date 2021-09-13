using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DwUtils.Core.Database;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Requests;
using DwUtils.Core.Forms.ConnectForms;
using DwUtils.Core.Forms.EditForms;
using DwUtils.Core.PrintDocuments;
using DwUtils.Core.Stats;
using DwUtils.Core.Types;
using Wc32Api.Extensions.Bindings;
using Wc32Api.Widgets.Menus;
using WcApi.Ext;

namespace DwUtils.Core.Forms
{
    public partial class GeneralForm : Form
    {
        #region Private Fields

        private bool _debugMode;
        private Db _database;
        private string _lkState;
        private List<User> _users;
        private List<Place> _places;
        private ReceivePrintDocument _receivePrintDocument;

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

            Wc32Api.DrawingControl.SetDoubleBuffered(panelWork);

            // Настройка таблиц
            InitTables();

            // Загрузка настроек
            LoadSettings();
        }

        #region Form Config

        // Загрузка настроек
        private void LoadSettings()
        {
            _debugMode = Properties.Settings.Default.DebugMode;
            _database = new Db(_debugMode);
            toggleDebug.Checked = Properties.Settings.Default.DebugMode;

            int lastTabIndex = Properties.Settings.Default.LastTabIndex;
            tabControl.SelectedIndex = lastTabIndex >= tabControl.TabCount ? 0 : lastTabIndex;

            _lkState = Properties.Settings.Default.LkApiUrl;

            rpoTypeBindingSource.DataSource = RpoType.GetRpoTypes();

            LoadData();
            //CheckLkState();
        }

        // Сохранение настроек
        private void SaveSettings()
        {
            Properties.Settings.Default.LastTabIndex = tabControl.SelectedIndex;
            Properties.Settings.Default.Save();

            if (_database != null && !string.IsNullOrEmpty(_lkState))
            {
                _database.Settings.SetLkApiUrl(_lkState);
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

        private void form_Load(object sender, EventArgs e)
        {
            LoadPos();

            // Чтение аргументов
            CheckArgs();
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
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

        private void InitTables()
        {
            Wc32Api.DrawingControl.SetDoubleBuffered(freeRpoDataGridView);
            Wc32Api.DrawingControl.SetDoubleBuffered(onlineDataGridView);
            Wc32Api.DrawingControl.SetDoubleBuffered(filesDataGridView);
            Wc32Api.DrawingControl.SetDoubleBuffered(receivedDataGridView);

            // Free Rpo
            freeRpoColumnCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            freeRpoColumnCheck.Width = 40;
            freeRpoColumnCheck.CellTemplate.Style.BackColor = Color.FromArgb(53, 56, 58);
            freeRpoColumnCheck.CellTemplate.Style.SelectionBackColor = Color.FromArgb(53, 56, 58);

            freeRpoColumnLoadDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            freeRpoColumnLoadDate.Width = 100;

            freeRpoColumnType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            freeRpoColumnType.Width = 60;

            freeRpoColumnBarcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            freeRpoColumnBarcode.Width = 160;

            freeRpoColumnIndexTo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            freeRpoColumnIndexTo.Width = 80;

            freeRpoColumnPlaceId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            freeRpoColumnUserId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            freeRpoColumnUserId.Width = 200;

            // Online
            onlineColumnPlaceName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            onlineColumnPlaceName.Width = 300;

            onlineColumnConnectDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            onlineColumnConnectDate.Width = 140;

            onlineColumnWorkDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            onlineColumnWorkDate.Width = 140;

            onlineColumnAdminStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            onlineColumnAdminStatus.Width = 60;

            // Received
            receivedColumnClientName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            receivedColumnAllCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            receivedColumnAllCount.Width = 120;

            receivedColumnReceivedCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            receivedColumnReceivedCount.Width = 120;

            receivedColumnReturnCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            receivedColumnReturnCount.Width = 120;

            receivedColumnReturnPay.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            receivedColumnReturnPay.Width = 200;
        }

        private async void LoadData()
        {
            if (_database != null)
            {
                await Task.Run(() =>
                {
                    // Загрузка пользователей
                    _users = _database.Users.GetUsers();
                    // Загрузка мест
                    _places = _database.Places.GetPlaces();
                });

                _places?.Insert(0, new Place { Id = 0, Name = "ВСЕ" });

                if (_users != null)
                {
                    if (_users.Count > 0)
                        btnLoadFreeRpo.Enabled = true;

                    _users.Insert(0, new User { Id = 0, Name = "ВСЕ" });
                }

                UpdateData(userBindingSource, _users);
                UpdateData(placeBindingSource, _places);
            }
        }

        private async void LoadFreeRpos()
        {
            freeRpoLabelCount.Text = "0";
            freeRpoBindingSource.DataSource = null;

            FreeRpoRequest request = new FreeRpoRequest
            {
                StartDate = freeRpoDateTimePickerStart.Value,
                EndDate = freeRpoDateTimePickerEnd.Value,
                FilterDate = freeRpoToggleButtonDate.Checked,
                PlaceId = ((Place) freeRpoComboBoxPlace.SelectedItem).Id,
                TypeId = ((RpoType) freeRpoComboBoxRpoType.SelectedItem).Id,
                UserId = ((User) freeRpoComboBoxUsers.SelectedItem).Id
            };

            List<FreeRpo> rpos = await _database.Rpos.GetFreeRposAsync(request);
            freeRpoBindingSource.DataSource = rpos;

            if (rpos != null)
            {
                freeRpoLabelCount.Text = rpos.Count.ToString();
                SuccessMessage("РПО загружены!");
            }
        }

        private async void LoadConnectUsers()
        {
            onlineLabelCount.Text = "0";
            connectUserBindingSource.DataSource = null;

            List<ConnectUser> connectUsers = await _database.Users.GetConnectUsersAsync();
            connectUserBindingSource.DataSource = connectUsers;

            if (connectUsers != null)
                onlineLabelCount.Text = connectUsers.Count.ToString();
        }

        private void UpdateData<T>(BindingSource source, T data)
        {
            source.DataSource = null;
            source.DataSource = data;
        }

        private FreeRpo GetFreeRpoByRowIndex(int rowIndex)
        {
            List<FreeRpo> rpos = (List<FreeRpo>) freeRpoBindingSource.DataSource;

            try
            {
                if (rpos != null && rpos.Count > 0)
                    return rpos[rowIndex];
            }
            catch
            {
                return null;
            }

            return null;
        }

        private void CheckFreeRpoReverse()
        {
            List<FreeRpo> rpos = (List<FreeRpo>) freeRpoBindingSource.DataSource;
            if (rpos != null)
            {
                foreach (FreeRpo rpo in rpos)
                    rpo.Check = !rpo.Check;
            }

            UpdateData(freeRpoBindingSource, rpos);
        }

        private void OpenDropdownMenu(WcDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += (s, ev) => dropdownMenu_VisibleChanged(s, ev, control);
            dropdownMenu.Show(control, control.Top, control.Height);
        }

        private int GetPrintDocumentPageCount(ReceivePrintDocument document)
        {
            int count = 0;
            document.PrintController = new PreviewPrintController();
            document.PrintPage += (s, e) => count++;
            document.Print();
            return count;
        }

        private async Task<ReceivePrintDocument> GetReceivePrintDocument(List<ReceivedRpo> rpos, ReceiveRpoStat stat, User user, string date)
        {
            return await Task.Run(() =>
            {
                int[] columnWidth = { 270, 140, 100, 100, 160 };
                PrintController printController = new StandardPrintController();

                ReceivePrintDocument document = new ReceivePrintDocument(rpos, columnWidth, stat)
                {
                    PrintNumPageInfo = true,
                    PrintLogo = true,
                    ReportTitle = "ОТЧЕТ НА ВРУЧЕНИЕ",
                    ReportSubTitle = $"Период: {date}, Оператор: {user.Name}"
                };

                int count = GetPrintDocumentPageCount(document);
                document.PagesCount = count;
                document.PrintController = printController;

                return document;
            });
        }

        #endregion

        #region Menu Events

        private void dropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctrl)
        {
            WcDropdownMenu dropdownMenu = (WcDropdownMenu)sender;
            if (!DesignMode)
            {
                ctrl.BackColor = dropdownMenu.Visible ? Color.FromArgb(80, 88, 100) : Color.FromArgb(67, 74, 84);
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void connectPostUnitMenuItem_Click(object sender, EventArgs e)
        {
            PostUnitConnectForm postUnitConnectForm = new PostUnitConnectForm();

            if (postUnitConnectForm.ShowDialog(this) == DialogResult.OK)
            {
                _database.Refresh();
                LoadData();
            }
        }

        private void connectPostItemMenuItem_Click(object sender, EventArgs e)
        {
            PostItemConnectForm postItemConnectForm = new PostItemConnectForm();

            if (postItemConnectForm.ShowDialog(this) == DialogResult.OK)
            {
                _database.Refresh();
                LoadData();
            }
        }

        private void configMenuItem_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            if (configForm.ShowDialog(this) == DialogResult.OK)
                _lkState = Properties.Settings.Default.LkApiUrl;
        }

        private void fileMenuItem_Click(object sender, EventArgs e)
        {
            OpenDropdownMenu(wcDropdownMenuFile, fileMenuItem);
        }

        private void settingsMenuItem_Click(object sender, EventArgs e)
        {
            OpenDropdownMenu(wcDropdownMenuSettings, settingsMenuItem);
        }

        #endregion

        #region Toggle Events

        private void toggleDebug_CheckedChanged(object sender, EventArgs e)
        {
            _debugMode = toggleDebug.Checked;
            _database.SetDebug(_debugMode);

            Properties.Settings.Default.DebugMode = _debugMode;
            Properties.Settings.Default.Save();
        }

        private async void toggleLoadLk_CheckedChanged(object sender, EventArgs e)
        {
            bool res;

            if (toggleLoadLk.Checked)
                res = await _database.Settings.SetLkApiUrlAsync(_lkState);
            else
                res = await _database.Settings.SetLkApiUrlAsync("");

            if(res)
                SuccessMessage("Статус загрузки ЛК изменен.");
            else
                ErrorMessage("Ошибка изменения статуса ЛК.");
        }

        private void freeRpoToggleButtonDate_CheckedChanged(object sender, EventArgs e)
        {
            freeRpoDateTimePickerStart.Enabled = freeRpoToggleButtonDate.Checked;
            freeRpoDateTimePickerEnd.Enabled = freeRpoToggleButtonDate.Checked;
        }

        private void filesToggleButtonDate_CheckedChanged(object sender, EventArgs e)
        {
            filesDateTimePickerStart.Enabled = filesToggleButtonDate.Checked;
            filesDateTimePickerEnd.Enabled = filesToggleButtonDate.Checked;
        }

        private void filesToggleButtonLimit_CheckedChanged(object sender, EventArgs e)
        {
            filesLimit.Enabled = filesToggleButtonLimit.Checked;
        }

        private void receivedToggleButtonCalendar_CheckedChanged(object sender, EventArgs e)
        {
            receivedDateTimePickerStart.Visible = !receivedToggleButtonCalendar.Checked;
            receivedDateTimePickerEnd.Visible = !receivedToggleButtonCalendar.Checked;
            receivedDateTimePickerMonth.Visible = receivedToggleButtonCalendar.Checked;
        }

        #endregion

        #region Buttons Events

        private void btnLoadFreeRpo_Click(object sender, EventArgs e)
        {
            LoadFreeRpos();
        }

        private void btnLoadConnectedUser_Click(object sender, EventArgs e)
        {
            LoadConnectUsers();
        }

        private async void btnDeleteFreeRpo_Click(object sender, EventArgs e)
        {
            List<FreeRpo> rpos = (List<FreeRpo>) freeRpoBindingSource.DataSource;
            if (rpos != null)
            {
                List<FreeRpo> checkedRpos = rpos.Where(r => r.Check).ToList();
                if(checkedRpos.Count == 0)
                    return;

                if (MessageBox.Show($"Вы уверены что хотите удалить отправления: {checkedRpos.Count} шт?",
                    "Удаление РПО", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Разбиваем данные по 1000
                    var data = checkedRpos.Chunk(1000);
                    foreach (IEnumerable<FreeRpo> freeRpos in data)
                        await _database.Rpos.DeleteFreeRposAsync(freeRpos.ToList());

                    LoadFreeRpos();
                }
            }
        }

        private async void btnEditFreeRpo_Click(object sender, EventArgs e)
        {
            List<FreeRpo> rpos;

            try
            {
                rpos = (List<FreeRpo>)freeRpoBindingSource.DataSource;
            }
            catch
            {
                return;
            }

            
            if (rpos != null)
            {
                List<FreeRpo> checkedRpos = rpos.Where(r => r.Check).ToList();
                if (checkedRpos.Count == 0)
                    return;

                EditPlaceForm editPlaceForm = new EditPlaceForm(_database);
                if (editPlaceForm.ShowDialog(this) == DialogResult.OK)
                {
                    Place place = editPlaceForm.Place;

                    // Разбиваем данные по 1000
                    var data = checkedRpos.Chunk(1000);
                    foreach (IEnumerable<FreeRpo> freeRpos in data)
                    {
                        await _database.Rpos.UpdateFreeRposPlaceAsync(freeRpos.ToList(), place.Id);
                    }

                    LoadFreeRpos();
                }
            }
        }

        private async void btnLoadFiles_Click(object sender, EventArgs e)
        {
            filesLabelCount.Text = "0";
            filesLabelRpoCount.Text = "0";
            rpoFileBindingSource.DataSource = null;

            RpoFileRequest request = new RpoFileRequest
            {
                StartDate = filesDateTimePickerStart.Value,
                EndDate = filesDateTimePickerEnd.Value,
                FilterDate = filesToggleButtonDate.Checked,
                UserId = ((User) filesComboBoxUsers.SelectedItem).Id
            };

            if (filesLimit.Enabled)
                request.Limit = (int) filesLimit.Value;

            List<RpoFile> files = await _database.Files.GetFilesAsync(request);
            rpoFileBindingSource.DataSource = files;

            if (files != null)
            {
                filesLabelCount.Text = files.Count.ToString();
                filesLabelRpoCount.Text = files.Sum(f => f.Count).ToString();
                SuccessMessage("Файлы - загружены!");
            }
        }

        private async void btnLoadReceived_Click(object sender, EventArgs e)
        {
            receivedLabelPosCount.Text = "0";
            receivedLabelAllCount.Text = "0";
            receivedLabelReceiveCount.Text = "0";
            receivedLabelReturnCount.Text = "0";
            receivedLabelReturnPay.Text = "0,00 ₽";
            receivedRpoBindingSource.DataSource = null;
            _receivePrintDocument = null;
            btnPrintReceived.Enabled = false;

            User user = (User) receivedComboBoxUsers.SelectedItem;
            DateTime start;
            DateTime end;
            string dateString = "";

            if (receivedDateTimePickerMonth.Visible)
            {
                DateTime date = receivedDateTimePickerMonth.Value;
                start = WcApi.Date.DateUtils.CropDate(date, day: 1);
                end = WcApi.Date.DateUtils.CropDate(date, day: DateTime.DaysInMonth(date.Year, date.Month));
                dateString = WcApi.Date.DateUtils.GetMonthName(receivedDateTimePickerMonth.Value);
            }
            else
            {
                start = WcApi.Date.DateUtils.CropTime(receivedDateTimePickerStart.Value);
                end = WcApi.Date.DateUtils.CropTime(receivedDateTimePickerEnd.Value);
                dateString = start == end ? $"{start:dd.MM.yyyy}" : $"{start:dd.MM.yyyy} - {end:dd.MM.yyyy}";
            }

            ReceivedRpoRequest request = new ReceivedRpoRequest
            {
                UserId = user.Id,
                StartDate = start,
                EndDate = end
            };

            List<ReceivedRpo> rpos = await _database.Rpos.GetReceivedRposAsync(request);
            receivedRpoBindingSource.DataSource = rpos.ToSortableBindingList();

            receivedDataGridView.Sort(receivedColumnClientName, ListSortDirection.Ascending);

            ReceiveRpoStat stat = new ReceiveRpoStat(rpos) { ReplaceNull = true };

            receivedLabelPosCount.Text = stat.PosCount;
            receivedLabelAllCount.Text = stat.AllCount;
            receivedLabelReceiveCount.Text = stat.ReceiveCount;
            receivedLabelReturnCount.Text = stat.ReturnCount;
            receivedLabelReturnPay.Text = stat.GetReturnPayToFormat();

            if (rpos.Count > 0)
            {
                btnPrintReceived.Enabled = true;
                _receivePrintDocument = await GetReceivePrintDocument(rpos, stat, user, dateString);
            }

            SuccessMessage("РПО на доставку - загружены!");
        }

        #endregion

        #region DataGrid Events

        #region All

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var grid = (DataGridView) sender;
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

        #region FreeRpo

        private void freeRpoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == freeRpoColumnCheck.Index && e.RowIndex != -1)
            {
                FreeRpo freeRpo = GetFreeRpoByRowIndex(e.RowIndex);

                if (freeRpo != null)
                    freeRpo.Check = !freeRpo.Check;
            }
        }

        private void freeRpoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == freeRpoColumnCheck.Index && e.RowIndex != -1)
            {
                FreeRpo freeRpo = GetFreeRpoByRowIndex(e.RowIndex);

                if (freeRpo != null)
                    freeRpo.Check = !freeRpo.Check;
            }
        }

        private void freeRpoDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == freeRpoColumnCheck.Index && e.RowIndex != -1)
                freeRpoDataGridView.EndEdit();
        }

        private void freeRpoDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var grid = (DataGridView)sender;
            var sortIconColor = Color.Gray;

            if (e.ColumnIndex == freeRpoColumnCheck.Index && e.RowIndex != -1)
            {
                bool value = (bool)e.FormattedValue;
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
                Bitmap img = value ? Properties.Resources.gray_checked_32 : Properties.Resources.gray_unchecked_32;
                Size size = img.Size;
                Point loc = new Point((e.CellBounds.Width - size.Width) / 2, (e.CellBounds.Height - size.Height) / 2);
                loc.Offset(e.CellBounds.Location);
                e.Graphics.DrawImage(img, loc);
                e.Handled = true;
            }

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

        private void freeRpoDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void freeRpoDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == freeRpoColumnCheck.Index)
            {
                CheckFreeRpoReverse();
                freeRpoDataGridView.EndEdit();
            }
        }

        private void freeRpoDataGridView_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void freeRpoDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        #endregion

        #region Received

        private void receivedDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (receivedDataGridView.Columns[e.ColumnIndex] == receivedColumnReturnCount ||
                receivedDataGridView.Columns[e.ColumnIndex] == receivedColumnReceivedCount)
            {
                int value = (int)e.Value;
                if (value == 0)
                    e.Value = "-";
            }

            if (receivedDataGridView.Columns[e.ColumnIndex] == receivedColumnReturnPay)
            {
                double value = (double)e.Value;

                // ReSharper disable once CompareOfFloatsByEqualityOperator
                if (value == 0)
                    e.Value = "-";
            }
        }

        #endregion

        #region Online

        private void onlineDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        #endregion

        #endregion

        #region Resize Events

        private void form_SizeChanged(object sender, EventArgs e)
        {
            panelMenu.Refresh();
        }

        #endregion

        #region TabControl Events

        #endregion

        #region DatePicker Events

        private void freeRpoDateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            freeRpoDateTimePickerEnd.Value = freeRpoDateTimePickerStart.Value;
        }

        private void filesDateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            filesDateTimePickerEnd.Value = filesDateTimePickerStart.Value;
        }

        private void receivedDateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            receivedDateTimePickerEnd.Value = receivedDateTimePickerStart.Value;
        }

        #endregion

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_database.Documents.GenDocumentNum(101, 12), "Номер накладной");
        }

        private void btnPrintReceived_Click(object sender, EventArgs e)
        {
            btnPrintReceived.Enabled = false;

            _receivePrintDocument?.Print();

            btnPrintReceived.Enabled = true;
        }
    }
}
