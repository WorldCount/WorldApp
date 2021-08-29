using System.Collections.Generic;

namespace DiffPather.Core.Database.Models.Repository
{
    public class RepoAppVersion
    {
        public int Id { get; set; }
        public string Version { get; set; }

        public List<RepoAppDescription> Descriptions { get; set; }
        public List<RepoAppFile> Files { get; set; }

        #region Parent

        public int RepoAppInfoId { get; set; }
        public RepoAppInfo RepoAppInfo { get; set; }

        #endregion
    }
}
