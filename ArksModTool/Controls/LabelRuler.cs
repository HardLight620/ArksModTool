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
    public partial class LabelRuler : UserControl
    {
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text { get { return label1.Text; } set { label1.Text = value; } }

        [DefaultValue(false)]
        public new bool TabStop { get { return base.TabStop; } set { base.TabStop = value; } }

        public LabelRuler()
        {
            InitializeComponent();
            base.TabStop = false;
        }
    }
}
