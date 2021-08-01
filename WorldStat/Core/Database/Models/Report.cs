using System;
using System.Collections.Generic;
using WorldStat.Core.Types;

namespace WorldStat.Core.Database.Models
{
    public class Report
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int Count { get; set; }
        public double Pay { get; set; }

        public CalendarType Type { get; set; } = CalendarType.Все;

        public string DayName { get => Date.ToString("ddd");}

        public List<ReportPos> ReportPoses { get; set; } = new List<ReportPos>();
    }
}
