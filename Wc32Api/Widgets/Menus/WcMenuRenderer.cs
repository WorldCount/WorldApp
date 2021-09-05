using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Wc32Api.Widgets.Menus
{
    internal class WcMenuRenderer : ToolStripProfessionalRenderer
    {
        #region Private Fields

        private readonly Color _primaryColor;
        private readonly Color _textColor;
        private readonly int _arrowThickness;

        #endregion

        public WcMenuRenderer(bool isMainMenu, Color primaryColor, Color textColor, IMenuColor mainMenuColor, IMenuColor menuColor)
            : base(new WcMenuColorTable(isMainMenu, primaryColor, mainMenuColor, menuColor))
        {
            _primaryColor = primaryColor;
            _textColor = textColor;
            _arrowThickness = isMainMenu ? 3 : 2;
        }

        #region Overriddes Methods

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? Color.White : _textColor;
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            // Fields
            Graphics graph = e.Graphics;
            Size arrowSize = new Size(5, 12);
            Color arrowColor = e.Item.Selected ? Color.White : _primaryColor;
            Rectangle rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height - arrowSize.Height) / 2,
                arrowSize.Width, arrowSize.Height);

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrowColor, _arrowThickness))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
                path.AddLine(rect.Right, rect.Top + rect.Height / 2, rect.Left, rect.Top + rect.Height);
                graph.DrawPath(pen, path);
            }
        }

        #endregion
    }
}
