using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using NLog;
using Wc32Api.Prints;

namespace WorldStat.Core.PrintDocuments
{
    public class StatPrintDocument : PrintTableDocument
    {
        #region Private Fields

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        #endregion

        public StatPrintDocument(DataGridView dataGridView) : base(dataGridView)
        {
        }

        #region Public Methods

        public override int[] GetColumnWidths()
        {
            return new[] { 200, 190, 190, 190 };
        }

        public override string[] GetHeaderTitle()
        {
            return new[] { "Название", "Описание", "Количество", "Плата" };
        }

        #endregion

        #region Overrides Methods

        protected override void OnBeginPrint(PrintEventArgs e)
        {
            try
            {
                base.OnBeginPrint(e);
            }
            catch (Exception exception)
            {
                Logger.Error($"Ошибка: {exception}");
            }
        }

        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            try
            {
                base.OnPrintPage(e);
            }
            catch (Exception ex)
            {
                Logger.Error($"Ошибка: {ex}");
            }
        }

        #endregion
    }
}
