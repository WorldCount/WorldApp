using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Windows.Forms;
using Wc32Api.Prints.Interfaces;
using Wc32Api.Prints.Pens;

namespace Wc32Api.Prints
{
    public class PrintTableDocument : WcPrintDocument, IPrintTableDocument
    {
        #region Private Fields

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
        private bool _lastPage;

        #endregion

        #region Public Properties

        // ReSharper disable once MemberCanBePrivate.Global
        public DataGridView DataGridView { get; private set; }

        #endregion

        protected PrintTableDocument(DataGridView dataGridView)
        {
            ColumnWidths = GetColumnWidths();
            DataGridView = dataGridView;
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

        /// <summary>Печать строки</summary>
        public virtual void PrintRow(PrintPageEventArgs e, DataGridViewRow gridRow, int topMargin)
        {
            bool clear = (string)gridRow.Cells[0].Value == "Clear";

            int cellCount = 0;
            while (cellCount < gridRow.Cells.Count)
            {
                DataGridViewCell cell = gridRow.Cells[cellCount];

                int colLeft = (int)_columnLefts[cellCount];
                int colWidth = ColumnWidths[cellCount];

                // Значение
                if (cell?.Value != null)
                {
                    if (!clear)
                        // Значение
                        e.Graphics.DrawString(cell.Value.ToString(), PrintPens.CellFont, PrintPens.ForeBrush,
                            new Rectangle(colLeft, topMargin, colWidth, _cellHeight), _stringFormat);
                }

                // Границы
                if (!clear)
                    e.Graphics.DrawRectangle(PrintPens.BorderBrush, new Rectangle(colLeft, topMargin, colWidth, _cellHeight));

                cellCount++;
            }
        }

        /// <summary>Заголовок таблицы</summary>
        public virtual void PrintTableHeader(PrintPageEventArgs e, int topMargin, string[] headerStrings)
        {
            int colCount = 0;

            while (colCount < headerStrings.Length)
            {
                int colLeft = (int)_columnLefts[colCount];
                int colWidth = ColumnWidths[colCount];

                e.Graphics.DrawRectangle(PrintPens.BorderBrush, new Rectangle(colLeft, topMargin, colWidth, _headerHeight));
                e.Graphics.DrawString(headerStrings[colCount], PrintPens.BoldFont, PrintPens.ForeBrush, new Rectangle(colLeft, topMargin, colWidth, _headerHeight), _stringFormat);

                colCount++;
            }
        }

        #endregion

        #region Overrides Methods

        protected override void OnBeginPrint(PrintEventArgs e)
        {
            _columnLefts.Clear();
            _rowCount = 0;
            _firstPage = true;
            _newPage = true;
            CurrentPageCount = 1;
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
                    _columnLefts.Add(leftMargin);
                    leftMargin += ColumnWidths[countWidth];
                    countWidth++;
                }

                topMargin = PrintReportInfo(e, topMargin);
                PrintDate(e);
            }

            while (_rowCount < DataGridView.Rows.Count - 1)
            {

                DataGridViewRow gridRow = DataGridView.Rows[_rowCount];

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
                    PrintRow(e, gridRow, topMargin);
                }

                _rowCount++;
                topMargin += _cellHeight;
                _lastPage = _rowCount == DataGridView.Rows.Count;
            }

            // Проверка, позволяет ли текущая страница напечатать эту строку
            if (_lastPage)
            {
                if (topMargin + 100 + _cellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
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
                }
            }

            e.HasMorePages = morePagesToPrint;
        }

        #endregion
    }
}
