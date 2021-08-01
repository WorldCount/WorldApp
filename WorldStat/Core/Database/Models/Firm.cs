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

        public void ParseName(string name)
        {
            name = name.ToUpper().Replace("АО ", "").Replace("ООО ", "")
                .Replace("ММЗ ", "").Replace("РФ ", "").Replace("ГБОУ ", "")
                .Replace("ОБЩЕСТВО С ОГРАНИЧЕННОЙ ОТВЕТСТВЕННОСТЬЮ ", "").Replace("АКЦИОНЕРНОЕ ОБЩЕСТВО ", "")
                .Replace("ФГБУ ", "").Replace("ФГУП ", "").Replace("ГБУ ", "")
                .Replace("ЗАО ", "").Replace("ПАО ", "").Replace("ФКУ ", "")
                .Replace("\"", "").Replace("«", "").Replace("»", "").Replace("ФГОБУ ВО ", "").Trim();

            Name = name;
            ShortName = name;
        }
    }
}
