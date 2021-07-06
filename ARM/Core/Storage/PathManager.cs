using System.IO;
using System.Windows.Forms;

namespace ARM.Core.Storage
{
    public static class PathManager
    {
        // Папки
        public static readonly string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.Data);

        // Данные
        public static readonly string PostgresConnectPath = Path.Combine(DataDir, Properties.Settings.Default.ConnectFile);

        static PathManager()
        {
            if (!File.Exists(DataDir))
                Directory.CreateDirectory(DataDir);
        }
    }
}
