using System;

namespace WhoseBarcode.Core.Database.Models
{
    public class DbRange
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool IsExternal { get; set; }

        public string Ops { get; set; }
        public int Month { get; set; }
        public int Seria { get; set; }
        

        public string FirmName { get; set; }
        public string FirmInn { get; set; }
        public string FirmDepcode { get; set; }
        public string FirmKpp { get; set; }

        public int Count { get; set; }
    }
}
