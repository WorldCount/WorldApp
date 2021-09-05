using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Wc32Api.Widgets.Menus.Default;

namespace Wc32Api.Widgets.Menus
{
    public class WcDropdownMenu : ContextMenuStrip
    {
        #region Private Fields

        private bool _isMainMenu;
        private int _menuItemHeight = 25;
        private Color _menuItemTextColor = Color.DimGray;
        private Color _primaryColor = Color.FromArgb(67, 74, 84);
        private readonly IMenuColor _mainMenuColor;
        private readonly IMenuColor _menuColor;

        private Bitmap _menuItemHeaderSize;

        #endregion

        public WcDropdownMenu(IContainer container) : base(container)
        {
            _mainMenuColor = new DefaultMainMenuColor();
            _menuColor = new DefaultMenuColor();
        }

        #region Public Properties

        [Browsable(false)]
        //[Category("WcDropdownMenu - Appearance")]
        public bool IsMainMenu
        {
            get => _isMainMenu;
            set => _isMainMenu = value;
        }

        [Browsable(false)]
        //[Category("WcDropdownMenu - Appearance")]
        public int MenuItemHeight
        {
            get => _menuItemHeight;
            set => _menuItemHeight = value;
        }

        [Browsable(false)]
        //[Category("WcDropdownMenu - Appearance")]
        public Color MenuItemTextColor
        {
            get => _menuItemTextColor;
            set => _menuItemTextColor = value;
        }

        [Browsable(false)]
        //[Category("WcDropdownMenu - Appearance")]
        public Color PrimaryColor
        {
            get => _primaryColor;
            set => _primaryColor = value;
        }

        #endregion

        #region Private Methods

        private void LoadMenuItemAppearance()
        {
            if (_isMainMenu)
            {
                _menuItemHeaderSize = new Bitmap(25, 45);
                _menuItemTextColor = Color.Gainsboro;
            }
            else
            {
                _menuItemHeaderSize = new Bitmap(15, _menuItemHeight);
            }

            foreach (ToolStripItem itemL1 in Items)
            {
                if (itemL1.GetType() == typeof(ToolStripSeparator))
                    continue;

                ToolStripMenuItem menuItemL1 = (ToolStripMenuItem)itemL1;

                menuItemL1.ForeColor = _menuItemTextColor;
                menuItemL1.ImageScaling = ToolStripItemImageScaling.None;
                if (menuItemL1.Image == null) menuItemL1.Image = _menuItemHeaderSize;

                foreach (ToolStripItem itemL2 in menuItemL1.DropDownItems)
                {

                    if (itemL2.GetType() == typeof(ToolStripSeparator))
                        continue;

                    ToolStripMenuItem menuItemL2 = (ToolStripMenuItem)itemL2;

                    menuItemL2.ForeColor = _menuItemTextColor;
                    menuItemL2.ImageScaling = ToolStripItemImageScaling.None;
                    if (menuItemL2.Image == null) menuItemL2.Image = _menuItemHeaderSize;

                    foreach (ToolStripItem itemL3 in menuItemL2.DropDownItems)
                    {
                        if (itemL3.GetType() == typeof(ToolStripSeparator))
                            continue;

                        ToolStripMenuItem menuItemL3 = (ToolStripMenuItem)itemL3;

                        menuItemL3.ForeColor = _menuItemTextColor;
                        menuItemL3.ImageScaling = ToolStripItemImageScaling.None;
                        if (menuItemL3.Image == null) menuItemL3.Image = _menuItemHeaderSize;

                        foreach (ToolStripItem itemL4 in menuItemL3.DropDownItems)
                        {
                            if (itemL4.GetType() == typeof(ToolStripSeparator))
                                continue;

                            ToolStripMenuItem menuItemL4 = (ToolStripMenuItem)itemL4;

                            menuItemL4.ForeColor = _menuItemTextColor;
                            menuItemL4.ImageScaling = ToolStripItemImageScaling.None;
                            if (menuItemL4.Image == null) menuItemL4.Image = _menuItemHeaderSize;
                        }
                    }
                }
            }
        }

        #endregion

        #region Overriddes Methods

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (DesignMode == false)
            {
                LoadMenuItemAppearance();
                Renderer = new WcMenuRenderer(_isMainMenu, _primaryColor, _menuItemTextColor, _mainMenuColor, _menuColor);
            }
        }

        #endregion
    }
}
