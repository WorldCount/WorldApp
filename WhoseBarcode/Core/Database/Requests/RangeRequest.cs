using System;
using WhoseIsBarcode.Core.Database.Models;

namespace WhoseIsBarcode.Core.Database.Requests
{
    public class RangeRequest
    {
        public int RangeId { get; set; }
        public DbFirm Firm { get; set; }
        public int Limit { get; set; }

        public bool ByDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public char External { get; set; } = 'A';
    }
}
