using System;

namespace DwUtils.Core.Database.Requests
{
    public class FreeRpoResponse
    {
        public int UserId { get; set; } = 0;
        public int TypeId { get; set; } = 0;
        public int PlaceId { get; set; } = 0;

        public bool FilterDate { get; set; } = false;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
