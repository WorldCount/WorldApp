using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using WorldStat.Core.Database.Contexts;
using WorldStat.Core.Database.Models;
using WorldStat.Core.Parsers;
using WorldStat.Core.Parsers.Models;


namespace WorldStat.Core.Forms
{
    public partial class LoadReportForm : Form
    {

        #region Private Fields

        private List<string> _reports;
        private int _reportCount;

        

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


        public LoadReportForm(string[] reports)
        {
            InitializeComponent();

            _reports = reports.ToList();
            _reports.Sort();

            _reportCount = _reports.Count;

            labelDate.Text = $"Парсинг отчетов: 0 из {_reportCount}";
            //labelInfo.Text = "";
            SetInfo("", 0, _reportCount);
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
                int i = 0;
                foreach (string report in _reports)
                {
                    i++;

                    labelDate.Text = $"Парсинг отчетов: {i} из {_reportCount}";
                    FileInfo fi = new FileInfo(report);
                    SetInfo(fi.Name, i, _reportCount);

                    await ParseReportAsync(report, db);
                }
            }

            Close();
        }

        private async Task ParseReportAsync(string path, WorldStatContext db)
        {
            await Task.Run(() =>
            {
                ParseReport(path, db);
            });
        }

        private void ParseReport(string path, WorldStatContext db)
        {
            FrankHierarchyReportParser parser = new FrankHierarchyReportParser(path);
            parser.Parse();

            if (parser.IsValid())
            {

                Report report = db.Reports.FirstOrDefault(r => r.Date == parser.ReportDate);
                if (report != null)
                {
                    db.Remove(report);
                }

                report = new Report{ Date = parser.ReportDate, Count = parser.MailCount, Pay = parser.MailPay };
                db.Add(report);


                foreach (var code in parser.GetKeys())
                {
                    if (db.MailCodes.FirstOrDefault(m => m.Code == code.Key) == null)
                    {
                        MailCode mailCode = new MailCode(code.Key, code.Value);
                        db.Add(mailCode);
                    }
                        
                }
                db.SaveChanges();

                List<ReportPos> reportPoses = new List<ReportPos>();

                foreach (HierarchyFrankReport frankReport in parser.GetReports())
                {
                    Firm firm = db.Firms.FirstOrDefault(f => f.Code == frankReport.FirmCode);
                    if (firm == null)
                    {
                        firm = new Firm
                        {
                            Code = frankReport.FirmCode,
                            Doc = frankReport.Doc,
                            Name = frankReport.Name,
                            ShortName = frankReport.Name
                        };

                        db.Add(firm);
                        db.SaveChanges();
                    }

                    foreach (var pos in frankReport.GetAllPositions())
                    {
                        MailCode mailCode = db.MailCodes.FirstOrDefault(m => m.Code == pos.Key);
                        if(mailCode == null)
                            continue;

                        ReportPos reportPos = new ReportPos
                        {
                            Report = report,
                            Firm = firm,
                            Date = report.Date,
                            Count = pos.Value.Count,
                            Pay = pos.Value.PaySum
                        };

                        reportPos.ParseMailType(mailCode);

                        reportPoses.Add(reportPos);
                    }
                }

                db.AddRange(reportPoses);
                db.SaveChanges();
            }

            parser = null;
        }

        private List<MailCode> ParseMailCodes(SortedDictionary<int, string> data)
        {
            List<MailCode> mailCodes = new List<MailCode>();

            foreach (var code in data)
            {
                MailCode mailCode = new MailCode();
                mailCode.Parse(code.Key, code.Value);
                mailCodes.Add(mailCode);
            }

            return mailCodes;
        }

        private void LoadReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _reports = null;
            GC.Collect();
        }
    }
}
