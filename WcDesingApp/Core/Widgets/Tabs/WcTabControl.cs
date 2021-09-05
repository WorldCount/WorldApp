using System;
using System.Windows.Forms;

namespace WcDesingApp.Core.Widgets.Tabs
{
    public class WcTabControl : TabControl
    {
        #region Overrides Methods

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x1328 && !DesignMode) 
                m.Result = (IntPtr)1;
            else 
                base.WndProc(ref m);
        }

        #endregion
    }
}
