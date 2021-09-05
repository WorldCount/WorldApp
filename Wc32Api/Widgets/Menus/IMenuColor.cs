using System.Drawing;

namespace Wc32Api.Widgets.Menus
{
    public interface IMenuColor
    {
        Color BackColor { get; set; }
        Color LeftColumnColor { get; set; }
        Color BorderColor { get; set; }
    }
}
