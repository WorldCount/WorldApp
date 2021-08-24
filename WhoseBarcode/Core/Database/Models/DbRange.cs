using System;

namespace WhoseIsBarcode.Core.Database.Models
{
    public class DbRange
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool IsExternal { get; set; }

        public string Ops { get; set; }
        public string Month { get; set; }
        public string Seria { get; set; }
        public string FirstNum { get; set; }
        public string LastNum { get; set; }

        public string FirmName { get; set; }
        public string FirmInn { get; set; }
        public string FirmDepcode { get; set; }
        public string FirmKpp { get; set; }

        public int Count { get; set; }
        public int FreeCount { get; set; }
        public int BusyCount { get; set; }

        public string ExtName => IsExternal ? "МЖД" : "Внут";
    }
}
