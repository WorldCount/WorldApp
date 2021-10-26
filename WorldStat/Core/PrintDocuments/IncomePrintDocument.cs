using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using NLog;
using WorldStat.Core.Database.Models;
using WorldStat.Core.PrintDocuments.Pens;

namespace WorldStat.Core.PrintDocuments
{
    public class IncomePrintDocument : PrintDocument
    {
        #region Private Fields

        private List<ReportPos> _reports;

        private readonly string _sum;
        private readonly string _count;
        private readonly string _posCount;
        private readonly bool _grouping;

        private readonly int[] _columnWidths;

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        // Форматирование строк
        private readonly StringFormat _stringFormat = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center,
            Trimming = StringTrimming.EllipsisCharacter
        };

        private readonly ArrayList _columnLefts = new ArrayList();
        private int _cellHeight;
        private int _rowCount;
        private bool _firstPage;
        private bool _newPage;
        private int _headerHeight = 40;
        private int _currentPageCount = 1;
        private bool _printStat;
        private bool _lastPage;

        #endregion

        public IncomePrintDocument(List<ReportPos> reports, string count, string sum, string posCount, bool grouping)
        {
            _reports = reports;
            _count = count;
            _sum = sum;
            _posCount = posCount;
            _grouping = grouping;

            _columnWidths = GetWidthByType();
            DefaultPageSettings.Margins = new Margins(10, 10, 40, 40);
        }

        #region Public Properties

        // Отображать номера страниц
        public bool PrintNumPageInfo { get; set; }
        public int PagesCount { get; set; } = 0;
        public string ReportTitle { get; set; } = "Общий отчет";
        public string ReportSubTitle { get; set; } = "";
        public string AppLogo { get; set; } = "WS";
        public bool PrintLogo { get; set; }

        #endregion

        #region Public Methods

        // ReSharper disable once UnusedMember.Global
        public void SetMargin(Margins margins)
        {
            DefaultPageSettings.Margins = margins;
        }

        public void SetReports(List<ReportPos> reports)
        {
            _reports = reports;
        }

        #endregion

        #region Private Methods

        private int[] GetWidthByType()
        {
            if (_grouping)
                return new[] { 470, 150, 150 };
            return new[] { 100, 370, 150, 150 };
        }

        private string[] GetValuesByType(ReportPos report)
        {
            if (_grouping)
                return new[] { report.FirmName, report.Count.ToString(), report.Pay.ToString("N2")};

            return new[] { report.DateText, report.FirmName, report.Count.ToString(), report.Pay.ToString("N2") };
        }

        private string[] GetHeaderByType()
        {
            if (_grouping)
                return new[] { "Организация", "Количество", "Плата" };
            return new[] { "Дата", "Организация", "Количество", "Плата" };
        }

        private string[] GetStatByType()
        {
            if (_grouping)
                return new[] { _posCount, _count, _sum };
            return new[] { "", _posCount, _count, _sum };
        }

        /// <summary>Печать строки</summary>
        private void PrintRow(PrintPageEventArgs e, ReportPos report, int topMargin)
        {

            string[] values = GetValuesByType(report);

            int cellCount = 0;
            while (cellCount < values.Length)
            {
                int colLeft = (int)_columnLefts[cellCount];
                int colWidth = _columnWidths[cellCount];

                // Значение
                e.Graphics.DrawString(values[cellCount], PrintPens.CellFont, PrintPens.ForeBrush, new Rectangle(colLeft, topMargin, colWidth, _cellHeight), _stringFormat);
                // Границы
                e.Graphics.DrawRectangle(PrintPens.BorderBrush, new Rectangle(colLeft, topMargin, colWidth, _cellHeight));

                cellCount++;
            }
        }

        /// <summary>Заголовок таблицы</summary>
        private void PrintTableHeader(PrintPageEventArgs e, int topMargin, string[] headerStrings)
        {
            int colCount = 0;

            while (colCount < headerStrings.Length)
            {
                int colLeft = (int)_columnLefts[colCount];
                int colWidth = _columnWidths[colCount];

                e.Graphics.DrawRectangle(PrintPens.BorderBrush, new Rectangle(colLeft, topMargin, colWidth, _headerHeight));
                e.Graphics.DrawString(headerStrings[colCount], PrintPens.BoldFont, PrintPens.ForeBrush, new Rectangle(colLeft, topMargin, colWidth, _headerHeight), _stringFormat);

                colCount++;
            }
        }

        /// <summary>Номер страницы</summary>
        private void PrintNumsPages(PrintPageEventArgs e)
        {
            string pageNumString = $"Страница {_currentPageCount}";

            if (PagesCount > 0)
                pageNumString = $"Страница {_currentPageCount} из {PagesCount}";

            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Far,
            };

