using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using WorldStat.Core.Database.Models;
using WorldStat.Core.PrintDocuments.Pens;

namespace WorldStat.Core.PrintDocuments
{
    public class StatPrintDocument : PrintDocument
    {
        #region Private Fields
        private readonly DataGridView _dataGridView;

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
        private bool _lastPage;

        #endregion

        public StatPrintDocument(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;

            _columnWidths = GetWidthByType();
            DefaultPageSettings.Margins = new Margins(10, 10, 40, 40);
        }

        #region Public Properties

        // Отображать номера страниц
        public bool PrintNumPageInfo { get; set; }
        public int PagesCount { get; set; } = 0;
        public string ReportTitle { get; set; } = "Статистика";
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
        #endregion

        #region Private Methods

        private int[] GetWidthByType()
        {
            return new[] { 200, 190, 190, 190 };
        }

        private string[] GetHeaderByType()
        {
            return new[] { "Название", "Описание", "Количество", "Плата" };
        }

        /// <summary>Печать строки</summary>
        private void PrintRow(PrintPageEventArgs e, DataGridViewRow gridRow, int topMargin)
        {
            bool clear = (string)gridRow.Cells[0].Value == "Clear";

            int cellCount = 0;
            while (cellCount < gridRow.Cells.Count)
            {
                DataGridViewCell cell = gridRow.Cells[cellCount];

                int colLeft = (int)_columnLefts[cellCount];
                int colWidth = _columnWidths[cellCount];

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

                while (_rowCount < _dataGridView.Rows.Count - 1)
                {

                    DataGridViewRow gridRow = _dataGridView.Rows[_rowCount];

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
                        PrintRow(e, gridRow, topMargin);
                    }

                    _rowCount++;
                    topMargin += _cellHeight;
                    _lastPage = _rowCount == _dataGridView.Rows.Count;
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
