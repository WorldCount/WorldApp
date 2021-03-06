using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using WorldStat.Core.Database.Contexts;
using WorldStat.Core.Database.Models;
using WorldStat.Core.Storage;


namespace WorldStat.Core.Forms
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
            using (WorldStatContext db = new WorldStatContext())
            {

                if (File.Exists(PathManager.DatabasePath))
                {
                    try
                    {
                        _count = 20;

                        SetInfo("Сохраняю данные по организациям", 1, _count);
                        List<Firm> firms = await ExportFirms(db);
                        SetInfo("Сохраняю данные по организациям ... Ok", 2, _count);

                        SetInfo("Сохраняю данные по календарю", 3, _count);
                        List<Calendar> calendars = await ExportCalendars(db);
                        SetInfo("Сохраняю данные по календарю ... Ok", 4, _count);

                        SetInfo("Удаляю старую БД", 5, _count);
                        await db.Database.EnsureDeletedAsync();
                        SetInfo("Удаляю старую БД ... Ok", 6, _count);

                        SetInfo("Создаю новую БД", 7, _count);
                        await db.Database.EnsureCreatedAsync();
                        SetInfo("Создаю новую БД ... Ok", 8, _count);

                        SetInfo("Добавляю данные по организациям", 9, _count);
                        await ImportFirms(firms, db);
                        SetInfo("Добавляю данные по организациям ... Ok", 10, _count);

                        SetInfo("Добавляю данные по календарю", 11, _count);
                        await ImportCalendars(calendars, db);
                        SetInfo("Добавляю данные по календарю ... Ok", 12, _count);

                        SetInfo("Добавляю данные по категориям", 13, _count);
                        await InserMailCategory(db);
                        SetInfo("Добавляю данные по категориям ... Ok", 14, _count);

                        SetInfo("Добавляю данные по типам", 15, _count);
                        await InserMailType(db);
                        SetInfo("Добавляю данные по типам ... Ok", 16, _count);

                        SetInfo("Добавляю данные по уведомлениям", 17, _count);
                        await InsertNotice(db);
                        SetInfo("Добавляю данные по уведомлениям ... Ok", 18, _count);

                        SetInfo("Сохраняю данные", 19, _count);
                        db.SaveChanges();
                        SetInfo("Сохраняю данные ... Ok", 20, _count);

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
                        _count = 10;

                        SetInfo("Создаю новую БД", 1, _count);
                        await db.Database.EnsureCreatedAsync();
                        SetInfo("Создаю новую БД ... Ok", 2, _count);

                        SetInfo("Добавляю данные по категориям", 3, _count);
                        await InserMailCategory(db);
                        SetInfo("Добавляю данные по категориям ... Ok", 4, _count);

                        SetInfo("Добавляю данные по типам", 5, _count);
                        await InserMailType(db);
                        SetInfo("Добавляю данные по типам ... Ok", 6, _count);

                        SetInfo("Добавляю данные по уведомлениям", 7, _count);
                        await InsertNotice(db);
                        SetInfo("Добавляю данные по уведомлениям ... Ok", 8, _count);

                        SetInfo("Сохраняю данные", 9, _count);
                        db.SaveChanges();
                        SetInfo("Сохраняю данные ... Ok", 10, _count);

                    }
                    catch (InvalidOperationException e)
                    {
                        MessageBox.Show(e.Message, @"Ошибка создания БД", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        _error = e.Message;
                    }
                }

            }
            Close();
        }

        private async Task<List<Firm>> ExportFirms(WorldStatContext db)
        {
            List<Firm> firms = new List<Firm>();

            await Task.Run(() =>
            {
                firms = db.Firms.OrderBy(f => f.Code).ToList();
            });

            return firms;
        }

        private async Task<List<Calendar>> ExportCalendars(WorldStatContext db)
        {
            List<Calendar> calendars = new List<Calendar>();

            await Task.Run(() =>
            {
                calendars = db.Calendars.OrderBy(c => c.Date).ToList();
            });

            return calendars;
        }

        private async Task ImportFirms(List<Firm> firms, WorldStatContext db)
        {
            await Task.Run(() =>
            {
                db.AddRange(firms);
            });
        }

        private async Task ImportCalendars(List<Calendar> calendars, WorldStatContext db)
        {
            await Task.Run(() =>
            {
                db.AddRange(calendars);
            });
        }

        private async Task InserMailCategory(WorldStatContext db)
        {
            await Task.Run(() =>
            {
                foreach (var mailCategory in WcPostApi.Types.PostTypes.MailCategories.GetAll())
                {
                    db.Add(new MailCategory(mailCategory));
                }
            });
        }

        private async Task InserMailType(WorldStatContext db)
        {
            await Task.Run(() =>
            {
                foreach (var mailType in WcPostApi.Types.PostTypes.MailTypes.GetAll())
                {
                    db.Add(new MailType(mailType));
                }
            });
        }

        private async Task InsertNotice(WorldStatContext db)
        {
            await Task.Run(() =>
            {
                foreach (var notice in WcPostApi.Types.PostTypes.Notices.GetAll())
                {
                    db.Add(new Notice(notice));
                }
            });
        }

        private void LoadReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }
    }
}
