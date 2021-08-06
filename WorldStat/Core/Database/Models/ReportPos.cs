using System;
using WcPostApi.Types;

namespace WorldStat.Core.Database.Models
{
    public class ReportPos
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }

        public int Count { get; set; }

        public long MailType { get; set; }
        public long MailCategory { get; set; }

        public TransCategory TransCategory { get; set; } = TransCategory.Внутренняя;
        public TransType TransType { get; set; } = TransType.Нет;

        public double Pay { get; set; }

        public int ReportId { get; set; }
        public Report Report { get; set; }

        public int FirmId { get; set; }
        public Firm Firm { get; set; }

        public void ParseMailType(MailCode mailCode)
        {
            MailType = mailCode.MailType;
            MailCategory = mailCode.MailCategory;
            TransCategory = mailCode.TransCategory;
            TransType = mailCode.TransType;
        }

    }
}
