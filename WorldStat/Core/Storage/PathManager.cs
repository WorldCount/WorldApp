using System.IO;
using System.Windows.Forms;

namespace WorldStat.Core.Storage
{
    public static class PathManager
    {
        // Папки
        public static readonly string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);

        // Путь к БД
        public static readonly string DatabasePath = Path.Combine(DataDir, "database.db");


        static PathManager()
        {
            if (!File.Exists(DataDir))
                Directory.CreateDirectory(DataDir);
        }
    }
}
