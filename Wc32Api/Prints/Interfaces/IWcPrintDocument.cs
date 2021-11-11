using System.Drawing;
using System.Drawing.Printing;

namespace Wc32Api.Prints.Interfaces
{
    public interface IWcPrintDocument
    {
        // Отображать номера страниц
        bool PrintNumPageInfo { get; set; }
        int PagesCount { get; set; }
        string ReportTitle { get; set; }
        string ReportSubTitle { get; set; }
        string AppLogo { get; set; }
        bool PrintLogo { get; set; }
        int CurrentPageCount { get; set; }
        int[] ColumnWidths { get; set; }

        void SetMargin(Margins margins);
        float CheckWidth(PrintPageEventArgs e, Font font, string text);
        float CheckHeight(PrintPageEventArgs e, Font font, string text);
    }
}
