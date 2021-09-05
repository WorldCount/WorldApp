using System;

namespace DwUtils.Core.Database.Models
{
    public class FreeRpo
    {
        public int Id { get; set; }
        public bool Check { get; set; } = true;
        public int Type { get; set; }
        public int TypeCategory { get; set; }
        public string Barcode { get; set; }
        public string IndexTo { get; set; }
        public DateTime LoadDate { get; set; }
        public int PlaceId { get; set; }
        public int UserId { get; set; }
    }
}
