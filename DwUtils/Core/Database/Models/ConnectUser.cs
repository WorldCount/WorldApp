using System;

namespace DwUtils.Core.Database.Models
{
    public class ConnectUser
    {
        public int Id { get; set; } = 0;
        public bool Check { get; set; }
        public int UserId { get; set; }
        public int PlaceId { get; set; }
        public DateTime ConnectDate { get; set; }
        public DateTime WorkDate { get; set; }
        public string UserName { get; set; }
        public string PlaceName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsValid { get; set; }

        public override string ToString()
        {
            return $"{UserName} [{PlaceName}]";
        }

        public string AdminStatus => IsAdmin ? "ДА" : "НЕТ";
    }
}
