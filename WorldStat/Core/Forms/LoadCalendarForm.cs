using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Infrastructure;
using WorldStat.Core.Database.Contexts;
using WorldStat.Core.Database.Models;
using WorldStat.Core.Types;

namespace WorldStat.Core.Forms
{
    public partial class LoadCalendarForm : Form
    {
        #region Private Fields

        private readonly List<Calendar> _calendars;
        private readonly Color _foreColor = Color.White;
        private readonly Color _backWorkColor = Color.FromArgb(165, 42, 42);
        private readonly Color _backAllWorkColor = Color.FromArgb(99, 37, 35);
        private readonly Color _backNotWorkColor = Color.FromArgb(60, 60, 60);

        #endregion



        public LoadCalendarForm(List<Calendar> calendars)
        {
            InitializeComponent();

            _calendars = calendars;

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Импорт календаря";

            // Хук двойной буфферизации для таблицы
            Wc32Api.DrawingControl.SetDoubleBuffered(dataGridView);

            UpdateData();
        }

        private void SaveData()
        {
            using (WorldStatContext db = new WorldStatContext())
            {
                foreach (Calendar newCalendar in _calendars)
                {
                    Calendar calendar = db.Calendars.FirstOrDefault(c => c.Date == newCalendar.Date);
                    if (calendar != null)
                        db.Remove(calendar);
                }
                
                db.AddRange(_calendars);
                db.SaveChanges();
            }
        }

        private void UpdateData()
        {
            calendarBindingSource.DataSource = null;
            calendarBindingSource.DataSource = _calendars;
            lblCount.Text = $"{_calendars.Count} шт";
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

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                //DataGridView dgv = sender as DataGridView;
                //Calendar calendar = dgv.Rows[e.RowIndex].DataBoundItem as Calendar;
                CalendarType type = (CalendarType) dataGridView.Rows[e.RowIndex].Cells[1].Value;

                if (type == CalendarType.Геля)
                {
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = _backWorkColor;
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = _foreColor;
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = _backWorkColor;
                }

                if (type == CalendarType.Лева)
                {
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = _backNotWorkColor;
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = _foreColor;
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = _backNotWorkColor;
                }

                if (type == CalendarType.Общая)
                {
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = _backAllWorkColor;
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = _foreColor;
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = _backAllWorkColor;
                }
            }
        }
    }
}
