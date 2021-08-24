
using WhoseBarcode.Core.Database.Models;

namespace WhoseBarcode.Core.Database.Requests
{
    public class RangeRequest
    {
        public int RangeId { get; set; }
        public DbFirm Firm { get; set; }
    }
}
