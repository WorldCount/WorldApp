using System;

namespace WorldStat.Core.Database.Models
{
    public class ReportPos
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }

        public int Count { get; set; }

        public int MailType { get; set; }
        public int MailCategory { get; set; }

        public double Pay { get; set; }

        public int ReportId { get; set; }
        public Report Report { get; set; }

        public int FirmId { get; set; }
        public Firm Firm { get; set; }

    }
}
