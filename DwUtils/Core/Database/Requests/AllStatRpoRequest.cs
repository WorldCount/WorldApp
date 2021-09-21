using System;
using System.Collections.Generic;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Requests.Types;

namespace DwUtils.Core.Database.Requests
{
    public class AllStatRpoRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int UserId { get; set; } = 0;

        public ReceiveRpoRequestType Type { get; set; } = ReceiveRpoRequestType.Общий;

        public List<User> Users = new List<User>();
    }
}
