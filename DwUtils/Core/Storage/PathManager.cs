using System.IO;
using System.Windows.Forms;

namespace DwUtils.Core.Storage
{
    public static class PathManager
    {
        // Папки
        public static readonly string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);

        // Файлы
        public static readonly string PostItemConnectFile = Path.Combine(DataDir, "postitem.xml");
        public static readonly string PostUnitConnectFile = Path.Combine(DataDir, "postunit.xml");

        static PathManager()
        {
            if (!File.Exists(DataDir))
                Directory.CreateDirectory(DataDir);
        }
    }
}
