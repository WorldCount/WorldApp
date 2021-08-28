using System;
using System.Collections.Generic;

namespace DiffPather.Core.Database.Models
{
    public class AppVersion
    {
        public int Id { get; set; }
        public string Version { get; set; }

        public List<AppDescription> Descriptions { get; set; }
        public List<AppFile> Files { get; set; }

        #region Parent

        public int AppInfoId { get; set; }
        public AppInfo AppInfo { get; set; }
        
        #endregion
    }
}
