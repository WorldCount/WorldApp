
namespace DiffPather.Core.Database.Models
{
    public class AppDescription
    {
        public int Id { get; set; }
        public string Text { get; set; }

        #region Parent

        public int AppVersionId { get; set; }
        public AppVersion AppVersion { get; set; }

        #endregion
    }
}
