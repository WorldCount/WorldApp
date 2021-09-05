using System.Drawing;

namespace Wc32Api.Widgets.Menus.Default
{
    internal class DefaultMenuColor : IMenuColor
    {
        public Color BackColor { get; set; } = Color.White;
        public Color LeftColumnColor { get; set; } = Color.LightGray;
        public Color BorderColor { get; set; } = Color.LightGray;
    }
}
