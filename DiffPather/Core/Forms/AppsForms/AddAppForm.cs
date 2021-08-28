﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiffPather.Core.Database.Contexts;
using DiffPather.Core.Database.Models;
using WcApi.Cryptography;

namespace DiffPather.Core.Forms.AppsForms
{
    public partial class AddAppForm : Form
    {
        #region Private Fields

        private readonly AppInfo _appInfo;
        private AppVersion _version;
        private List<AppFile> _files;

        #endregion

        public AddAppForm(AppInfo appInfo)
        {
            InitializeComponent();

            _appInfo = appInfo;

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Добавление приложения";

            // Хук двойной буфферизации для таблицы
            Wc32Api.DrawingControl.SetDoubleBuffered(dataGridView);

            InitTable();
        }

        #region Private Methods

        private void InitTable()
        {
            filesColumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            filesColumnName.Width = 300;

            filesColumnExtension.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            filesColumnExtension.Width = 60;

            filesColumnHash.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            filesColumnHash.Width = 300;

            filesColumnLocation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BindingData()
        {
            appNameTextBox.DataBindings.Add("Text", _appInfo, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            appDescriptionTextBox.DataBindings.Add("Text", _appInfo, "Description", false, DataSourceUpdateMode.OnPropertyChanged);
            appVersionTextBox.DataBindings.Add("Text", _appInfo, "CurrentVersion", false, DataSourceUpdateMode.OnPropertyChanged);
            appLocationTextBox.DataBindings.Add("Text", _appInfo, "DirectoryLocation", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private List<AppFile> LoadFiles()
        {
            if (_appInfo == null)
                return null;

            if (!string.IsNullOrEmpty(_appInfo.DirectoryLocation))
            {
                string[] files = WcApi.Files.FindFiles.SearchAllFiles(_appInfo.DirectoryLocation);
                List<AppFile> appFiles = new List<AppFile>();

                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    if (fileInfo.Extension == ".pdb")
                        continue;

                    AppFile appFile = new AppFile
                    {
                        Name = fileInfo.Name,
                        Location = file.Replace(_appInfo.DirectoryLocation, ""),
                        Extension = fileInfo.Extension.Replace(".", ""),
                        Hash = Hasher.HashFile(file, HashType.MD5)
                    };

                    appFiles.Add(appFile);
                }

                return appFiles;
            }

            return null;
        }

        private async Task<List<AppFile>> LoadFilesAsync()
        {
            return await Task.Run(LoadFiles);
        }

        private async void SaveData()
        {
            AppVersion version = new AppVersion { Version = _appInfo.CurrentVersion, Files = _files };
            _appInfo.Versions = new List<AppVersion> { version };

            using (DiffPatherContext db = new DiffPatherContext())
            {
                await db.AddAsync(_appInfo);
                await db.SaveChangesAsync();
            }
        }

        #endregion

        #region Form Event

        private async void AddAppForm_Load(object sender, EventArgs e)
        {
            _files = await LoadFilesAsync();
            BindingData();
            appFileBindingSource.DataSource = null;
            appFileBindingSource.DataSource = _files;
        }

        private void AddAppForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnAdd.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private void AddAppForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddAppForm_SizeChanged(object sender, EventArgs e)
        {
            //tbFilter.Refresh();
        }

        #endregion

        #region DataGridView Event

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var grid = (DataGridView)sender;
            var sortIconColor = Color.Gray;

            //if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            //{
            //    bool value = (bool)e.FormattedValue;
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
            //    Bitmap img = value ? Properties.Resources.gray_checked_32 : Properties.Resources.gray_unchecked_32;
            //    Size size = img.Size;
            //    Point loc = new Point((e.CellBounds.Width - size.Width) / 2, (e.CellBounds.Height - size.Height) / 2);
            //    loc.Offset(e.CellBounds.Location);
            //    e.Graphics.DrawImage(img, loc);
            //    e.Handled = true;
            //}

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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex >= 0)
            //{
            //    Firm firm = GetFirmByRowIndex(e.RowIndex);

            //    if (firm != null)
            //    {
            //        firm.Check = !firm.Check;
            //        UpdateDeleteButton();
            //    }
            //}
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            //{
            //    Firm firm = GetFirmByRowIndex(e.RowIndex);

            //    if (firm != null)
            //    {
            //        firm.Check = !firm.Check;
            //        UpdateDeleteButton();
            //    }
            //}
        }

        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            //{
            //    dataGridView.EndEdit();
            //}
        }

        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index)
            //{
            //    CheckReverse();
            //    dataGridView.EndEdit();
            //}
        }

        #endregion

        #region TextBox Event

        private void tbFilter_Enter(object sender, EventArgs e)
        {
            WcApi.Keyboard.Keyboard.SetRussianLanguage();
        }

        #endregion

        #region ContextMenu Event

        private void checkAllMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Firm firm in _firms)
            //{
            //    firm.Check = true;
            //}

            //UpdateDeleteButton();
            //UpdateData();
        }

        private void uncheckAllMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Firm firm in _firms)
            //{
            //    firm.Check = false;
            //}

            //UpdateDeleteButton();
            //UpdateData();
        }

        #endregion

        #region Button Event

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SaveData();
            Close();
        }

        #endregion
    }
}
