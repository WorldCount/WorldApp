
namespace WorldStat.Core.Database.Models
{
    public class Notice
    {
        public int Id { get; set; }

        public long Code { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public bool Enable { get; set; }

        public Notice() { }

        public Notice(WcPostApi.Types.PostTypes.Notice notice)
        {
            Code = notice.Code;
            Name = notice.Name;
            ShortName = notice.ShortName;
            Enable = notice.Enable;
        }

        public override string ToString()
        {
            return $"Notice: {ShortName}";
        }
    }
}
