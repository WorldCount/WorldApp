using System.Collections;
using System.Drawing;
using System.Drawing.Printing;

namespace Wc32Api.Prints.Interfaces
{
    public interface IPrintObjectDocument<in T> : IPrintDocument
    {
        bool PrintStat { get; set; }
        ArrayList ColumnLefts { get; set; }
        int CellHeight { get; set; }
        StringFormat StringFormat { get; set; }
        bool Grouping { get; set; }

        void PrintRow(PrintPageEventArgs e, T report, int topMargin);
        int PrintedStat(PrintPageEventArgs e, int margin);
    }
}
