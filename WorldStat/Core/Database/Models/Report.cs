using System;
using System.Collections.Generic;

namespace WorldStat.Core.Database.Models
{
    public class Report
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public List<ReportPos> ReportPoses { get; set; } = new List<ReportPos>();
    }
}
