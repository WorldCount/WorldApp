using System.IO;
using System.Windows.Forms;

namespace WhoseIsBarcode.Core.Storage
{
    public static class PathManager
    {
        // Папки
        private static readonly string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);

        // Файлы
        public static readonly string ConnectFile = Path.Combine(DataDir, Properties.Settings.Default.ConnectFile);


        static PathManager()
        {
            if (!File.Exists(DataDir))
                Directory.CreateDirectory(DataDir);
        }
    }
}
