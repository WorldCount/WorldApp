using DiffPather.Core.Forms;
using NLog;
using System;
using System.Windows.Forms;

namespace DiffPather
{
    static class Program
    {

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            Application.Run(new GeneralForm());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Logger.Error($"{e.Exception.Source}: {e.Exception}");
        }
    }
}
