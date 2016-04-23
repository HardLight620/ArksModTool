using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SharpDX.DirectInput;

namespace ArksModTool
{
    public partial class HotkeyPanel : UserControl
    {
        public static readonly Key[] DEFAULT_KEYS = Enumerable.Range(1, 211).Where(x => Enum.IsDefined(typeof(Key), x)).Select(x => (Key)x).ToArray();

        public event EventHandler ValueChanged { add { onValueChanged += value; } remove { onValueChanged -= value; } }
        private event EventHandler onValueChanged;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public KeyBinding Value { get { return m_value; } set { SetValue(value); } }
        private KeyBinding m_value = KeyBinding.Empty;

        private bool m_suspendUpdate = false;

        public HotkeyPanel()
        {
            InitializeComponent();

            SetAvailableKeys(DEFAULT_KEYS);
            SetupDataBinding();
        }

        public void SetAvailableKeys(Key[] keys)
        {
            var enumerable1 = keys.OrderBy(x => x.ToString().Length);
            var enumerable2 = enumerable1.ThenBy(x => x.ToString());

            cboKey.Items.Clear();
            cboKey.Items.AddRange(enumerable2.Cast<object>().ToArray());
        }

        public void SetValue(KeyBinding value)
        {
            if (m_value == value)
                return;

            ReleaseDataBinding();

            m_value = value;

            SetupDataBinding();
        }

        private void ReleaseDataBinding()
        {
            chkCtrl.DataBindings.Clear();
            chkShift.DataBindings.Clear();
            chkAlt.DataBindings.Clear();
            cboKey.DataBindings.Clear();
        }

        private void SetupDataBinding()
        {
            CreateBinding(chkCtrl, "Checked", "Control");
            CreateBinding(chkShift, "Checked", "Shift");
            CreateBinding(chkAlt, "Checked", "Alt");

            Binding binding = CreateBinding(cboKey, "SelectedItem", "Key");
            binding.Format += cboKey_BindingFormat;
            binding.Parse += cboKey_BindingParse;
            binding.ReadValue();
            OnValueChanged();
        }

        private Binding CreateBinding(Control c, string propertyName, string dataMember)
        {
            Binding binding = c.DataBindings.Add(propertyName, m_value, dataMember);
            binding.FormattingEnabled = true;
            binding.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            binding.BindingComplete += (object s, BindingCompleteEventArgs e) => { OnValueChanged(); };
            return binding;
        }

        protected virtual void OnValueChanged()
        {
            if (onValueChanged != null && !m_suspendUpdate)
                onValueChanged.Invoke(this, EventArgs.Empty);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            m_suspendUpdate = true;
            chkCtrl.Checked = false;
            chkShift.Checked = false;
            chkAlt.Checked = false;
            cboKey.SelectedItem = null;

            m_suspendUpdate = false;

            OnValueChanged();
        }

        private void cboKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Binding b = cboKey.DataBindings["SelectedItem"];

            if (b != null)
                b.WriteValue();
        }
        
        private void cboKey_BindingFormat(object sender, ConvertEventArgs e)
        {
            if (!cboKey.Items.Contains(e.Value))
                cboKey.SelectedItem = null;
        }

        private void cboKey_BindingParse(object sender, ConvertEventArgs e)
        {
            if (!(e.Value is Key))
                e.Value = Key.Unknown;
        }
    }
}
