using System.Drawing;
using WcDesingApp.Core.Widgets.Menu;

namespace WcDesingApp.Core.ConfigColors
{
    public class AppMainMenuColor : IMenuColor
    {
        public Color BackColor { get; set; } = Color.FromArgb(37, 37, 60);
        public Color LeftColumnColor { get; set; } = Color.FromArgb(32, 33, 51);
        public Color BorderColor { get; set; } = Color.FromArgb(32, 33, 51);
    }
}
