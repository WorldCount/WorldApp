using System;

namespace DwUtils.Core.Database.Requests
{
    public class RpoFileRequest
    {
        public int UserId { get; set; }

        public bool FilterDate { get; set; } = false;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int Limit { get; set; }
    }
}
