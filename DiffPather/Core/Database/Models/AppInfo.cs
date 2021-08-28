using System;
using System.Collections.Generic;

namespace DiffPather.Core.Database.Models
{
    public class AppInfo
    {
        public int Id { get; set; }
        public string DirectoryLocation { get; set; }
        public string CurrentVersion { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<AppVersion> Versions { get; set; }
    }
}
