using System;

namespace WhoseIsBarcode.Core.Database.Models
{
    public class DbBarcode
    {
        public DateTime Date { get; set; }

        public string Barcode { get; set; }

        public string Ops { get; set; }
        public string Month { get; set; }
        public string Seria { get; set; }
        public string Num { get; set; }

        public int RangeId { get; set; }
        
        public string FirmName { get; set; }
        public string FirmInn { get; set; }
        public string FirmDepcode { get; set; }
        public string FirmKpp { get; set; }

        public int StateId { get; set; }
        public string State { get; set; }

        public string MonthName => string.IsNullOrEmpty(Month) ? "-" : Month;
        public string SeriaName => string.IsNullOrEmpty(Seria) ? Barcode.Substring(0, 2) : Seria;
    }
}
