using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArksModTool
{
    public class PageControl : TabControl
    {
        private const int WM_FOCUS = 0x0007;
        private const int TCM_ADUSTRECT = 0x1328;
        private const int TCS_MULTILINE = 0x0200;

        [DllImport("user32.dll")]
        private static extern IntPtr SetFocus(IntPtr hWnd);

        protected unsafe override void WndProc(ref Message m)
        {
            if (DesignMode)
            {
                WndProcDesign(ref m);
            }
            else if (m.Msg == WM_FOCUS && IsUISelectionFlagSet())
            {
                // Reject focus generated from TabControl logic
                SetFocus(m.WParam);
                m.Result = new IntPtr(1);
            }
            else if (m.Msg == TCM_ADUSTRECT)
            {
                // Hide tabs and remove padding by trapping the TCM_ADJUSTRECT message.
                m.Result = new IntPtr(1);
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        protected unsafe virtual void WndProcDesign(ref Message m)
        {
            if (m.Msg == TCM_ADUSTRECT)
            {
                // Trim off the extra borders
                Rectangle* rect = (Rectangle*)m.LParam;
                rect->Offset(-4, -4);
                rect->Width += 4;
                rect->Height += 4;
            }

            base.WndProc(ref m);
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            // Disable automatic first control focus when changing pages.
            ClearUISelectionFlag();

            base.OnSelectedIndexChanged(e);
        }
        
        protected bool IsUISelectionFlagSet()
        {
            FieldInfo info = typeof(TabControl).GetField("tabControlState", BindingFlags.NonPublic | BindingFlags.Instance);
            BitVector32 tabControlState = (BitVector32)info.GetValue(this);
            return tabControlState[0x00000020]; // TABCNOTROLSTATE_UISelection
        }

        protected void ClearUISelectionFlag()
        {
            FieldInfo info = typeof(TabControl).GetField("tabControlState", BindingFlags.NonPublic | BindingFlags.Instance);
            BitVector32 tabControlState = (BitVector32)info.GetValue(this);
            tabControlState[0x00000020] = false;
            info.SetValue(this, tabControlState);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= (DesignMode ? 0 : TCS_MULTILINE);
                return cp;
            }
        }
    }
}
