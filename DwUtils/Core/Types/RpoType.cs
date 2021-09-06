using System.Collections.Generic;

namespace DwUtils.Core.Types
{
    public class RpoType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public static List<RpoType> GetRpoTypes()
        {
            return new List<RpoType>
            {
                new RpoType { Id = 0, Name = "ВСЕ"},
                new RpoType { Id = 1, Name = "Внут"},
                new RpoType { Id = 2, Name = "Мжд"},
            };
        }
    }
}
