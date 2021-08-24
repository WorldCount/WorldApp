using WhoseIsBarcode.Core.Database.Models;

namespace WhoseIsBarcode.Core.Database.Requests
{
    public class RangeRequest
    {
        public int RangeId { get; set; }
        public DbFirm Firm { get; set; }
        public int Limit { get; set; }
    }
}
