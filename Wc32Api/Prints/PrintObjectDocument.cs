using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using Wc32Api.Prints.Interfaces;
using Wc32Api.Prints.Pens;

namespace Wc32Api.Prints
{
    public class PrintObjectDocument<T> : WcPrintDocument, IPrintObjectDocument<T>
    {

        #region Private Fields

        private int _rowCount;
        private bool _firstPage;
        private bool _newPage;
        private int _headerHeight = 40;
        private bool _lastPage;

        #endregion

        #region Public Properties

        public List<T> Reports { get; set; }
        public string Count { get; set; }
        public string Sum { get; set; }
        public string PosCount { get; set; }
        public bool PrintStat { get; set; }
        public ArrayList ColumnLefts { get; set; } = new ArrayList();
        public int CellHeight { get; set; } = 40;
        public bool Grouping { get; set; }

        // Форматирование строк
        public StringFormat StringFormat { get; set; } = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center,
            Trimming = StringTrimming.EllipsisCharacter
        };

        #endregion

        protected PrintObjectDocument(List<T> reports, string count, string sum, string posCount, 
            bool grouping = false)
        {
            Reports = reports;
            Count = count;
            Sum = sum;
            PosCount = posCount;
            Grouping = grouping;

            ColumnWidths = GetColumnWidths();
            SetMargin(new Margins(10, 10, 40, 40));
        }

        #region Public Methods

        public virtual int[] GetColumnWidths()
        {
            throw new NotImplementedException();
        }

        public virtual string[] GetHeaderTitle()
        {
            throw new NotImplementedException();
        }

        public virtual string[] GetValuesByType(T report)
        {
            throw new NotImplementedException();
        }

        public virtual string[] GetStatByType()
        {
            throw new NotImplementedException();
        }

        public virtual void PrintRow(PrintPageEventArgs e, T report, int topMargin)
        {
            string[] values = GetValuesByType(report);

            int cellCount = 0;
            while (cellCount < values.Length)
            {
                int colLeft = (int)ColumnLefts[cellCount];
                int colWidth = ColumnWidths[cellCount];

                // Значение
                e.Graphics.DrawString(values[cellCount], PrintPens.CellFont, PrintPens.ForeBrush, new Rectangle(colLeft, topMargin, colWidth, CellHeight), StringFormat);
                // Границы
                e.Graphics.DrawRectangle(PrintPens.BorderBrush, new Rectangle(colLeft, topMargin, colWidth, CellHeight));

                cellCount++;
            }
        }

        public virtual int PrintedStat(PrintPageEventArgs e, int margin)
        {
            throw new NotImplementedException();
        }

        public virtual void PrintTableHeader(PrintPageEventArgs e, int topMargin, string[] headerStrings)
        {
            int colCount = 0;

            while (colCount < headerStrings.Length)
            {
                int colLeft = (int)ColumnLefts[colCount];
                int colWidth = ColumnWidths[colCount];

                e.Graphics.DrawRectangle(PrintPens.BorderBrush, new Rectangle(colLeft, topMargin, colWidth, _headerHeight));
                e.Graphics.DrawString(headerStrings[colCount], PrintPens.BoldFont, PrintPens.ForeBrush, new Rectangle(colLeft, topMargin, colWidth, _headerHeight), StringFormat);

                colCount++;
            }
        }

        #endregion

        #region Overrides Methods

        protected override void OnBeginPrint(PrintEventArgs e)
        {
            ColumnLefts.Clear();
            _rowCount = 0;
            _firstPage = true;
            _newPage = true;
            CurrentPageCount = 1;
            PrintStat = false;
        }

        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            base.OnPrintPage(e);

            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            // Левый отступ
            int leftMargin = e.MarginBounds.Left;
            // Верхний отступ
            int topMargin = e.MarginBounds.Top;
            // Печатать остальные страницы
            bool morePagesToPrint = false;

            string pageNumString = $"Страница {CurrentPageCount}";
            if (PagesCount > 0)
                pageNumString = $"Страница {CurrentPageCount} из {PagesCount}";

            int pageNumHeight = (int)CheckHeight(e, PrintPens.BoldFont, pageNumString);

            if (_firstPage)
            {
                int countWidth = 0;
                while (countWidth < ColumnWidths.Length)
                {
                    ColumnLefts.Add(leftMargin);
                    leftMargin += ColumnWidths[countWidth];
                    countWidth++;
                }

                topMargin = PrintReportInfo(e, topMargin);
                PrintDate(e);
            }

            while (_rowCount < Reports.Count)
            {

                int tableSize = topMargin + CellHeight;
                if (PrintNumPageInfo)
                    tableSize += pageNumHeight;

                // Проверка, позволяет ли текущая страница напечатать эту строку
                if (tableSize >= e.MarginBounds.Height + e.MarginBounds.Top)
                {
                    _newPage = true;
                    _firstPage = false;
                    morePagesToPrint = true;
                    CurrentPageCount += 1;
                    break;
                }
                else
                {

                    if (_newPage)
                    {
                        topMargin = _firstPage ? topMargin : e.MarginBounds.Top;
                        // Заголовок таблицы
                        string[] headerStrings = GetHeaderTitle();
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
                    PrintRow(e, Reports[_rowCount], topMargin);
                }

                _rowCount++;
                topMargin += CellHeight;
                _lastPage = _rowCount == Reports.Count;
            }

            // Проверка, позволяет ли текущая страница напечатать эту строку
            if (_lastPage)
            {
                if (topMargin + 100 + CellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                {
                    _newPage = true;
                    _firstPage = false;
                    CurrentPageCount += 1;
                    morePagesToPrint = true;
                }
                else
                {
                    if (PrintNumPageInfo)
                    {
                        PrintNumsPages(e);
                    }

                    if (!PrintStat)
                    {
                        PrintedStat(e, topMargin);
                        PrintStat = true;
                    }
                }
            }

            e.HasMorePages = morePagesToPrint;
        }

        #endregion
    }
}