            int pageWidth = e.MarginBounds.Right - e.MarginBounds.Y - 10;
            Rectangle rect = new Rectangle(e.MarginBounds.Left, e.MarginBounds.Height + e.MarginBounds.Top - 10, pageWidth, 20);
            e.Graphics.DrawString(pageNumString, PrintPens.BoldFont, PrintPens.ForeBrush, rect, stringFormat);
        }

        /// <summary>Информация об отчете</summary>
        private int PrintReportInfo(PrintPageEventArgs e, int margin)
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

        /// <summary>Проверка ширины</summary>
        private float CheckWidth(PrintPageEventArgs e, Font font, string text)
        {
            return e.MarginBounds.Width - e.Graphics.MeasureString(text, font, e.MarginBounds.Width).Width;
        }

        /// <summary>Проверка высоты</summary>
        private float CheckHeight(PrintPageEventArgs e, Font font, string text)
        {
            return e.MarginBounds.Top - e.Graphics.MeasureString(text, font, e.MarginBounds.Width).Height;
        }

        /// <summary>Печать статистики</summary>
        private int PrintStat(PrintPageEventArgs e, int margin)
        {
            int topMargin = 10 + margin;

            string[] data = GetStatByType();
            string[] headerStrings = GetHeaderByType();

            if (_grouping)
                headerStrings[0] = "Позиций";
            else
                headerStrings[1] = "Позиций";

            PrintTableHeader(e, topMargin, headerStrings);
            topMargin += 40;

            int cellCount = 0;
            while (cellCount < data.Length)
            {
                int colLeft = (int)_columnLefts[cellCount];
                int colWidth = _columnWidths[cellCount];

                e.Graphics.DrawString(data[cellCount], PrintPens.CellFont, PrintPens.ForeBrush, new Rectangle(colLeft, topMargin, colWidth, _cellHeight), _stringFormat);
                // Границы
                e.Graphics.DrawRectangle(PrintPens.BorderBrush, new Rectangle(colLeft, topMargin, colWidth, _cellHeight));
                cellCount++;
            }

            topMargin += 40;

            return topMargin;
        }

        /// <summary>Печать даты формирования</summary>
        private void PrintDate(PrintPageEventArgs e)
        {
            string date = $"Сформировано: {DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}";
            // Печать Даты
            e.Graphics.DrawString(date, PrintPens.DateFont, PrintPens.ForeBrush, e.MarginBounds.Left, e.MarginBounds.Height + e.MarginBounds.Top - 10);
        }

        #endregion

        #region Overrides Methods

        protected override void OnBeginPrint(PrintEventArgs e)
        {
            try
            {
                _columnLefts.Clear();
                _rowCount = 0;
                _firstPage = true;
                _newPage = true;
                _currentPageCount = 1;
                _printStat = false;
            }
            catch (Exception exception)
            {
                Logger.Error($"Ошибка: {exception}");
            }
        }

        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            base.OnPrintPage(e);

            try
            {
                e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                // Левый отступ
                int leftMargin = e.MarginBounds.Left;
                // Верхний отступ
                int topMargin = e.MarginBounds.Top;
                // Печатать остальные страницы
                bool morePagesToPrint = false;

                int pageWidth = (int)e.PageSettings.PrintableArea.Width - e.MarginBounds.Left + 1;

                string pageNumString = $"Страница {_currentPageCount}";
                if (PagesCount > 0)
                    pageNumString = $"Страница {_currentPageCount} из {_currentPageCount}";

                int pageNumHeight = (int)CheckHeight(e, PrintPens.BoldFont, pageNumString);

                if (_firstPage)
                {
                    int countWidth = 0;
                    while (countWidth < _columnWidths.Length)
                    {
                        _columnLefts.Add(leftMargin);
                        leftMargin += _columnWidths[countWidth];
                        countWidth++;
                    }

                    topMargin = PrintReportInfo(e, topMargin);
                    PrintDate(e);
                }

                while (_rowCount < _reports.Count)
                {

                    // Высота ячейки
                    _cellHeight = 40;

                    int tableSize = topMargin + _cellHeight;
                    if (PrintNumPageInfo)
                        tableSize += pageNumHeight;

                    // Проверка, позволяет ли текущая страница напечатать эту строку
                    if (tableSize >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        _newPage = true;
                        _firstPage = false;
                        morePagesToPrint = true;
                        _currentPageCount += 1;
                        break;
                    }
                    else
                    {

                        if (_newPage)
                        {
                            topMargin = _firstPage ? topMargin : e.MarginBounds.Top;
                            // Заголовок таблицы
                            string[] headerStrings = GetHeaderByType();
                            PrintTableHeader(e, topMargin, headerStrings);

                            if (PrintNumPageInfo)
                            {
                                PrintNumsPages(e);
                            }

                            _newPage = false;
                            topMargin += _headerHeight;

                            PrintDate(e);
                        }

                        // Отрисовка строки
                        PrintRow(e, _reports[_rowCount], topMargin);
                    }

                    _rowCount++;
                    topMargin += _cellHeight;
                    _lastPage = _rowCount == _reports.Count;
                }

                // Проверка, позволяет ли текущая страница напечатать эту строку
                if (_lastPage)
                {
                    if (topMargin + 100 + _cellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        _newPage = true;
                        _firstPage = false;
                        _currentPageCount += 1;
                        morePagesToPrint = true;
                    }
                    else
                    {
                        if (PrintNumPageInfo)
                        {
                            PrintNumsPages(e);
                        }

                        if (!_printStat)
                        {
                            PrintStat(e, topMargin);
                            _printStat = true;
                        }
                    }
                }

                e.HasMorePages = morePagesToPrint;
            }
            catch (Exception ex)
            {
                Logger.Error($"Ошибка: {ex}");
            }
        }

        #endregion
    }
}
