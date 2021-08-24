
namespace WhoseIsBarcode.Core.Database.Response
{
    public class RangeData
    {
        public int Count { get; set; }
        public int FreeCount { get; set; }
        public int BusyCount { get; set; }
        public string Month { get; set; }
        public string Seria { get; set; }
        public string FirstNum { get; set; }
        public string LastNum { get; set; }
    }
}
