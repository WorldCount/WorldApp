using System.IO;
using System.Windows.Forms;

namespace WorldStat.Core.Storage
{
    public static class PathManager
    {
        // Папки
        public static readonly string DataDir = Path.Combine(Application.StartupPath, Properties.Settings.Default.DataDir);
        // Папка с резервными отчетами
        public static readonly string ReserveReportsDir = Path.Combine(DataDir, Properties.Settings.Default.ReserveReportsDir);
        // Папка с временными отчетами
        public static readonly string TempReportsDir = Path.Combine(DataDir, Properties.Settings.Default.TempReportsDir);

        // Путь к БД
        public static readonly string DatabasePath = Path.Combine(DataDir, "database.db");

        // Путь к Логу
        public static readonly string LogPath = Path.Combine(DataDir, "log.txt");


        static PathManager()
        {
            if (!File.Exists(DataDir))
                Directory.CreateDirectory(DataDir);

            if (!File.Exists(ReserveReportsDir))
                Directory.CreateDirectory(ReserveReportsDir);

            if (!File.Exists(TempReportsDir))
                Directory.CreateDirectory(TempReportsDir);
        }
    }
}
