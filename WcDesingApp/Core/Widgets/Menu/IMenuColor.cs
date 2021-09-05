using System.Drawing;

namespace WcDesingApp.Core.Widgets.Menu
{
    public interface IMenuColor
    {
        Color BackColor { get; set; }
        Color LeftColumnColor { get; set; }
        Color BorderColor { get; set; }
    }
}
