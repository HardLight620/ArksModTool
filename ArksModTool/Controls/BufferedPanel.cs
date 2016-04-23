using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArksModTool
{
    public class BufferedPanel : Panel
    {
        [DllImport("User32.dll", SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hWnd, Int32 msg, Int32 wParam, Int32 lParam);

        public BufferedPanel() : base()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const Int32 WS_EX_COMPOSITED = 0x02000000;

                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_COMPOSITED;
                return cp;
            }
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            const Int32 WM_SETREDRAW = 0x0000000B;
            
            SendMessage(Handle, WM_SETREDRAW, 0, 0);
            base.OnEnabledChanged(e);
            SendMessage(Handle, WM_SETREDRAW, 1, 0);
            this.Refresh();
        }
    }
}
