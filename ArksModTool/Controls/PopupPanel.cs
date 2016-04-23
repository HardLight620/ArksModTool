using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ArksModTool
{
    [Designer(typeof(PopupPanelDesigner))]
    public class PopupPanel : Panel
    {
        [DefaultValue(true)]
        [Description("Speicifies whether a three-dimensional shadow effect appears when the PopupPanel is displayed.")]
        public bool DropShadowEnabled { get { return m_popupWindow.DropShadowEnabled; } set { m_popupWindow.DropShadowEnabled = value; } }

        [DefaultValue(false)]
        [Description("Specifies whether the PopupPanel automatically closes through user action.")]
        public bool AutoClose { get { return m_popupWindow.AutoClose; } set { m_popupWindow.AutoClose = value; } }

        [DefaultValue(true)]
        [Description("Specifies whether the PopupPanel automatically closes when it is deactivated.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool AutoCloseOnDeactivate { get { return m_popupWindow.AutoCloseOnDeactivate; } set { m_popupWindow.AutoCloseOnDeactivate = value; } }

        [DefaultValue(1.0)]
        [TypeConverterAttribute(typeof(OpacityConverter))]
        [Description("The opacity percentage of the control.")]
        public double Opacity { get { return m_popupWindow.Opacity; } set { m_popupWindow.Opacity = value; } }

        protected PopupWindow m_popupWindow = new PopupWindow();

        public PopupPanel()
        {
            
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            if (!DesignMode)
            {
                Parent = null;
                m_popupWindow.SetControl(this);
            }

            base.OnHandleCreated(e);
        }

        public new void Show()
        {
            m_popupWindow.Show();
            m_popupWindow.Focus();
        }

        public void Show(Point screenLocation)
        {
            m_popupWindow.Show(screenLocation);
            m_popupWindow.Focus();
        }

        public void Show(Control control, Point position)
        {
            m_popupWindow.Show(control, position);
            m_popupWindow.Focus();
        }

        public void Show(int x, int y)
        {
            m_popupWindow.Show(x, y);
            m_popupWindow.Focus();
        }

        public void Show(Point position, ToolStripDropDownDirection direction)
        {
            m_popupWindow.Show(position, direction);
            m_popupWindow.Focus();
        }

        public void Show(Control control, int x, int y)
        {
            m_popupWindow.Show(control, x, y);
            m_popupWindow.Focus();
        }

        public void Show(Control control, Point position, ToolStripDropDownDirection direction)
        {
            m_popupWindow.Show(control, position, direction);
            m_popupWindow.Focus();
        }

        public void Close()
        {
            m_popupWindow.Close();
        }
    }

    #region Designer

    public class PopupPanelDesigner : ParentControlDesigner
    {
        private ISelectionService m_selectionService = null;
        private bool m_editModeEnabled = false;

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            m_selectionService = GetService(typeof(ISelectionService)) as ISelectionService;

            if (m_selectionService != null)
                m_selectionService.SelectionChanged += SelectionService_SelectionChanged;

            ActionLists.Add(new PopupDesignerActionList(this, this.Component));
            UpdateVisibility();
        }

        public void SetEditModeEnabled(bool value)
        {
            m_editModeEnabled = value;
            UpdateVisibility();
        }

        public void SelectionService_SelectionChanged(object sender, EventArgs e)
        {
            UpdateVisibility();
        }

        private void UpdateVisibility()
        {
            this.Control.Visible = m_selectionService.GetComponentSelected(this.Component) || m_editModeEnabled;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && m_selectionService != null)
                m_selectionService.SelectionChanged -= SelectionService_SelectionChanged;

            base.Dispose(disposing);
        }

        private class PopupDesignerActionList : DesignerActionList
        {
            private PopupPanelDesigner m_owner;

            public bool EditMode { get { return m_owner.m_editModeEnabled; } set { m_owner.SetEditModeEnabled(value); } }

            public PopupDesignerActionList(PopupPanelDesigner owner, IComponent component)
                : base(component)
            {
                m_owner = owner;
            }
        }
    }

#endregion
}
