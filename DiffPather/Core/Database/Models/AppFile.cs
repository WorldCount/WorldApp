
namespace DiffPather.Core.Database.Models
{
    public class AppFile
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Hash { get; set; }

        #region Parent

        public int AppVersionId { get; set; }
        public AppVersion AppVersion { get; set; }
        
        #endregion

    }
}
