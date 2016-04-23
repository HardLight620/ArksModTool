using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArksModTool
{
    public partial class HotkeySelector : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public KeyBinding Value { get { return m_value; } set { SetValue(value); } }
        private KeyBinding m_value = KeyBinding.Empty;

        private PopupPanel m_popupPanel = null;
        private HotkeyPanel m_hotkeyPanel = null;

        public HotkeySelector()
        {
            InitializeComponent();
            UpdateText();
        }

        public void UpdateText()
        {
            label1.Text = m_value.ToString();
        }

        public void SetValue(KeyBinding value)
        {
            if (m_value == value)
                return;

            if (value == null)
                value = KeyBinding.Empty;

            m_value = value;
            UpdateText();
        }

        public void SetEditPanel(PopupPanel value)
        {
            if (m_popupPanel == value)
                return;

            if (m_hotkeyPanel != null)
                m_hotkeyPanel.ValueChanged -= hotkeyPanel_ValueChanged;

            m_popupPanel = value;

            if (value != null)
            {
                m_hotkeyPanel = value.Controls[0] as HotkeyPanel;

                if (m_hotkeyPanel != null)
                    m_hotkeyPanel.ValueChanged += hotkeyPanel_ValueChanged;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m_popupPanel == null || m_hotkeyPanel == null)
                return;
            
            m_hotkeyPanel.Value = m_value;

            if (m_popupPanel.Visible)
                m_popupPanel.Close();
            else
                m_popupPanel.Show(button1, new Point(button1.Width, button1.Height), ToolStripDropDownDirection.BelowLeft);
        }

        private void hotkeyPanel_ValueChanged(object sender, EventArgs e)
        {
            UpdateText();
        }
    }
}
