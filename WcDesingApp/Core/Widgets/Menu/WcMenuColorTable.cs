using System.Windows.Forms;
using System.Drawing;

namespace WcDesingApp.Core.Widgets.Menu
{
    internal class WcMenuColorTable : ProfessionalColorTable
    {
        #region Private Fields

        private readonly Color _backColor;
        private readonly Color _leftColumnColor;
        private readonly Color _borderColor;
        private readonly Color _menuItemBorderColor;
        private readonly Color _menuItemSelectedColor;

        #endregion

        public WcMenuColorTable(bool isMainMenu, Color primaryColor, IMenuColor mainMenuColor, IMenuColor menuColor)
        {
            IMenuColor colors = isMainMenu ? mainMenuColor : menuColor;

            _backColor = colors.BackColor;
            _leftColumnColor = colors.LeftColumnColor;
            _borderColor = colors.BorderColor;

            _menuItemBorderColor = primaryColor;
            _menuItemSelectedColor = primaryColor;
        }

        #region Overriddes Properties

        public override Color ToolStripDropDownBackground => _backColor;

        public override Color MenuBorder => _borderColor;

        public override Color MenuItemBorder => _menuItemBorderColor;

        public override Color MenuItemSelected => _menuItemSelectedColor;

        public override Color ImageMarginGradientBegin => _leftColumnColor;

        public override Color ImageMarginGradientMiddle => _leftColumnColor;

        public override Color ImageMarginGradientEnd => _leftColumnColor;

        #endregion
    }
}
