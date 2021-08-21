using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldStat.Core.Database.Contexts;
using WorldStat.Core.Database.Models;

namespace WorldStat.Core.Forms.DataForms
{
    public partial class FirmsForm : Form
    {
        private List<Firm> _firms;

        public FirmsForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Организации";

            // Хук двойной буфферизации для таблицы
            Wc32Api.DrawingControl.SetDoubleBuffered(dataGridView);

            InitTable();

            _firms = LoadData();
            UpdateData();
        }

        private void InitTable()
        {
            checkDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            checkDataGridViewCheckBoxColumn.Width = 40;
            checkDataGridViewCheckBoxColumn.CellTemplate.Style.BackColor = Color.FromArgb(53, 56, 58);
            checkDataGridViewCheckBoxColumn.CellTemplate.Style.SelectionBackColor = Color.FromArgb(53, 56, 58);

            shortNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            shortNameDataGridViewTextBoxColumn.Width = 320;

            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            codeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            codeDataGridViewTextBoxColumn.Width = 100;

            docDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            docDataGridViewTextBoxColumn.Width = 220;
        }

        private List<Firm> LoadData()
        {
            using (WorldStatContext db = new WorldStatContext())
            {
                return db.Firms.OrderBy(f => f.ShortName).ToList();
            }
        }

        private async void SaveData()
        {
            using (WorldStatContext db = new WorldStatContext())
            {
                db.UpdateRange(_firms);
                await db.SaveChangesAsync();
            }
        }

        private void UpdateData()
        {
            firmBindingSource.DataSource = null;
            firmBindingSource.DataSource = _firms;
            lblCount.Text = $"{_firms.Count} шт";
        }

        private Firm GetFirmByRowIndex(int rowIndex)
        {
            List<Firm> firms = (List<Firm>)firmBindingSource.DataSource;

            try
            {
                if (firms != null && firms.Count > 0)
                {
                    Firm firm = firms[rowIndex];
                    return firm;
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        private void CheckReverse()
        {
            foreach (Firm firm in _firms)
            {
                firm.Check = !firm.Check;
            }

            UpdateDeleteButton();
            UpdateData();
        }

        private void UpdateDeleteButton()
        {
            int check = _firms.Count(f => f.Check);
            btnDelete.Enabled = check > 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _firms = LoadData();
            UpdateData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FirmsForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string q = tbFilter.Text.ToUpper();

            if (!string.IsNullOrEmpty(q))
            {
                List<Firm> filtered = _firms.Where(f => f.Name.Contains(q) || f.ShortName.Contains(q) || f.Doc.Contains(q) || f.Code.Contains(q)).ToList();
                firmBindingSource.DataSource = filtered;
                lblCount.Text = $"{filtered.Count} шт";
            }
            else
            {
                firmBindingSource.DataSource = _firms;
                lblCount.Text = $"{_firms.Count} шт";
            }
        }

        private void FirmsForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FirmsForm_SizeChanged(object sender, EventArgs e)
        {
            tbFilter.Refresh();
        }

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var grid = (DataGridView)sender;
            var sortIconColor = Color.Gray;

            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex >= 0)
            {
                Firm firm = GetFirmByRowIndex(e.RowIndex);

                if (firm != null)
                {
                    firm.Check = !firm.Check;
                    UpdateDeleteButton();
                }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            {
                Firm firm = GetFirmByRowIndex(e.RowIndex);

                if (firm != null)
                {
                    firm.Check = !firm.Check;
                    UpdateDeleteButton();
                }
            }
        }

        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            {
                dataGridView.EndEdit();
            }
        }

        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == checkDataGridViewCheckBoxColumn.Index)
            {
                CheckReverse();
                dataGridView.EndEdit();
            }
        }

        private void checkAllMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Firm firm in _firms)
            {
                firm.Check = true;
            }

            UpdateDeleteButton();
            UpdateData();
        }

        private void uncheckAllMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Firm firm in _firms)
            {
                firm.Check = false;
            }

            UpdateDeleteButton();
            UpdateData();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            List<Firm> deletefirms = new List<Firm>();

            List<Firm> firms = (List<Firm>)firmBindingSource.DataSource;

            foreach (Firm firm in firms)
            {
                if (firm.Check)
                    deletefirms.Add(firm);
            }

            if (deletefirms.Count == 0)
                return;

            if (MessageBox.Show($"Вы уверены, что хотите удалить {deletefirms.Count} Организаций и все их списки?",
                $"Удаление организаций: {deletefirms.Count} шт.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (WorldStatContext db = new WorldStatContext())
                {
                    db.RemoveRange(deletefirms);
                    await db.SaveChangesAsync();
                }

                lblFilter.Text = "";
                _firms = LoadData();

                UpdateDeleteButton();
                UpdateData();
            }
        }

        private void tbFilter_Enter(object sender, EventArgs e)
        {
            WcApi.Keyboard.Keyboard.SetRussianLanguage();
        }
    }
}
