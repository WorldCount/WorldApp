
namespace DwUtils.Core.Database.Models
{
    public class ReceivedRpo
    {
        public string ClientName { get; set; }
        public int AllCount { get; set; }
        public int ReceivedCount { get; set; }
        public int ReturnCount { get; set; }
        public int DocumentCount { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Hour { get; set; }
        public double ReturnPay { get; set; }

        public string AllCountName => AllCount == 0 ? "-" : AllCount.ToString();
        public string ReceivedCountName => ReceivedCount == 0 ? "-" : ReceivedCount.ToString();
        public string ReturnCountName => ReturnCount == 0 ? "-" : ReturnCount.ToString();
        public string DocumentCountName => DocumentCount == 8 ? "-" : DocumentCount.ToString();
        // ReSharper disable once CompareOfFloatsByEqualityOperator
        public string ReturnPayName => ReturnPay == 0 ? "-" : ReturnPay.ToString("F");

        public override string ToString()
        {
            return $"{ClientName} [{AllCount}]";
        }
    }
}
