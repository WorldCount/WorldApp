using System;

namespace DwUtils.Core.Database.Models
{
    public class RpoFile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int Count { get; set; }

        public string DayName => WcApi.Date.DateUtils.GetDayName(Date);
        public string DateName => Date.ToString("dd.MM.yyyy HH:mm:ss");

        public override string ToString()
        {
            return Name;
        }
    }
}
