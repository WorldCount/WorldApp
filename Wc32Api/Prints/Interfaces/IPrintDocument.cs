using System.Drawing.Printing;
using System.Windows.Forms;

namespace Wc32Api.Prints.Interfaces
{
    public interface IPrintDocument : IWcPrintDocument
    {
        int[] GetColumnWidths();
        string[] GetHeaderTitle();

        void PrintTableHeader(PrintPageEventArgs e, int topMargin, string[] headerStrings);
        void PrintNumsPages(PrintPageEventArgs e);
        int PrintReportInfo(PrintPageEventArgs e, int margin);
        void PrintDate(PrintPageEventArgs e);
    }
}
