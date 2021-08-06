using System.ComponentModel.DataAnnotations.Schema;
using WcPostApi.Types;

namespace WorldStat.Core.Database.Models
{
    public class MailCode
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public long MailType { get; set; } = 0;
        public long MailCategory { get; set; } = 0;

        [NotMapped]
        public virtual bool Check { get; set; } = false;

        public TransCategory TransCategory { get; set; } = TransCategory.Внутренняя;
        public TransType TransType { get; set; } = TransType.Назем;
        public int PostMark { get; set; } = 0;

        public MailCode() { }

        public MailCode(int code, string name)
        {
            Parse(code, name);
        }

        public void Parse(int code, string name)
        {
            Name = name;
            Code = code;

            name = name.ToUpper();

            if (name.Contains("ПИС"))
                MailType = 2;

            else if (name.Contains("БАНД"))
                MailType = 3;
            else if (name.Contains("1КЛ П"))
                MailType = 15;

            else if (name.Contains("1КЛ Б"))
                MailType = 16;

            else if (name.Contains("МЕЖД Б"))
            {
                MailType = 3;
                TransCategory = TransCategory.Международная;
            }

            else if (name.Contains("УВЕД"))
            {
                MailType = 2;
                PostMark = 2;
            }

            

            if (name.Contains("ПР"))
                MailCategory = 0;
            else if (name.Contains("ЗКЗ"))
                MailCategory = 1;

            if (name.Contains("МЕЖД"))
                TransCategory = TransCategory.Международная;

            if (name.Contains("НАЗ"))
                TransType = TransType.Назем;
            else if (name.Contains("ВОЗД"))
                TransType = TransType.Авиа;

            if (name.Contains("Д2Т2"))
                TransType = TransType.До2000Км;
            else if (name.Contains("С2Т2"))
                TransType = TransType.Свыше2000Км;

            if (name.Contains("УВ"))
                PostMark = 2;

        }


    }
}
