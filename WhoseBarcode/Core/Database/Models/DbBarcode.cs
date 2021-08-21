using System;

namespace WhoseBarcode.Core.Database.Models
{
    public class DbBarcode
    {
        public DateTime Date { get; set; }

        public string Barcode { get; set; }
        public int Month { get; set; }
        public int Seria { get; set; }
        public string Num { get; set; }

        public int RangeId { get; set; }
        
        public string FirmName { get; set; }
        public string FirmInn { get; set; }
        public string FirmDepcode { get; set; }
        public string FirmKpp { get; set; }

        public int StateId { get; set; }
        public string State { get; set; }
    }
}
