using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiffPather.Core.Database;
using NLog;
using DiffPather.Core.Database.Contexts;
using DiffPather.Core.Database.Models;
using DiffPather.Core.Storage;


namespace DiffPather.Core.Forms
{
    public partial class CreateDbForm : Form
    {

        #region Private Fields

        private int _count;

        private string _error;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly bool _loggingMode = Properties.Settings.Default.LoggingMode;

        private readonly Color _windowBorderColor = Color.FromArgb(57, 57, 57);
        public int WindowBorderWidth { get; set; } = 2;
        public ButtonBorderStyle WindowsBorderStyle { get; set; } = ButtonBorderStyle.Dashed;

        #endregion

        #region Properties

        public string Error => _error;

        #endregion


        public CreateDbForm()
        {
            InitializeComponent();

            labelDate.Text = $"Создаю новую БД";

            SetInfo("", 0, _count);
        }

        #region Overriddes Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                _windowBorderColor, WindowBorderWidth, WindowsBorderStyle,
                _windowBorderColor, WindowBorderWidth, WindowsBorderStyle,
                _windowBorderColor, WindowBorderWidth, WindowsBorderStyle,
                _windowBorderColor, WindowBorderWidth, WindowsBorderStyle);
        }

        #endregion

        private void LoadReportForm_Load(object sender, EventArgs e)
        {
            Work();
        }

        private void SetInfo(string text, int value, int max = 100)
        {
            labelInfo.Text = text;
            labelInfo.Refresh();

            coloredProgressBar.Maximum = max;
            coloredProgressBar.Value = value;
            coloredProgressBar.Refresh();
        }

        private async void Work()
        {
            if (File.Exists(PathManager.DatabasePath))
            {
                try
                {
                    _count = 4;

                    SetInfo("Удаляю старую БД", 1, _count);
                    await Task.Delay(100);
                    await Db.DeleteDbAsync();
                    SetInfo("Удаляю старую БД ... Ok", 2, _count);

                    SetInfo("Создаю новую БД", 3, _count);
                    await Task.Delay(100);
                    await Db.CreateDbAsync();
                    SetInfo("Создаю новую БД ... Ok", 4, _count);
                }
                catch (InvalidOperationException e)
                {
                    MessageBox.Show(e.Message, @"Ошибка создания БД", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    _error = e.Message;
                }
            }
            else
            {
                try
                {
                    _count = 2;

                    SetInfo("Создаю новую БД", 1, _count);
                    await Task.Delay(100);
                    await Db.CreateDbAsync();
                    SetInfo("Создаю новую БД ... Ok", 2, _count);
                }
                catch (InvalidOperationException e)
                {
                    MessageBox.Show(e.Message, @"Ошибка создания БД", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    _error = e.Message;
                }
            }

            Close();
        }

        private void LoadReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }
    }
}
