
namespace WorldStat.Core.Database.Models
{
    public class MailCategory
    {
        public int Id { get; set; }

        public long Code { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public bool Enable { get; set; }

        public MailCategory() { }

        public MailCategory(WcPostApi.Types.PostTypes.MailCategory category)
        {
            Code = category.Code;
            Name = category.Name;
            ShortName = category.ShortName;
            Enable = category.Enable;
        }
    }
}
