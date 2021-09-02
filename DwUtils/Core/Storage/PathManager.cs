using System.IO;
using System.Windows.Forms;

namespace DwUtils.Core.Storage
{
    public static class PathManager
    {
        // Папки
        public static readonly string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);


        static PathManager()
        {
            if (!File.Exists(DataDir))
                Directory.CreateDirectory(DataDir);
        }
    }
}
