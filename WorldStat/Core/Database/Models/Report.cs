using System;
using System.Collections.Generic;

namespace WorldStat.Core.Database.Models
{
    public class Report
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int Count { get; set; }
        public double Pay { get; set; }

        public List<ReportPos> ReportPoses { get; set; } = new List<ReportPos>();
    }
}
