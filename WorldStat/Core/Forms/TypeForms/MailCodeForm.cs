using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldStat.Core.Database.Contexts;
using WorldStat.Core.Database.Models;

namespace WorldStat.Core.Forms.TypeForms
{
    public partial class MailCodeForm : Form
    {
        private List<MailCode> _mailCodes;

        public MailCodeForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Коды отправлений";

            // Хук двойной буфферизации для таблицы
            Wc32Api.DrawingControl.SetDoubleBuffered(dataGridView);

            InitTable();


            mailCategoryBindingSource.DataSource = null;
            mailCategoryBindingSource.DataSource = LoadMailCategories();
            mailTypeBindingSource.DataSource = LoadMailTypes();



            _mailCodes = LoadData();

            UpdateData();
        }

        private void InitTable()
        {
            //enableDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //enableDataGridViewCheckBoxColumn.Width = 40;

            //codeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //codeDataGridViewTextBoxColumn.Width = 60;

            //nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //shortNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //shortNameDataGridViewTextBoxColumn.Width = 260;
        }

        private List<MailCode> LoadData()
        {
            using (WorldStatContext db = new WorldStatContext())
            {
                return db.MailCodes.OrderBy(c => c.Code).ToList();
            }
        }

        private List<MailType> LoadMailTypes()
        {
            using (WorldStatContext db = new WorldStatContext())
            {
                return db.MailTypes.ToList();
            }
        }

        private List<MailCategory> LoadMailCategories()
        {
            using (WorldStatContext db = new WorldStatContext())
            {
                return db.MailCategories.ToList();
            }
        }

        private void SaveData()
        {
            //await Task.Run(() =>
            //{
            //    using (WorldStatContext db = new WorldStatContext())
            //    {
            //        db.UpdateRange(_mailTypes);
            //        db.SaveChanges();
            //    }
            //});
        }

        private MailCode GetMailCodeByRowIndex(int rowIndex)
        {
            try
            {
                List<MailCode> mailCodes = (List<MailCode>)mailCodeBindingSource.DataSource;

                if (mailCodes != null && mailCodes.Count > 0)
                {
                    MailCode mailCode = mailCodes[rowIndex];
                    return mailCode;
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        private void UpdateData()
        {
            mailCodeBindingSource.DataSource = null;
            mailCodeBindingSource.DataSource = _mailCodes;
            lblCount.Text = $"{_mailCodes.Count} шт";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _mailCodes = LoadData();
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

        private void MailTypeForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CheckDataGridViewCheckBoxColumn.Index && e.RowIndex >= 0)
            {
                MailCode mailCode = GetMailCodeByRowIndex(e.RowIndex);

                if (mailCode != null)
                    mailCode.Check = !mailCode.Check;
            }
        }

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == CheckDataGridViewCheckBoxColumn.Index && e.RowIndex >= 0)
            {
                bool value = (bool)e.FormattedValue;
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
                Bitmap img = value ? Properties.Resources.checked_32 : Properties.Resources.unchecked_32;
                Size size = img.Size;
                Point loc = new Point((e.CellBounds.Width - size.Width) / 2, (e.CellBounds.Height - size.Height) / 2);
                loc.Offset(e.CellBounds.Location);
                e.Graphics.DrawImage(img, loc);
                e.Handled = true;
            }
        }

        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == CheckDataGridViewCheckBoxColumn.Index && e.RowIndex != -1)
            {
                dataGridView.EndEdit();
            }
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (MailCode mailCode in _mailCodes)
            {
                mailCode.Check = true;
            }

            UpdateData();
        }

        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (MailCode mailCode in _mailCodes)
            {
                mailCode.Check = false;
            }

            UpdateData();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string q = tbFilter.Text.ToUpper();

            if (!string.IsNullOrEmpty(q))
            {
                List<MailCode> filtered = _mailCodes.Where(m => m.Name.ToUpper().Contains(q) || m.Code.ToString().Contains(q)).ToList();
                mailCodeBindingSource.DataSource = filtered;
                lblCount.Text = $"{filtered.Count} шт";
            }
            else
            {
                mailCodeBindingSource.DataSource = _mailCodes;
                lblCount.Text = $"{_mailCodes.Count} шт";
            }
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        private void tbFilter_Enter(object sender, EventArgs e)
        {
            WcApi.Keyboard.Keyboard.SetRussianLanguage();
        }
    }
}
