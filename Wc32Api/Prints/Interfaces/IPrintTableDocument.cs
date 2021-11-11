using System.Drawing.Printing;
using System.Windows.Forms;

namespace Wc32Api.Prints.Interfaces
{
    interface IPrintTableDocument : IPrintDocument
    {
        void PrintRow(PrintPageEventArgs e, DataGridViewRow gridRow, int topMargin);
    }
}
