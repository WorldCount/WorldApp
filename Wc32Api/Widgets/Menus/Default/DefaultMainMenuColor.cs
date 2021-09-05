using System.Drawing;

namespace Wc32Api.Widgets.Menus.Default
{
    internal class DefaultMainMenuColor : IMenuColor
    {
        public Color BackColor { get; set; } = Color.FromArgb(37, 37, 60);
        public Color LeftColumnColor { get; set; } = Color.FromArgb(32, 33, 51);
        public Color BorderColor { get; set; } = Color.FromArgb(32, 33, 51);
    }
}
