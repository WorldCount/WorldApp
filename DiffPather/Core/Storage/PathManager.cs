using System.IO;
using System.Windows.Forms;

namespace DiffPather.Core.Storage
{
    public static class PathManager
    {
        // Папки
        private static readonly string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);
        // Путь к репозиторию
        public static readonly string RepoDir = Path.Combine(DataDir, Properties.Settings.Default.Repository);

        // Путь к БД
        public static readonly string DatabasePath = Path.Combine(DataDir, "database.db");
        // Путь к БД репозитория
        public static readonly string RepoDatabasePath = Path.Combine(DataDir, "repository.db");

        static PathManager()
        {
            if (!Directory.Exists(DataDir))
                Directory.CreateDirectory(DataDir);

            if (!Directory.Exists(RepoDir))
                Directory.Exists(RepoDir);
        }
    }
}
