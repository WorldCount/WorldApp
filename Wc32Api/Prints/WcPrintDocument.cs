using System;
using System.Drawing;
using System.Drawing.Printing;
using Wc32Api.Prints.Interfaces;
using Wc32Api.Prints.Pens;

namespace Wc32Api.Prints
{
    public class WcPrintDocument : PrintDocument, IWcPrintDocument
    {
        #region Public Properties

        public bool PrintNumPageInfo { get; set; }
        public int PagesCount { get; set; }
        public string ReportTitle { get; set; } = "Отчет";
        public string ReportSubTitle { get; set; }
        public string AppLogo { get; set; } = "WC";
        public bool PrintLogo { get; set; }
        public int CurrentPageCount { get; set; } = 1;
        public int[] ColumnWidths { get; set; }

        #endregion

        #region Public Methods

        public void SetMargin(Margins margins)
        {
            DefaultPageSettings.Margins = margins;
        }

        /// <summary>Проверка ширины</summary>
        public float CheckWidth(PrintPageEventArgs e, Font font, string text)
        {
            return e.MarginBounds.Width - e.Graphics.MeasureString(text, font, e.MarginBounds.Width).Width;
        }

        /// <summary>Проверка высоты</summary>
        public float CheckHeight(PrintPageEventArgs e, Font font, string text)
        {
            return e.MarginBounds.Top - e.Graphics.MeasureString(text, font, e.MarginBounds.Width).Height;
        }

        /// <summary>Номер страницы</summary>
        public void PrintNumsPages(PrintPageEventArgs e)
        {
            string pageNumString = $"Страница {CurrentPageCount}";

            if (PagesCount > 0)
                pageNumString = $"Страница {CurrentPageCount} из {PagesCount}";

            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Far,
            };

            int pageWidth = e.MarginBounds.Right - e.MarginBounds.Y - 10;
            Rectangle rect = new Rectangle(e.MarginBounds.Left, e.MarginBounds.Height + e.MarginBounds.Top - 10, pageWidth, 20);
            e.Graphics.DrawString(pageNumString, PrintPens.BoldFont, PrintPens.ForeBrush, rect, stringFormat);
        }

        /// <summary>Информация об отчете</summary>
        public virtual int PrintReportInfo(PrintPageEventArgs e, int margin)
        {
            int offset = 20;
            int marginTop = margin - 20;

            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            int pageWidth = e.MarginBounds.Right - e.MarginBounds.Y - 10;

            // Заголовок отчета
            Rectangle rect = new Rectangle(e.MarginBounds.Left, marginTop, pageWidth, offset);
            e.Graphics.DrawString(ReportTitle, PrintPens.HeaderBoldFont, PrintPens.ForeBrush, rect, stringFormat);

            // Лого приложения
            if (PrintLogo)
            {
                Rectangle appLogoRect = new Rectangle(e.MarginBounds.Right - 78, marginTop, 40, offset + 20);
                e.Graphics.DrawString(AppLogo, PrintPens.HeaderBoldFont, PrintPens.ForeBrush, appLogoRect, stringFormat);
                e.Graphics.DrawRectangle(PrintPens.BorderBrush, appLogoRect);
                marginTop += offset;
            }

            // Подзаголовок
            rect.Y += offset;
            e.Graphics.DrawString(ReportSubTitle, PrintPens.HeaderFont, PrintPens.ForeBrush, rect, stringFormat);
            marginTop += offset;

            return marginTop + 10;
        }

        /// <summary>Печать даты формирования</summary>
        public virtual void PrintDate(PrintPageEventArgs e)
        {
            string date = $"Сформировано: {DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}";
            // Печать Даты
            e.Graphics.DrawString(date, PrintPens.DateFont, PrintPens.ForeBrush, e.MarginBounds.Left, e.MarginBounds.Height + e.MarginBounds.Top - 10);
        }

        #endregion
    }
}
