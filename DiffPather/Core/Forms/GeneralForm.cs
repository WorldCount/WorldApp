using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiffPather.Core.Database;
using DiffPather.Core.Database.Contexts;
using DiffPather.Core.Database.Models;
using DiffPather.Core.Forms.AppsForms;
using DiffPather.Core.Storage;
using NLog;

namespace DiffPather.Core.Forms
{
    public partial class GeneralForm : Form
    {
        #region Private Fields

        private List<AppInfo> _appInfos;
        private bool _debugMode;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

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
            toggleButtonDebug.Checked = _debugMode;
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

            // Создание БД
            CreateDb();

            FirstQuery();
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

        #region Database

        private async void FirstQuery()
        {
            await Task.Run(() =>
            {
                using (DiffPatherContext db = new DiffPatherContext())
                {
                    try
                    {
                        _ = db.AppInfos.Last();
                    }
                    catch
                    {
                        //
                    }
                }
            });
        }

        private void CreateDb()
        {
            if (!File.Exists(PathManager.DatabasePath))
            {
                CreateDbForm createDbForm = new CreateDbForm(true);
                createDbForm.ShowDialog(this);
            }
        }

        private async void LoadApps()
        {
            _appInfos = await Db.GetAppInfosAsync();
            UpdateApps();
        }

        private void UpdateApps()
        {
            appInfoBindingSource.DataSource = null;
            appInfoBindingSource.DataSource = _appInfos;

            appsLabelCount.Text = _appInfos != null ? _appInfos.Count.ToString() : "0";
        }
        private AppInfo GetAppInfoByIndex(int index)
        {
            try
            {
                List<AppInfo> appInfos = (List<AppInfo>)appInfoBindingSource.DataSource;
                if (appInfos != null && appInfos.Count > 0)
                {
                    return appInfos[index];
                }

                return null;
            }
            catch
            {
                return null;
            }
            
        }

        #endregion


        #endregion

        #region Menu Event

        private void createDbMenuItem_Click(object sender, EventArgs e)
        {
            CreateDbForm createDbForm = new CreateDbForm(_debugMode);
            createDbForm.ShowDialog(this);
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Button Event

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = @"Приложение (*.exe)|*.exe", Multiselect = false, RestoreDirectory = false };

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(fileInfo.FullName);

                AppInfo appInfo = new AppInfo
                {
                    DirectoryLocation = fileInfo.DirectoryName, 
                    Name = fileInfo.Name.Replace(".exe", ""),
                    CurrentVersion = versionInfo.FileVersion,
                    Description = versionInfo.FileDescription
                };

                AddAppForm addAppForm = new AddAppForm(appInfo);
                if (addAppForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadApps();
                }
            }
        }

        private void btnUpdateApps_Click(object sender, EventArgs e)
        {
            LoadApps();
        }

        private void toggleButtonDebug_CheckedChanged(object sender, EventArgs e)
        {
            _debugMode = toggleButtonDebug.Checked;
            Properties.Settings.Default.DebugMode = _debugMode;
            Properties.Settings.Default.Save();
        }

        #endregion

        #region DataGrid Events

        private async void appsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (await Db.UpdateAppInfosAsync(_appInfos))
                SuccessMessage("Данные обновленны.");
            else
                ErrorMessage("Не удалось обновить данные.");
        }

        private void appsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = appsDataGridView.HitTest(e.X, e.Y).RowIndex;
                int currentMouseOverCol = appsDataGridView.HitTest(e.X, e.Y).ColumnIndex;

                if (currentMouseOverRow >= 0 && currentMouseOverCol >= 0)
                {
                    appsDataGridView.ClearSelection();
                    appsDataGridView.Rows[currentMouseOverRow].Cells[currentMouseOverCol].Selected = true;

                    AppInfo appInfo = GetAppInfoByIndex(currentMouseOverRow);

                    if (appInfo != null)
                    {
                        appsEditContexMenuItem.Enabled = true;
                        appsEditContexMenuItem.Tag = appInfo;

                        appsRemoveContexMenuItem.Enabled = true;
                        appsRemoveContexMenuItem.Tag = appInfo;
                    }
                    else
                    {
                        appsEditContexMenuItem.Enabled = false;
                        appsEditContexMenuItem.Tag = null;

                        appsRemoveContexMenuItem.Enabled = false;
                        appsRemoveContexMenuItem.Tag = null;

                    }

                    appsContextMenu.Show(appsDataGridView, new Point(e.X, e.Y));
                }
            }
        }

        #endregion

        #region ContextMenu Events

        private async void appsEditContexMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private async void appsRemoveContexMenuItem_Click(object sender, EventArgs e)
        {
            AppInfo appInfo = (AppInfo)((ToolStripMenuItem)sender).Tag;

            if (appInfo != null)
            {
                try
                {
                    if (MessageBox.Show($"Вы действительно хотите удалить приложение '{appInfo.Name}'?",
                            $"Удаление '{appInfo.Name}'", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.Yes)
                    {
                        await Db.DeleteAppInfoAsync(appInfo);
                        LoadApps();
                        SuccessMessage($"Приложение '{appInfo.Name}' удалено!");
                    }
                    else
                        InfoMessage($"Отмена удаления '{appInfo.Name}'.");
                }
                catch (Exception exception)
                {
                    if (_debugMode)
                        Logger.Error(exception);

                    ErrorMessage($"Немогу удалить приложение '{appInfo.Name}'.");
                }
            }
            else
                ErrorMessage("Немогу определить приложение для удаления.");
        }

        #endregion

        #region Other Events

        #endregion
        
    }
}
