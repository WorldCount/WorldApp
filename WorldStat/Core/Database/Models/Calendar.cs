using System;
using WorldStat.Core.Types;

namespace WorldStat.Core.Database.Models
{
    public class Calendar
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public CalendarType Type { get; set; }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} - {Type}";
        }
    }
}
