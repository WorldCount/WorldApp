using System;

namespace DwUtils.Core.Database.Requests
{
    public class ReceivedRpoRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int UserId { get; set; } = 0;
    }
}
