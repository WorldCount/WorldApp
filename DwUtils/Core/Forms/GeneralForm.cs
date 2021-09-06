using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DwUtils.Core.Database;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Forms.ConnectForms;
using DwUtils.Core.Forms.EditForms;
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
        private const int BorderSize = 2;

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

            Padding = new Padding(BorderSize);
            // Border Color
            BackColor = Color.FromArgb(100, 106, 111);

            // Настройка таблиц
            InitTables();

            // Загрузка настроек
            LoadSettings();
        }

        #region Form Config

        #region Design

        #region Overriddes Properties

        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                labelTitle.Text = value;
            }
        }

        #endregion

        #region Extension

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        #region Overriddes Methods

        protected override void WndProc(ref Message m)
        {
            // ReSharper disable once InconsistentNaming
            const int WM_NCCALCSIZE = 0x0083;
            // ReSharper disable once InconsistentNaming
            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;

            // ReSharper disable once InconsistentNaming
            const int HTCLIENT = 1;
            // ReSharper disable once InconsistentNaming
            const int HTLEFT = 10;
            // ReSharper disable once InconsistentNaming
            const int HTRIGHT = 11;
            // ReSharper disable once InconsistentNaming
            const int HTTOP = 12;
            // ReSharper disable once InconsistentNaming
            const int HTTOPLEFT = 13;
            // ReSharper disable once InconsistentNaming
            const int HTTOPRIGHT = 14;
            // ReSharper disable once InconsistentNaming
            const int HTBOTTOM = 15;
            // ReSharper disable once InconsistentNaming
            const int HTBOTTOMLEFT = 16;
            // ReSharper disable once InconsistentNaming
            const int HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);

                if (WindowState == FormWindowState.Normal)
                {
                    if ((int)m.Result == HTCLIENT)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = PointToClient(screenPoint);

                        if (clientPoint.Y <= resizeAreaSize)
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTTOPLEFT;
                            else if (clientPoint.X < (Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTTOP;
                            else
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (Size.Height - resizeAreaSize))
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (Width - resizeAreaSize))
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTBOTTOM;
                            else
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }

                return;
            }

            // Remove border
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            base.WndProc(ref m);
        }

        #endregion

        #region Private Methods

        private void AdjustForm()
        {
            switch (WindowState)
            {
                case FormWindowState.Maximized:
                    Padding = new Padding(8, 8, 8, 0);
                    break;

                case FormWindowState.Normal:
                    if (Padding.Top != BorderSize)
                        Padding = new Padding(BorderSize);
                    break;
            }
        }

        #endregion

        #region Form Extends Event

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void form_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void labelTitle_DoubleClick(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        #endregion

        #endregion

        // Загрузка настроек
        private void LoadSettings()
        {
            _debugMode = Properties.Settings.Default.DebugMode;
            toggleDebug.Checked = Properties.Settings.Default.DebugMode;
            _database = new Db(PostItemConnect.GetConnect(), PostUnitConnect.GetConnect(), _debugMode);

            int lastTabIndex = Properties.Settings.Default.LastTabIndex;
            tabControl.SelectedIndex = lastTabIndex >= tabControl.TabCount ? 0 : lastTabIndex;

            _lkState = Properties.Settings.Default.LkApiUrl;

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

            // Free Rpo
            freeRpoColumnCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            freeRpoColumnCheck.Width = 60;
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
        }

        private async void LoadData()
        {
            if (_database != null)
            {
                string state = "";
                await Task.Run(() =>
                {
                    // Загрузка пользователей
                    _users = _database.GetUsers();
                    // Загрузка мест
                    _places = _database.GetPlaces();

                    state = _database.GetLkApiUrl();
                });


                toggleLoadLk.Checked = !string.IsNullOrEmpty(state);
                UpdateData(userBindingSource, _users);
                UpdateData(placeBindingSource, _places);

                if (_users != null && _users.Count > 0)
                    btnLoadFreeRpo.Enabled = true;
            }
        }

        private async void LoadFreeRpos()
        {
            freeRpoLabelCount.Text = "0";
            freeRpoBindingSource.DataSource = null;

            List<FreeRpo> rpos = await _database.GetFreeRposAsync();
            
            freeRpoBindingSource.DataSource = rpos;

            if (rpos != null)
                freeRpoLabelCount.Text = rpos.Count.ToString();
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

        #region Buttons Events

        private void btnLoadFreeRpo_Click(object sender, EventArgs e)
        {
            LoadFreeRpos();
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
                        await _database.DeleteFreeRposAsync(freeRpos.ToList());

                    LoadFreeRpos();
                }
            }
        }

        private async void btnEditFreeRpo_Click(object sender, EventArgs e)
        {
            List<FreeRpo> rpos = (List<FreeRpo>)freeRpoBindingSource.DataSource;
            if (rpos != null)
            {
                List<FreeRpo> checkedRpos = rpos.Where(r => r.Check).ToList();
                if (checkedRpos.Count == 0)
                    return;

                EditPlaceForm editPlaceForm = new EditPlaceForm(_places);
                if (editPlaceForm.ShowDialog(this) == DialogResult.OK)
                {
                    Place place = editPlaceForm.Place;

                    // Разбиваем данные по 1000
                    var data = checkedRpos.Chunk(1000);
                    foreach (IEnumerable<FreeRpo> freeRpos in data)
                    {
                        await _database.UpdateFreeRposPlaceAsync(freeRpos.ToList(), place.Id);
                    }

                    LoadFreeRpos();
                }
            }
        }

        #endregion

        #region DataGrid Events

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
            var grid = (DataGridView) sender;
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

        #region Resize Events

        private void form_SizeChanged(object sender, EventArgs e)
        {
            panelMenu.Refresh();
        }

        #endregion
    }
}
