
using System;

namespace WorldStat.Core.Reports.Models
{
    public class DispathReport
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public double Pay { get; set; }
        public bool IsVoid { get; set; }
        public bool IsHeader { get; set; }
        public bool IsSubheader { get; set; }

        public string CountText
        {
            get
            {
                if (IsVoid && Count == 0)
                    return "";

                return Count.ToString("### ###");
            }
        }

        public string PayText
        {
            get
            {
                if (IsVoid && Pay == 0)
                    return "";

                return Pay.ToString("C");
            }
        }
    }
}
