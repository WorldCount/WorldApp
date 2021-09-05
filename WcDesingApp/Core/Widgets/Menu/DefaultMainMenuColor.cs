using System.Drawing;

namespace WcDesingApp.Core.Widgets.Menu
{
    internal class DefaultMainMenuColor : IMenuColor
    {
        public Color BackColor { get; set; } = Color.FromArgb(37, 37, 60);
        public Color LeftColumnColor { get; set; } = Color.FromArgb(32, 33, 51);
        public Color BorderColor { get; set; } = Color.FromArgb(32, 33, 51);
    }
}
