using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using NLog;
using Wc32Api.Prints;
using Wc32Api.Prints.Pens;
using WorldStat.Core.Database.Models;

namespace WorldStat.Core.PrintDocuments
{
    public class ReportPrintDocument : PrintObjectDocument<Report>
    {
        #region Private Fields

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        #endregion

        public ReportPrintDocument(List<Report> reports, string count, string sum, string posCount) 
            : base(reports, count, sum, posCount)
        {
        }

        #region Public Ovverrides Methods

        public override int[] GetColumnWidths()
        {
            return new[] { 120, 80, 180, 180, 210 };
        }

        public override string[] GetValuesByType(Report report)
        {
            return new[] { report.Date.ToString("dd.MM.yyyy"), report.DayName, report.Type.ToString(), report.Count.ToString(), report.Pay.ToString("N2") };
        }

        public override string[] GetHeaderTitle()
        {
            return new[] { "Дата", "День", "Смена", "Количество", "Сумма" };
        }

        public override string[] GetStatByType()
        {
            return new[] { PosCount, "", "", Count, Sum };
        }

        /// <summary>Печать статистики</summary>
        public override int PrintedStat(PrintPageEventArgs e, int margin)
        {
            int topMargin = 10 + margin;

            string[] data = GetStatByType();
            string[] headerStrings = GetHeaderTitle();
            headerStrings[0] = "Дней";

            PrintTableHeader(e, topMargin, headerStrings);
            topMargin += 40;

            int cellCount = 0;
            while (cellCount < data.Length)
            {
                int colLeft = (int)ColumnLefts[cellCount];
                int colWidth = ColumnWidths[cellCount];

                e.Graphics.DrawString(data[cellCount], PrintPens.CellFont, PrintPens.ForeBrush, new Rectangle(colLeft, topMargin, colWidth, CellHeight), StringFormat);
                // Границы
                e.Graphics.DrawRectangle(PrintPens.BorderBrush, new Rectangle(colLeft, topMargin, colWidth, CellHeight));
                cellCount++;
            }

            topMargin += 40;

            return topMargin;
        }

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
