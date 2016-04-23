using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ArksModTool
{
    public class PopupWindow : ToolStripDropDown
    {
        private ToolStripControlHost m_host;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new bool AutoSize { get { return base.AutoSize; } set { base.AutoSize = value; } }

        [DefaultValue(typeof(Padding), "0, 0, 0, 0")]
        public new Padding Margin { get { return base.Margin; } set { base.Margin = value; } }

        [DefaultValue(typeof(Padding), "0, 0, 0, 0")]
        public new Padding Padding { get { return base.Padding; } set { base.Padding = value; } }

        [Browsable(true)]
        [Description("Specifies whether the PopupWindow automatically closes when it is deactivated.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool AutoCloseOnDeactivate { get { return m_autoCloseOnDeactivate; } set { m_autoCloseOnDeactivate = value; } }
        private bool m_autoCloseOnDeactivate = true;

        public PopupWindow()
        {
            this.AutoClose = false;
            this.AutoSize = false;
            this.Padding = Padding.Empty;
        }

        public void SetControl(Control c)
        {
            ClearControl();

            m_host = new ToolStripControlHost(c);
            m_host.AutoSize = false;
            m_host.Margin = Padding.Empty;
            m_host.Padding = Padding.Empty;
            m_host.Size = c.Size;
            
            this.Size = c.Size;
            this.Items.Add(m_host);
        }

        public void ClearControl()
        {
            if (m_host == null)
                return;
            
            this.Items.Remove(m_host);
            m_host.Dispose();
            m_host = null;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0006 && m.WParam.ToInt32() == 0 && m_autoCloseOnDeactivate)
            {
                Close();
            }

            base.WndProc(ref m);
        }
    }
}
