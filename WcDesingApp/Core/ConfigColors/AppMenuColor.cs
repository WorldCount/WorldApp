using System.Drawing;
using WcDesingApp.Core.Widgets.Menu;

namespace WcDesingApp.Core.ConfigColors
{
    public class AppMenuColor : IMenuColor
    {
        public Color BackColor { get; set; } = Color.White;
        public Color LeftColumnColor { get; set; } = Color.LightGray;
        public Color BorderColor { get; set; } = Color.LightGray;
    }
}
