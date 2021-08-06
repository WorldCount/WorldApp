
namespace WorldStat.Core.Database.Models
{
    public class MailType
    {
        public int Id { get; set; }

        public long Code { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public bool Enable { get; set; }

        public MailType() { }

        public MailType(WcPostApi.Types.PostTypes.MailType type)
        {
            Code = type.Code;
            Name = type.Name;
            ShortName = type.ShortName;
            Enable = type.Enable;
        }

        public override string ToString()
        {
            return $"MailType: {ShortName}";
        }
    }
}
