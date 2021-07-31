using System.Collections.Generic;

namespace WorldStat.Core.Database.Models
{
    public class Firm
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Doc { get; set; }

        public List<ReportPos> ReportPoses { get; set; } = new List<ReportPos>();
    }
}
