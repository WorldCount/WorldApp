
namespace DiffPather.Core.Database.Models.Repository
{
    public class RepoAppDescription
    {
        public int Id { get; set; }
        public string Text { get; set; }

        #region Parent

        public int RepoAppVersionId { get; set; }
        public RepoAppVersion RepoAppVersion { get; set; }

        #endregion
    }
}
