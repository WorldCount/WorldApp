
namespace DwUtils.Core.Database.Models
{
    public class ReceivedRpo
    {
        public string ClientName { get; set; }
        public int AllCount { get; set; }
        public int ReceivedCount { get; set; }
        public int ReturnCount { get; set; }
        public double ReturnPay { get; set; }

        public override string ToString()
        {
            return $"{ClientName} [{AllCount}]";
        }
    }
}
