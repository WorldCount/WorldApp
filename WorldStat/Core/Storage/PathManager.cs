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

        // Путь к Логу
        public static readonly string LogPath = Path.Combine(DataDir, "log.txt");


        static PathManager()
        {
            if (!File.Exists(DataDir))
                Directory.CreateDirectory(DataDir);
        }
    }
}
