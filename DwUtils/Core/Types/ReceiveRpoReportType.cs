using System.Collections.Generic;
using DwUtils.Core.Database.Requests.Types;

namespace DwUtils.Core.Types
{
    public class ReceiveRpoReportType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ReceiveRpoRequestType Type { get; set; }

        public static List<ReceiveRpoReportType> GetReceiveRpoReportTypes()
        {
            return new List<ReceiveRpoReportType>
            {
                new ReceiveRpoReportType { Id = 1, Name = "Общий", Type = ReceiveRpoRequestType.Общий },
                new ReceiveRpoReportType { Id = 2, Name = "По операторам", Type = ReceiveRpoRequestType.ПоОператорам },
                new ReceiveRpoReportType { Id = 3, Name = "По часам", Type = ReceiveRpoRequestType.ПоЧасам },
            };
        }
    }
}
