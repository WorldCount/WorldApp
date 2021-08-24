using System;
using WhoseIsBarcode.Core.Database.Queryes;
using WhoseIsBarcode.Core.Database.Response;

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

        public int Count { get; private set; }
        public int FreeCount { get; private set; }
        public int BusyCount { get; private set; }

        public string ExtName => IsExternal ? "МЖД" : "Внут";

        public void SetData(RangeData data)
        {
            if (data != null)
            {
                Month = data.Month;
                Seria = data.Seria;
                FirstNum = data.FirstNum;
                LastNum = data.LastNum;
                Count = data.Count;
                FreeCount = data.FreeCount;
                BusyCount = data.BusyCount;
            }
        }
    }
}
