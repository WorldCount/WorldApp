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
    public class IncomePrintDocument : PrintObjectDocument<ReportPos>
    {
        #region Private Fields

        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        #endregion

        public IncomePrintDocument(List<ReportPos> reports, string count, string sum, string posCount, bool grouping) 
            : base(reports, count, sum, posCount, grouping)
        {
        }

        #region Public Methods

        #endregion

        #region Public Methods

        public override int[] GetColumnWidths()
        {
            if (Grouping)
                return new[] { 470, 150, 150 };
            return new[] { 100, 370, 150, 150 };
        }

        public override string[] GetValuesByType(ReportPos report)
        {
            if (Grouping)
                return new[] { report.FirmName, report.Count.ToString(), report.Pay.ToString("N2")};

            return new[] { report.DateText, report.FirmName, report.Count.ToString(), report.Pay.ToString("N2") };
        }

        public override string[] GetHeaderTitle()
        {
            if (Grouping)
                return new[] { "Организация", "Количество", "Плата" };
            return new[] { "Дата", "Организация", "Количество", "Плата" };
        }

        public override string[] GetStatByType()
        {
            if (Grouping)
                return new[] { PosCount, Count, Sum };
            return new[] { "", PosCount, Count, Sum };
        }

        /// <summary>Печать статистики</summary>
        public override int PrintedStat(PrintPageEventArgs e, int margin)
        {
            int topMargin = 10 + margin;

            string[] data = GetStatByType();
            string[] headerStrings = GetHeaderTitle();

            if (Grouping)
                headerStrings[0] = "Позиций";
            else
                headerStrings[1] = "Позиций";

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
