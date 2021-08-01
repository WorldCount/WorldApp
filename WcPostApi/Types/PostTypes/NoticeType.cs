using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using WcPostApi.Types.PostTypes.Interface;

namespace WcPostApi.Types.PostTypes
{
    public enum NoticeType
    {
        Простое,
        Заказное,
        Международное,
        Электронное
    }

    public class Notice : IPostType
    {
        [DisplayName(@"Code")]
        public long Code { get; set; }

        [DisplayName(@"Вкл")]
        public bool Enable { get; set; } = true;

        [DisplayName(@"Название")]
        public string Name { get; set; }

        [DisplayName(@"Сокращение")]
        public string ShortName { get; set; }

        public Notice() { }

        public Notice(long code, string name, bool enable = true)
        {
            Code = code;
            Name = name;
            ShortName = name;
            Enable = enable;
        }

        public Notice(long code, string name, string shortName, bool enable = true)
        {
            Code = code;
            Name = name;
            ShortName = shortName;
            Enable = enable;
        }
    }

    public static class Notices
    {
        // ReSharper disable once InconsistentNaming
        private static readonly List<Notice> _n;

        static Notices()
        {
            _n = new List<Notice>
            {
                new Notice { Code = 0, Name = "Без отметки", ShortName = "Нет" },
                new Notice { Code = 1, Name = "Простое уведомление", ShortName = "Пр.Ув" },
                new Notice { Code = 2, Name = "Заказное уведомление", ShortName = "Зак.Ув" },
                new Notice { Code = 16384, Name = "Электронное уведомление", ShortName = "Эл.Ув" },
            };
        }

        public static Notice GetByCode(long code) => _n.FirstOrDefault(s => s.Code == code);
        public static Notice GetByName(string name) => _n.FirstOrDefault(s => s.Name.ToUpper() == name.ToUpper());
        public static List<Notice> GetAll() => _n;
    }
}
