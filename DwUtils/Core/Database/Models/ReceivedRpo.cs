
namespace DwUtils.Core.Database.Models
{
    public class ReceivedRpo
    {
        public string ClientName { get; set; }
        public int AllCount { get; set; }
        public int ReceivedCount { get; set; }
        public int ReturnCount { get; set; }
        public double ReturnPay { get; set; }

        public string ReceivedCountName => ReceivedCount == 0 ? "-" : ReceivedCount.ToString();
        public string ReturnCountName => ReturnCount == 0 ? "-" : ReturnCount.ToString();
        public string ReturnPayName => ReturnPay == 0 ? "-" : ReturnPay.ToString("N");


        public override string ToString()
        {
            return $"{ClientName} [{AllCount}]";
        }
    }
}
