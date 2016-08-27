namespace ArksModTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Standard View");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Shooter View");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Camera", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Input");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("UI");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Colors");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Preferences");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Info");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblStatus = new System.Windows.Forms.Label();
            this.ruler1 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tmrScan = new System.Windows.Forms.Timer(this.components);
            this.tmrCommunicationUpdate = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popupPanel1 = new ArksModTool.PopupPanel();
            this.hotkeyPanel1 = new ArksModTool.HotkeyPanel();
            this.pageControl1 = new ArksModTool.PageControl();
            this.pageGeneral = new System.Windows.Forms.TabPage();
            this.chkDisableLODReduction = new System.Windows.Forms.CheckBox();
            this.labelRuler6 = new ArksModTool.LabelRuler();
            this.labelRuler5 = new ArksModTool.LabelRuler();
            this.chkDisableUpdateCulling = new System.Windows.Forms.CheckBox();
            this.chkDisableFarCulling = new System.Windows.Forms.CheckBox();
            this.chkDisableIntro = new System.Windows.Forms.CheckBox();
            this.chkDisableNearCulling = new System.Windows.Forms.CheckBox();
            this.pageCamera1 = new System.Windows.Forms.TabPage();
            this.btnCam1Reset = new System.Windows.Forms.Button();
            this.labelRuler10 = new ArksModTool.LabelRuler();
            this.pnlCam1Customize = new ArksModTool.BufferedPanel();
            this.numCam1Height = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.trackCam1Height = new System.Windows.Forms.TrackBar();
            this.numCam1Distance = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.trackCam1Distance = new System.Windows.Forms.TrackBar();
            this.chkCam1Customize = new System.Windows.Forms.CheckBox();
            this.labelRuler9 = new ArksModTool.LabelRuler();
            this.pageCamera2 = new System.Windows.Forms.TabPage();
            this.btnCam2Reset = new System.Windows.Forms.Button();
            this.pnlCam2Customize = new ArksModTool.BufferedPanel();
            this.numCam2Height = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.trackCam2Height = new System.Windows.Forms.TrackBar();
            this.numCam2Pitch = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.trackCam2Pitch = new System.Windows.Forms.TrackBar();
            this.numCam2Yaw = new System.Windows.Forms.NumericUpDown();
            this.trackCam2Yaw = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.numCam2X = new System.Windows.Forms.NumericUpDown();
            this.numCam2Z = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackCam2X = new System.Windows.Forms.TrackBar();
            this.trackCam2Z = new System.Windows.Forms.TrackBar();
            this.numCam2Y = new System.Windows.Forms.NumericUpDown();
            this.trackCam2Y = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRuler12 = new ArksModTool.LabelRuler();
            this.chkCam2Customize = new System.Windows.Forms.CheckBox();
            this.labelRuler11 = new ArksModTool.LabelRuler();
            this.pageInput = new System.Windows.Forms.TabPage();
            this.hkselToggleMode = new ArksModTool.HotkeySelector();
            this.label10 = new System.Windows.Forms.Label();
            this.labelRuler2 = new ArksModTool.LabelRuler();
            this.numRunInputScale = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.trackRunInputScale = new System.Windows.Forms.TrackBar();
            this.numWalkInputScale = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radWalking = new System.Windows.Forms.RadioButton();
            this.radRunning = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.labelRuler1 = new ArksModTool.LabelRuler();
            this.trackWalkInputScale = new System.Windows.Forms.TrackBar();
            this.pageUI = new System.Windows.Forms.TabPage();
            this.chkHideEmergencyCodes = new System.Windows.Forms.CheckBox();
            this.chkHideScreenNotifications = new System.Windows.Forms.CheckBox();
            this.hkselHideUI = new ArksModTool.HotkeySelector();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRuler4 = new ArksModTool.LabelRuler();
            this.chkHideAllUI = new System.Windows.Forms.CheckBox();
            this.chkHideHud = new System.Windows.Forms.CheckBox();
            this.labelRuler3 = new ArksModTool.LabelRuler();
            this.chkHideCommandPalette = new System.Windows.Forms.CheckBox();
            this.pageColors = new System.Windows.Forms.TabPage();
            this.pnlCustomizeColors = new ArksModTool.BufferedPanel();
            this.numBlueBalance = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.trackBlueBalance = new System.Windows.Forms.TrackBar();
            this.numGreenBalance = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.trackGreenBalance = new System.Windows.Forms.TrackBar();
            this.numRedBalance = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.trackRedBalance = new System.Windows.Forms.TrackBar();
            this.numSaturation = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.trackSaturation = new System.Windows.Forms.TrackBar();
            this.numContrast = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.trackContrast = new System.Windows.Forms.TrackBar();
            this.numBrightness = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.trackBrightness = new System.Windows.Forms.TrackBar();
            this.btnResetColors = new System.Windows.Forms.Button();
            this.labelRuler15 = new ArksModTool.LabelRuler();
            this.chkCustomizeColors = new System.Windows.Forms.CheckBox();
            this.labelRuler16 = new ArksModTool.LabelRuler();
            this.pagePreferences = new System.Windows.Forms.TabPage();
            this.chkPromptOnUpdate = new System.Windows.Forms.CheckBox();
            this.chkAutomaticUpdates = new System.Windows.Forms.CheckBox();
            this.labelRuler14 = new ArksModTool.LabelRuler();
            this.chkCloseToTray = new System.Windows.Forms.CheckBox();
            this.chkMinimzeToTray = new System.Windows.Forms.CheckBox();
            this.labelRuler13 = new ArksModTool.LabelRuler();
            this.pageInfo = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnInfoMenu = new System.Windows.Forms.Button();
            this.pageFOV = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.numFovNPCTalk = new System.Windows.Forms.NumericUpDown();
            this.trackFovNPCTalk = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.numFovTPS = new System.Windows.Forms.NumericUpDown();
            this.trackFovTPS = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.numFovNormal = new System.Windows.Forms.NumericUpDown();
            this.trackFovNormal = new System.Windows.Forms.TrackBar();
            this.labelRuler8 = new ArksModTool.LabelRuler();
            this.labelRuler7 = new ArksModTool.LabelRuler();
            this.pageBlank = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tmrAppUpdate = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openProjectPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upclientForeground = new ArksModTool.UpdateClient();
            this.upclientBackground = new ArksModTool.UpdateClient();
            this.contextMenuStrip1.SuspendLayout();
            this.popupPanel1.SuspendLayout();
            this.pageControl1.SuspendLayout();
            this.pageGeneral.SuspendLayout();
            this.pageCamera1.SuspendLayout();
            this.pnlCam1Customize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCam1Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam1Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCam1Distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam1Distance)).BeginInit();
            this.pageCamera2.SuspendLayout();
            this.pnlCam2Customize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCam2Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam2Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCam2Pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam2Pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCam2Yaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam2Yaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCam2X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCam2Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam2X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam2Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCam2Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam2Y)).BeginInit();
            this.pageInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRunInputScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRunInputScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWalkInputScale)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackWalkInputScale)).BeginInit();
            this.pageUI.SuspendLayout();
            this.pageColors.SuspendLayout();
            this.pnlCustomizeColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlueBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreenBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreenBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRedBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRedBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).BeginInit();
            this.pagePreferences.SuspendLayout();
            this.pageInfo.SuspendLayout();
            this.pageFOV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFovNPCTalk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFovNPCTalk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFovTPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFovTPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFovNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFovNormal)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 304);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // ruler1
            // 
            this.ruler1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ruler1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ruler1.Location = new System.Drawing.Point(12, 292);
            this.ruler1.Name = "ruler1";
            this.ruler1.Size = new System.Drawing.Size(345, 2);
            this.ruler1.TabIndex = 2;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(318, 301);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(39, 20);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "v0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.HideSelection = false;
            this.treeView1.Indent = 19;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nodeGeneral";
            treeNode1.Tag = "pageGeneral";
            treeNode1.Text = "General";
            treeNode2.Name = "nodeRegularCamera";
            treeNode2.Tag = "pageCamera1";
            treeNode2.Text = "Standard View";
            treeNode3.Name = "nodeShooterCamera";
            treeNode3.Tag = "pageCamera2";
            treeNode3.Text = "Shooter View";
            treeNode4.Name = "nodeCamera";
            treeNode4.Tag = "pageCamera1";
            treeNode4.Text = "Camera";
            treeNode5.Name = "nodeInput";
            treeNode5.Tag = "pageInput";
            treeNode5.Text = "Input";
            treeNode6.Name = "nodeUI";
            treeNode6.Tag = "pageUI";
            treeNode6.Text = "UI";
            treeNode7.Name = "nodeColors";
            treeNode7.Tag = "pageColors";
            treeNode7.Text = "Colors";
            treeNode8.Name = "nodePreferences";
            treeNode8.Tag = "pagePreferences";
            treeNode8.Text = "Preferences";
            treeNode9.Name = "nodeInfo";
            treeNode9.Tag = "pageInfo";
            treeNode9.Text = "Info";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.treeView1.Scrollable = false;
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(121, 269);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tmrScan
            // 
            this.tmrScan.Interval = 1;
            this.tmrScan.Tick += new System.EventHandler(this.tmrScan_Tick);
            // 
            // tmrCommunicationUpdate
            // 
            this.tmrCommunicationUpdate.Interval = 10;
            this.tmrCommunicationUpdate.Tick += new System.EventHandler(this.tmrCommunicationUpdate_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Arks Mod Tool";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Arks Mod Tool";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 48);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.restoreToolStripMenuItem.Text = "&Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // popupPanel1
            // 
            this.popupPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.popupPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.popupPanel1.Controls.Add(this.hotkeyPanel1);
            this.popupPanel1.Location = new System.Drawing.Point(0, 0);
            this.popupPanel1.Name = "popupPanel1";
            this.popupPanel1.Size = new System.Drawing.Size(227, 117);
            this.popupPanel1.TabIndex = 4;
            // 
            // hotkeyPanel1
            // 
            this.hotkeyPanel1.Location = new System.Drawing.Point(0, 0);
            this.hotkeyPanel1.Name = "hotkeyPanel1";
            this.hotkeyPanel1.Size = new System.Drawing.Size(227, 117);
            this.hotkeyPanel1.TabIndex = 0;
            // 
            // pageControl1
            // 
            this.pageControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pageControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageControl1.Controls.Add(this.pageGeneral);
            this.pageControl1.Controls.Add(this.pageCamera1);
            this.pageControl1.Controls.Add(this.pageCamera2);
            this.pageControl1.Controls.Add(this.pageInput);
            this.pageControl1.Controls.Add(this.pageUI);
            this.pageControl1.Controls.Add(this.pageColors);
            this.pageControl1.Controls.Add(this.pagePreferences);
            this.pageControl1.Controls.Add(this.pageInfo);
            this.pageControl1.Controls.Add(this.pageFOV);
            this.pageControl1.Controls.Add(this.pageBlank);
            this.pageControl1.Location = new System.Drawing.Point(139, 12);
            this.pageControl1.Name = "pageControl1";
            this.pageControl1.SelectedIndex = 0;
            this.pageControl1.Size = new System.Drawing.Size(218, 269);
            this.pageControl1.TabIndex = 1;
            this.pageControl1.TabStop = false;
            // 
            // pageGeneral
            // 
            this.pageGeneral.BackColor = System.Drawing.Color.Transparent;
            this.pageGeneral.Controls.Add(this.chkDisableLODReduction);
            this.pageGeneral.Controls.Add(this.labelRuler6);
            this.pageGeneral.Controls.Add(this.labelRuler5);
            this.pageGeneral.Controls.Add(this.chkDisableUpdateCulling);
            this.pageGeneral.Controls.Add(this.chkDisableFarCulling);
            this.pageGeneral.Controls.Add(this.chkDisableIntro);
            this.pageGeneral.Controls.Add(this.chkDisableNearCulling);
            this.pageGeneral.Location = new System.Drawing.Point(0, 0);
            this.pageGeneral.Name = "pageGeneral";
            this.pageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.pageGeneral.Size = new System.Drawing.Size(218, 251);
            this.pageGeneral.TabIndex = 0;
            this.pageGeneral.Text = "Gen";
            // 
            // chkDisableLODReduction
            // 
            this.chkDisableLODReduction.AutoSize = true;
            this.chkDisableLODReduction.Location = new System.Drawing.Point(20, 116);
            this.chkDisableLODReduction.Name = "chkDisableLODReduction";
            this.chkDisableLODReduction.Size = new System.Drawing.Size(138, 17);
            this.chkDisableLODReduction.TabIndex = 4;
            this.chkDisableLODReduction.Text = "Disable &LOD Reduction";
            this.chkDisableLODReduction.UseVisualStyleBackColor = true;
            // 
            // labelRuler6
            // 
            this.labelRuler6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRuler6.Location = new System.Drawing.Point(0, 139);
            this.labelRuler6.Name = "labelRuler6";
            this.labelRuler6.Size = new System.Drawing.Size(218, 13);
            this.labelRuler6.TabIndex = 0;
            // 
            // labelRuler5
            // 
            this.labelRuler5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRuler5.Location = new System.Drawing.Point(0, 0);
            this.labelRuler5.Name = "labelRuler5";
            this.labelRuler5.Size = new System.Drawing.Size(218, 13);
            this.labelRuler5.TabIndex = 0;
            this.labelRuler5.Text = "Game Adjustments";
            // 
            // chkDisableUpdateCulling
            // 
            this.chkDisableUpdateCulling.AutoSize = true;
            this.chkDisableUpdateCulling.Location = new System.Drawing.Point(20, 93);
            this.chkDisableUpdateCulling.Name = "chkDisableUpdateCulling";
            this.chkDisableUpdateCulling.Size = new System.Drawing.Size(133, 17);
            this.chkDisableUpdateCulling.TabIndex = 3;
            this.chkDisableUpdateCulling.Text = "Disable &Update Culling";
            this.chkDisableUpdateCulling.UseVisualStyleBackColor = true;
            // 
            // chkDisableFarCulling
            // 
            this.chkDisableFarCulling.AutoSize = true;
            this.chkDisableFarCulling.Location = new System.Drawing.Point(20, 70);
            this.chkDisableFarCulling.Name = "chkDisableFarCulling";
            this.chkDisableFarCulling.Size = new System.Drawing.Size(113, 17);
            this.chkDisableFarCulling.TabIndex = 2;
            this.chkDisableFarCulling.Text = "Disable &Far Culling";
            this.chkDisableFarCulling.UseVisualStyleBackColor = true;
            // 
            // chkDisableIntro
            // 
            this.chkDisableIntro.AutoSize = true;
            this.chkDisableIntro.Location = new System.Drawing.Point(20, 24);
            this.chkDisableIntro.Name = "chkDisableIntro";
            this.chkDisableIntro.Size = new System.Drawing.Size(115, 17);
            this.chkDisableIntro.TabIndex = 0;
            this.chkDisableIntro.Text = "Disable Intro &Video";
            this.chkDisableIntro.UseVisualStyleBackColor = true;
            // 
            // chkDisableNearCulling
            // 
            this.chkDisableNearCulling.AutoSize = true;
            this.chkDisableNearCulling.Location = new System.Drawing.Point(20, 47);
            this.chkDisableNearCulling.Name = "chkDisableNearCulling";
            this.chkDisableNearCulling.Size = new System.Drawing.Size(121, 17);
            this.chkDisableNearCulling.TabIndex = 1;
            this.chkDisableNearCulling.Text = "Disable &Near Culling";
            this.chkDisableNearCulling.UseVisualStyleBackColor = true;
            // 
            // pageCamera1
            // 
            this.pageCamera1.Controls.Add(this.btnCam1Reset);
            this.pageCamera1.Controls.Add(this.labelRuler10);
            this.pageCamera1.Controls.Add(this.pnlCam1Customize);
            this.pageCamera1.Controls.Add(this.chkCam1Customize);
            this.pageCamera1.Controls.Add(this.labelRuler9);
            this.pageCamera1.Location = new System.Drawing.Point(0, 0);
            this.pageCamera1.Name = "pageCamera1";
            this.pageCamera1.Padding = new System.Windows.Forms.Padding(3);
            this.pageCamera1.Size = new System.Drawing.Size(218, 251);
            this.pageCamera1.TabIndex = 1;
            this.pageCamera1.Text = "Cam1";
            // 
            // btnCam1Reset
            // 
            this.btnCam1Reset.Location = new System.Drawing.Point(151, 26);
            this.btnCam1Reset.Name = "btnCam1Reset";
            this.btnCam1Reset.Size = new System.Drawing.Size(49, 23);
            this.btnCam1Reset.TabIndex = 4;
            this.btnCam1Reset.Text = "&Reset";
            this.btnCam1Reset.UseVisualStyleBackColor = true;
            this.btnCam1Reset.Click += new System.EventHandler(this.btnCam1Reset_Click);
            // 
            // labelRuler10
            // 
            this.labelRuler10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRuler10.Location = new System.Drawing.Point(0, 58);
            this.labelRuler10.Name = "labelRuler10";
            this.labelRuler10.Size = new System.Drawing.Size(218, 13);
            this.labelRuler10.TabIndex = 2;
            // 
            // pnlCam1Customize
            // 
            this.pnlCam1Customize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCam1Customize.Controls.Add(this.numCam1Height);
            this.pnlCam1Customize.Controls.Add(this.label3);
            this.pnlCam1Customize.Controls.Add(this.trackCam1Height);
            this.pnlCam1Customize.Controls.Add(this.numCam1Distance);
            this.pnlCam1Customize.Controls.Add(this.label4);
            this.pnlCam1Customize.Controls.Add(this.trackCam1Distance);
            this.pnlCam1Customize.Location = new System.Drawing.Point(0, 78);
            this.pnlCam1Customize.Name = "pnlCam1Customize";
            this.pnlCam1Customize.Size = new System.Drawing.Size(218, 64);
            this.pnlCam1Customize.TabIndex = 3;
            // 
            // numCam1Height
            // 
            this.numCam1Height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCam1Height.DecimalPlaces = 1;
            this.numCam1Height.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCam1Height.Location = new System.Drawing.Point(163, 34);
            this.numCam1Height.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCam1Height.Name = "numCam1Height";
            this.numCam1Height.Size = new System.Drawing.Size(49, 20);
            this.numCam1Height.TabIndex = 5;
            this.numCam1Height.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Height";
            // 
            // trackCam1Height
            // 
            this.trackCam1Height.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackCam1Height.AutoSize = false;
            this.trackCam1Height.Location = new System.Drawing.Point(56, 34);
            this.trackCam1Height.Maximum = 50;
            this.trackCam1Height.Name = "trackCam1Height";
            this.trackCam1Height.Size = new System.Drawing.Size(108, 24);
            this.trackCam1Height.TabIndex = 4;
            this.trackCam1Height.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackCam1Height.Value = 20;
            // 
            // numCam1Distance
            // 
            this.numCam1Distance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCam1Distance.DecimalPlaces = 1;
            this.numCam1Distance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCam1Distance.Location = new System.Drawing.Point(163, 4);
            this.numCam1Distance.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numCam1Distance.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numCam1Distance.Name = "numCam1Distance";
            this.numCam1Distance.Size = new System.Drawing.Size(49, 20);
            this.numCam1Distance.TabIndex = 2;
            this.numCam1Distance.Value = new decimal(new int[] {
            65,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "&Distance";
            // 
            // trackCam1Distance
            // 
            this.trackCam1Distance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackCam1Distance.AutoSize = false;
            this.trackCam1Distance.Location = new System.Drawing.Point(56, 4);
            this.trackCam1Distance.Maximum = 250;
            this.trackCam1Distance.Minimum = 5;
            this.trackCam1Distance.Name = "trackCam1Distance";
            this.trackCam1Distance.Size = new System.Drawing.Size(108, 24);
            this.trackCam1Distance.TabIndex = 1;
            this.trackCam1Distance.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackCam1Distance.Value = 65;
            // 
            // chkCam1Customize
            // 
            this.chkCam1Customize.AutoSize = true;
            this.chkCam1Customize.Location = new System.Drawing.Point(19, 30);
            this.chkCam1Customize.Name = "chkCam1Customize";
            this.chkCam1Customize.Size = new System.Drawing.Size(74, 17);
            this.chkCam1Customize.TabIndex = 1;
            this.chkCam1Customize.Text = "&Customize";
            this.chkCam1Customize.UseVisualStyleBackColor = true;
            // 
            // labelRuler9
            // 
            this.labelRuler9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRuler9.Location = new System.Drawing.Point(0, 0);
            this.labelRuler9.Name = "labelRuler9";
            this.labelRuler9.Size = new System.Drawing.Size(218, 13);
            this.labelRuler9.TabIndex = 0;
            this.labelRuler9.Text = "Standard View";
            // 
            // pageCamera2
            // 
            this.pageCamera2.Controls.Add(this.btnCam2Reset);
            this.pageCamera2.Controls.Add(this.pnlCam2Customize);
            this.pageCamera2.Controls.Add(this.labelRuler12);
            this.pageCamera2.Controls.Add(this.chkCam2Customize);
            this.pageCamera2.Controls.Add(this.labelRuler11);
            this.pageCamera2.Location = new System.Drawing.Point(0, 0);
            this.pageCamera2.Name = "pageCamera2";
            this.pageCamera2.Size = new System.Drawing.Size(218, 251);
            this.pageCamera2.TabIndex = 8;
            this.pageCamera2.Text = "Cam2";
            // 
            // btnCam2Reset
            // 
            this.btnCam2Reset.Location = new System.Drawing.Point(151, 26);
            this.btnCam2Reset.Name = "btnCam2Reset";
            this.btnCam2Reset.Size = new System.Drawing.Size(49, 23);
            this.btnCam2Reset.TabIndex = 4;
            this.btnCam2Reset.Text = "&Reset";
            this.btnCam2Reset.UseVisualStyleBackColor = true;
            this.btnCam2Reset.Click += new System.EventHandler(this.btnCam2Reset_Click);
            // 
            // pnlCam2Customize
            // 
            this.pnlCam2Customize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCam2Customize.Controls.Add(this.numCam2Height);
            this.pnlCam2Customize.Controls.Add(this.label15);
            this.pnlCam2Customize.Controls.Add(this.trackCam2Height);
            this.pnlCam2Customize.Controls.Add(this.numCam2Pitch);
            this.pnlCam2Customize.Controls.Add(this.label12);
            this.pnlCam2Customize.Controls.Add(this.trackCam2Pitch);
            this.pnlCam2Customize.Controls.Add(this.numCam2Yaw);
            this.pnlCam2Customize.Controls.Add(this.trackCam2Yaw);
            this.pnlCam2Customize.Controls.Add(this.label14);
            this.pnlCam2Customize.Controls.Add(this.numCam2X);
            this.pnlCam2Customize.Controls.Add(this.numCam2Z);
            this.pnlCam2Customize.Controls.Add(this.label6);
            this.pnlCam2Customize.Controls.Add(this.label7);
            this.pnlCam2Customize.Controls.Add(this.trackCam2X);
            this.pnlCam2Customize.Controls.Add(this.trackCam2Z);
            this.pnlCam2Customize.Controls.Add(this.numCam2Y);
            this.pnlCam2Customize.Controls.Add(this.trackCam2Y);
            this.pnlCam2Customize.Controls.Add(this.label5);
            this.pnlCam2Customize.Location = new System.Drawing.Point(0, 78);
            this.pnlCam2Customize.Name = "pnlCam2Customize";
            this.pnlCam2Customize.Size = new System.Drawing.Size(218, 173);
            this.pnlCam2Customize.TabIndex = 3;
            // 
            // numCam2Height
            // 
            this.numCam2Height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCam2Height.DecimalPlaces = 1;
            this.numCam2Height.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCam2Height.Location = new System.Drawing.Point(163, 168);
            this.numCam2Height.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCam2Height.Name = "numCam2Height";
            this.numCam2Height.Size = new System.Drawing.Size(49, 20);
            this.numCam2Height.TabIndex = 17;
            this.numCam2Height.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "&Height";
            // 
            // trackCam2Height
            // 
            this.trackCam2Height.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackCam2Height.AutoSize = false;
            this.trackCam2Height.Location = new System.Drawing.Point(56, 168);
            this.trackCam2Height.Maximum = 50;
            this.trackCam2Height.Name = "trackCam2Height";
            this.trackCam2Height.Size = new System.Drawing.Size(108, 24);
            this.trackCam2Height.TabIndex = 16;
            this.trackCam2Height.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackCam2Height.Value = 15;
            // 
            // numCam2Pitch
            // 
            this.numCam2Pitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCam2Pitch.DecimalPlaces = 1;
            this.numCam2Pitch.Location = new System.Drawing.Point(163, 138);
            this.numCam2Pitch.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numCam2Pitch.Minimum = new decimal(new int[] {
            45,
            0,
            0,
            -2147483648});
            this.numCam2Pitch.Name = "numCam2Pitch";
            this.numCam2Pitch.Size = new System.Drawing.Size(49, 20);
            this.numCam2Pitch.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "&Pitch";
            // 
            // trackCam2Pitch
            // 
            this.trackCam2Pitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackCam2Pitch.AutoSize = false;
            this.trackCam2Pitch.LargeChange = 50;
            this.trackCam2Pitch.Location = new System.Drawing.Point(56, 138);
            this.trackCam2Pitch.Maximum = 450;
            this.trackCam2Pitch.Minimum = -450;
            this.trackCam2Pitch.Name = "trackCam2Pitch";
            this.trackCam2Pitch.Size = new System.Drawing.Size(108, 24);
            this.trackCam2Pitch.SmallChange = 10;
            this.trackCam2Pitch.TabIndex = 13;
            this.trackCam2Pitch.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // numCam2Yaw
            // 
            this.numCam2Yaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCam2Yaw.DecimalPlaces = 1;
            this.numCam2Yaw.Location = new System.Drawing.Point(163, 108);
            this.numCam2Yaw.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numCam2Yaw.Minimum = new decimal(new int[] {
            45,
            0,
            0,
            -2147483648});
            this.numCam2Yaw.Name = "numCam2Yaw";
            this.numCam2Yaw.Size = new System.Drawing.Size(49, 20);
            this.numCam2Yaw.TabIndex = 11;
            // 
            // trackCam2Yaw
            // 
            this.trackCam2Yaw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackCam2Yaw.AutoSize = false;
            this.trackCam2Yaw.LargeChange = 50;
            this.trackCam2Yaw.Location = new System.Drawing.Point(56, 108);
            this.trackCam2Yaw.Maximum = 450;
            this.trackCam2Yaw.Minimum = -450;
            this.trackCam2Yaw.Name = "trackCam2Yaw";
            this.trackCam2Yaw.Size = new System.Drawing.Size(108, 24);
            this.trackCam2Yaw.SmallChange = 10;
            this.trackCam2Yaw.TabIndex = 10;
            this.trackCam2Yaw.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Y&aw";
            // 
            // numCam2X
            // 
            this.numCam2X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCam2X.DecimalPlaces = 1;
            this.numCam2X.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCam2X.Location = new System.Drawing.Point(163, 4);
            this.numCam2X.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCam2X.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numCam2X.Name = "numCam2X";
            this.numCam2X.Size = new System.Drawing.Size(49, 20);
            this.numCam2X.TabIndex = 2;
            // 
            // numCam2Z
            // 
            this.numCam2Z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCam2Z.DecimalPlaces = 1;
            this.numCam2Z.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCam2Z.Location = new System.Drawing.Point(163, 64);
            this.numCam2Z.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCam2Z.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numCam2Z.Name = "numCam2Z";
            this.numCam2Z.Size = new System.Drawing.Size(49, 20);
            this.numCam2Z.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "&X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "&Z";
            // 
            // trackCam2X
            // 
            this.trackCam2X.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackCam2X.AutoSize = false;
            this.trackCam2X.Location = new System.Drawing.Point(56, 4);
            this.trackCam2X.Maximum = 100;
            this.trackCam2X.Minimum = -100;
            this.trackCam2X.Name = "trackCam2X";
            this.trackCam2X.Size = new System.Drawing.Size(108, 24);
            this.trackCam2X.TabIndex = 1;
            this.trackCam2X.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackCam2Z
            // 
            this.trackCam2Z.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackCam2Z.AutoSize = false;
            this.trackCam2Z.Location = new System.Drawing.Point(56, 64);
            this.trackCam2Z.Maximum = 100;
            this.trackCam2Z.Minimum = -100;
            this.trackCam2Z.Name = "trackCam2Z";
            this.trackCam2Z.Size = new System.Drawing.Size(108, 24);
            this.trackCam2Z.TabIndex = 7;
            this.trackCam2Z.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // numCam2Y
            // 
            this.numCam2Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCam2Y.DecimalPlaces = 1;
            this.numCam2Y.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCam2Y.Location = new System.Drawing.Point(163, 34);
            this.numCam2Y.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCam2Y.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numCam2Y.Name = "numCam2Y";
            this.numCam2Y.Size = new System.Drawing.Size(49, 20);
            this.numCam2Y.TabIndex = 5;
            // 
            // trackCam2Y
            // 
            this.trackCam2Y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackCam2Y.AutoSize = false;
            this.trackCam2Y.Location = new System.Drawing.Point(56, 34);
            this.trackCam2Y.Maximum = 100;
            this.trackCam2Y.Minimum = -100;
            this.trackCam2Y.Name = "trackCam2Y";
            this.trackCam2Y.Size = new System.Drawing.Size(108, 24);
            this.trackCam2Y.TabIndex = 4;
            this.trackCam2Y.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "&Y";
            // 
            // labelRuler12
            // 
            this.labelRuler12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRuler12.Location = new System.Drawing.Point(0, 58);
            this.labelRuler12.Name = "labelRuler12";
            this.labelRuler12.Size = new System.Drawing.Size(218, 13);
            this.labelRuler12.TabIndex = 2;
            // 
            // chkCam2Customize
            // 
            this.chkCam2Customize.AutoSize = true;
            this.chkCam2Customize.Location = new System.Drawing.Point(19, 30);
            this.chkCam2Customize.Name = "chkCam2Customize";
            this.chkCam2Customize.Size = new System.Drawing.Size(74, 17);
            this.chkCam2Customize.TabIndex = 1;
            this.chkCam2Customize.Text = "&Customize";
            this.chkCam2Customize.UseVisualStyleBackColor = true;
            // 
            // labelRuler11
            // 
            this.labelRuler11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRuler11.Location = new System.Drawing.Point(0, 0);
            this.labelRuler11.Name = "labelRuler11";
            this.labelRuler11.Size = new System.Drawing.Size(218, 13);
            this.labelRuler11.TabIndex = 0;
            this.labelRuler11.Text = "Shooter View";
            // 
            // pageInput
            // 
            this.pageInput.Controls.Add(this.hkselToggleMode);
            this.pageInput.Controls.Add(this.label10);
            this.pageInput.Controls.Add(this.labelRuler2);
            this.pageInput.Controls.Add(this.numRunInputScale);
            this.pageInput.Controls.Add(this.label1);
            this.pageInput.Controls.Add(this.trackRunInputScale);
            this.pageInput.Controls.Add(this.numWalkInputScale);
            this.pageInput.Controls.Add(this.tableLayoutPanel1);
            this.pageInput.Controls.Add(this.label8);
            this.pageInput.Controls.Add(this.labelRuler1);
            this.pageInput.Controls.Add(this.trackWalkInputScale);
            this.pageInput.Location = new System.Drawing.Point(0, 0);
            this.pageInput.Name = "pageInput";
            this.pageInput.Padding = new System.Windows.Forms.Padding(3);
            this.pageInput.Size = new System.Drawing.Size(218, 251);
            this.pageInput.TabIndex = 4;
            this.pageInput.Text = "Inp";
            // 
            // hkselToggleMode
            // 
            this.hkselToggleMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hkselToggleMode.Location = new System.Drawing.Point(80, 218);
            this.hkselToggleMode.MinimumSize = new System.Drawing.Size(0, 21);
            this.hkselToggleMode.Name = "hkselToggleMode";
            this.hkselToggleMode.Size = new System.Drawing.Size(132, 21);
            this.hkselToggleMode.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Toggle Mode";
            // 
            // labelRuler2
            // 
            this.labelRuler2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRuler2.Location = new System.Drawing.Point(0, 199);
            this.labelRuler2.Name = "labelRuler2";
            this.labelRuler2.Size = new System.Drawing.Size(218, 13);
            this.labelRuler2.TabIndex = 8;
            this.labelRuler2.Text = "Keys";
            // 
            // numRunInputScale
            // 
            this.numRunInputScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numRunInputScale.DecimalPlaces = 2;
            this.numRunInputScale.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numRunInputScale.Location = new System.Drawing.Point(163, 132);
            this.numRunInputScale.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRunInputScale.Name = "numRunInputScale";
            this.numRunInputScale.Size = new System.Drawing.Size(49, 20);
            this.numRunInputScale.TabIndex = 7;
            this.numRunInputScale.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "&Run Input Scale";
            // 
            // trackRunInputScale
            // 
            this.trackRunInputScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackRunInputScale.AutoSize = false;
            this.trackRunInputScale.Location = new System.Drawing.Point(6, 132);
            this.trackRunInputScale.Maximum = 100;
            this.trackRunInputScale.Name = "trackRunInputScale";
            this.trackRunInputScale.Size = new System.Drawing.Size(151, 24);
            this.trackRunInputScale.TabIndex = 6;
            this.trackRunInputScale.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackRunInputScale.Value = 100;
            // 
            // numWalkInputScale
            // 
            this.numWalkInputScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numWalkInputScale.DecimalPlaces = 2;
            this.numWalkInputScale.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numWalkInputScale.Location = new System.Drawing.Point(163, 89);
            this.numWalkInputScale.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWalkInputScale.Name = "numWalkInputScale";
            this.numWalkInputScale.Size = new System.Drawing.Size(49, 20);
            this.numWalkInputScale.TabIndex = 4;
            this.numWalkInputScale.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.radWalking, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radRunning, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 24);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // radWalking
            // 
            this.radWalking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radWalking.Appearance = System.Windows.Forms.Appearance.Button;
            this.radWalking.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radWalking.Location = new System.Drawing.Point(0, 0);
            this.radWalking.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.radWalking.Name = "radWalking";
            this.radWalking.Size = new System.Drawing.Size(100, 24);
            this.radWalking.TabIndex = 0;
            this.radWalking.Text = "&Walking";
            this.radWalking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radWalking.UseVisualStyleBackColor = true;
            this.radWalking.CheckedChanged += new System.EventHandler(this.radWalkingRunning_CheckedChanged);
            // 
            // radRunning
            // 
            this.radRunning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radRunning.Appearance = System.Windows.Forms.Appearance.Button;
            this.radRunning.Checked = true;
            this.radRunning.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radRunning.Location = new System.Drawing.Point(106, 0);
            this.radRunning.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.radRunning.Name = "radRunning";
            this.radRunning.Size = new System.Drawing.Size(100, 24);
            this.radRunning.TabIndex = 1;
            this.radRunning.TabStop = true;
            this.radRunning.Text = "&Running";
            this.radRunning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radRunning.UseVisualStyleBackColor = true;
            this.radRunning.CheckedChanged += new System.EventHandler(this.radWalkingRunning_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "&Walk Input Scale";
            // 
            // labelRuler1
            // 
            this.labelRuler1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRuler1.Location = new System.Drawing.Point(0, 0);
            this.labelRuler1.Name = "labelRuler1";
            this.labelRuler1.Size = new System.Drawing.Size(218, 13);
            this.labelRuler1.TabIndex = 0;
            this.labelRuler1.Text = "Movement";
            // 
            // trackWalkInputScale
            // 
            this.trackWalkInputScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackWalkInputScale.AutoSize = false;
            this.trackWalkInputScale.Location = new System.Drawing.Point(6, 89);
            this.trackWalkInputScale.Maximum = 100;
            this.trackWalkInputScale.Name = "trackWalkInputScale";
            this.trackWalkInputScale.Size = new System.Drawing.Size(151, 24);
            this.trackWalkInputScale.TabIndex = 3;
            this.trackWalkInputScale.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackWalkInputScale.Value = 100;
            // 
            // pageUI
            // 
            this.pageUI.Controls.Add(this.chkHideEmergencyCodes);
            this.pageUI.Controls.Add(this.chkHideScreenNotifications);
            this.pageUI.Controls.Add(this.hkselHideUI);
            this.pageUI.Controls.Add(this.label2);
            this.pageUI.Controls.Add(this.labelRuler4);
            this.pageUI.Controls.Add(this.chkHideAllUI);
            this.pageUI.Controls.Add(this.chkHideHud);
            this.pageUI.Controls.Add(this.labelRuler3);
            this.pageUI.Controls.Add(this.chkHideCommandPalette);
            this.pageUI.Location = new System.Drawing.Point(0, 0);
            this.pageUI.Name = "pageUI";
            this.pageUI.Size = new System.Drawing.Size(218, 251);
            this.pageUI.TabIndex = 5;
            this.pageUI.Text = "UI";
            // 
            // chkHideEmergencyCodes
            // 
            this.chkHideEmergencyCodes.AutoSize = true;
            this.chkHideEmergencyCodes.Location = new System.Drawing.Point(20, 93);
            this.chkHideEmergencyCodes.Name = "chkHideEmergencyCodes";
            this.chkHideEmergencyCodes.Size = new System.Drawing.Size(137, 17);
            this.chkHideEmergencyCodes.TabIndex = 4;
            this.chkHideEmergencyCodes.Text = "Hide &Emergency Codes";
            this.chkHideEmergencyCodes.UseVisualStyleBackColor = true;
            // 
            // chkHideScreenNotifications
            // 
            this.chkHideScreenNotifications.AutoSize = true;
            this.chkHideScreenNotifications.Location = new System.Drawing.Point(20, 70);
            this.chkHideScreenNotifications.Name = "chkHideScreenNotifications";
            this.chkHideScreenNotifications.Size = new System.Drawing.Size(146, 17);
            this.chkHideScreenNotifications.TabIndex = 3;
            this.chkHideScreenNotifications.Text = "Hide &Screen Notifications";
            this.chkHideScreenNotifications.UseVisualStyleBackColor = true;
            // 
            // hkselHideUI
            // 
            this.hkselHideUI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hkselHideUI.Location = new System.Drawing.Point(80, 218);
            this.hkselHideUI.MinimumSize = new System.Drawing.Size(0, 21);
            this.hkselHideUI.Name = "hkselHideUI";
            this.hkselHideUI.Size = new System.Drawing.Size(132, 21);
            this.hkselHideUI.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hide All UI";
            // 
            // labelRuler4
            // 
            this.labelRuler4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRuler4.Location = new System.Drawing.Point(0, 199);
            this.labelRuler4.Name = "labelRuler4";
            this.labelRuler4.Size = new System.Drawing.Size(218, 13);
            this.labelRuler4.TabIndex = 4;
            this.labelRuler4.Text = "Keys";
            // 
            // chkHideAllUI
            // 
            this.chkHideAllUI.AutoSize = true;
            this.chkHideAllUI.Location = new System.Drawing.Point(20, 24);
            this.chkHideAllUI.Name = "chkHideAllUI";
            this.chkHideAllUI.Size = new System.Drawing.Size(62, 17);
            this.chkHideAllUI.TabIndex = 1;
            this.chkHideAllUI.Text = "Hide &All";
            this.chkHideAllUI.UseVisualStyleBackColor = true;
            // 
            // chkHideHud
            // 
            this.chkHideHud.AutoSize = true;
            this.chkHideHud.Location = new System.Drawing.Point(20, 176);
            this.chkHideHud.Name = "chkHideHud";
            this.chkHideHud.Size = new System.Drawing.Size(71, 17);
            this.chkHideHud.TabIndex = 0;
            this.chkHideHud.Text = "Hide &Hud";
            this.chkHideHud.UseVisualStyleBackColor = true;
            this.chkHideHud.Visible = false;
            // 
            // labelRuler3
            // 
            this.labelRuler3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRuler3.Location = new System.Drawing.Point(0, 0);
            this.labelRuler3.Name = "labelRuler3";
            this.labelRuler3.Size = new System.Drawing.Size(218, 13);
            this.labelRuler3.TabIndex = 0;
            this.labelRuler3.Text = "UI Adjustments";
            // 
            // chkHideCommandPalette
            // 
            this.chkHideCommandPalette.AutoSize = true;
            this.chkHideCommandPalette.Location = new System.Drawing.Point(20, 47);
            this.chkHideCommandPalette.Name = "chkHideCommandPalette";
            this.chkHideCommandPalette.Size = new System.Drawing.Size(134, 17);
            this.chkHideCommandPalette.TabIndex = 2;
            this.chkHideCommandPalette.Text = "Hide &Command Palette";
            this.chkHideCommandPalette.UseVisualStyleBackColor = true;
            // 
            // pageColors
            // 
            this.pageColors.Controls.Add(this.pnlCustomizeColors);
            this.pageColors.Controls.Add(this.btnResetColors);
            this.pageColors.Controls.Add(this.labelRuler15);
            this.pageColors.Controls.Add(this.chkCustomizeColors);
            this.pageColors.Controls.Add(this.labelRuler16);
            this.pageColors.Location = new System.Drawing.Point(0, 0);
            this.pageColors.Name = "pageColors";
            this.pageColors.Size = new System.Drawing.Size(218, 251);
            this.pageColors.TabIndex = 10;
            this.pageColors.Text = "Colors";
            // 
            // pnlCustomizeColors
            // 
            this.pnlCustomizeColors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomizeColors.Controls.Add(this.numBlueBalance);
            this.pnlCustomizeColors.Controls.Add(this.label21);
            this.pnlCustomizeColors.Controls.Add(this.trackBlueBalance);
            this.pnlCustomizeColors.Controls.Add(this.numGreenBalance);
            this.pnlCustomizeColors.Controls.Add(this.label20);
            this.pnlCustomizeColors.Controls.Add(this.trackGreenBalance);
            this.pnlCustomizeColors.Controls.Add(this.numRedBalance);
            this.pnlCustomizeColors.Controls.Add(this.label19);
            this.pnlCustomizeColors.Controls.Add(this.trackRedBalance);
            this.pnlCustomizeColors.Controls.Add(this.numSaturation);
            this.pnlCustomizeColors.Controls.Add(this.label18);
            this.pnlCustomizeColors.Controls.Add(this.trackSaturation);
            this.pnlCustomizeColors.Controls.Add(this.numContrast);
            this.pnlCustomizeColors.Controls.Add(this.label16);
            this.pnlCustomizeColors.Controls.Add(this.trackContrast);
            this.pnlCustomizeColors.Controls.Add(this.numBrightness);
            this.pnlCustomizeColors.Controls.Add(this.label17);
            this.pnlCustomizeColors.Controls.Add(this.trackBrightness);
            this.pnlCustomizeColors.Location = new System.Drawing.Point(0, 78);
            this.pnlCustomizeColors.Name = "pnlCustomizeColors";
            this.pnlCustomizeColors.Size = new System.Drawing.Size(218, 170);
            this.pnlCustomizeColors.TabIndex = 4;
            // 
            // numBlueBalance
            // 
            this.numBlueBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numBlueBalance.DecimalPlaces = 2;
            this.numBlueBalance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numBlueBalance.Location = new System.Drawing.Point(163, 138);
            this.numBlueBalance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBlueBalance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numBlueBalance.Name = "numBlueBalance";
            this.numBlueBalance.Size = new System.Drawing.Size(49, 20);
            this.numBlueBalance.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 140);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Bl&ue";
            // 
            // trackBlueBalance
            // 
            this.trackBlueBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBlueBalance.AutoSize = false;
            this.trackBlueBalance.Location = new System.Drawing.Point(56, 138);
            this.trackBlueBalance.Maximum = 100;
            this.trackBlueBalance.Minimum = -100;
            this.trackBlueBalance.Name = "trackBlueBalance";
            this.trackBlueBalance.Size = new System.Drawing.Size(108, 24);
            this.trackBlueBalance.TabIndex = 16;
            this.trackBlueBalance.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // numGreenBalance
            // 
            this.numGreenBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numGreenBalance.DecimalPlaces = 2;
            this.numGreenBalance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numGreenBalance.Location = new System.Drawing.Point(163, 112);
            this.numGreenBalance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGreenBalance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numGreenBalance.Name = "numGreenBalance";
            this.numGreenBalance.Size = new System.Drawing.Size(49, 20);
            this.numGreenBalance.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "&Green";
            // 
            // trackGreenBalance
            // 
            this.trackGreenBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackGreenBalance.AutoSize = false;
            this.trackGreenBalance.Location = new System.Drawing.Point(56, 112);
            this.trackGreenBalance.Maximum = 100;
            this.trackGreenBalance.Minimum = -100;
            this.trackGreenBalance.Name = "trackGreenBalance";
            this.trackGreenBalance.Size = new System.Drawing.Size(108, 24);
            this.trackGreenBalance.TabIndex = 13;
            this.trackGreenBalance.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // numRedBalance
            // 
            this.numRedBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numRedBalance.DecimalPlaces = 2;
            this.numRedBalance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numRedBalance.Location = new System.Drawing.Point(163, 86);
            this.numRedBalance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRedBalance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numRedBalance.Name = "numRedBalance";
            this.numRedBalance.Size = new System.Drawing.Size(49, 20);
            this.numRedBalance.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "R&ed";
            // 
            // trackRedBalance
            // 
            this.trackRedBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackRedBalance.AutoSize = false;
            this.trackRedBalance.Location = new System.Drawing.Point(56, 86);
            this.trackRedBalance.Maximum = 100;
            this.trackRedBalance.Minimum = -100;
            this.trackRedBalance.Name = "trackRedBalance";
            this.trackRedBalance.Size = new System.Drawing.Size(108, 24);
            this.trackRedBalance.TabIndex = 10;
            this.trackRedBalance.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // numSaturation
            // 
            this.numSaturation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSaturation.DecimalPlaces = 2;
            this.numSaturation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSaturation.Location = new System.Drawing.Point(163, 56);
            this.numSaturation.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSaturation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numSaturation.Name = "numSaturation";
            this.numSaturation.Size = new System.Drawing.Size(49, 20);
            this.numSaturation.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "&Saturation";
            // 
            // trackSaturation
            // 
            this.trackSaturation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackSaturation.AutoSize = false;
            this.trackSaturation.Location = new System.Drawing.Point(56, 56);
            this.trackSaturation.Maximum = 100;
            this.trackSaturation.Minimum = -100;
            this.trackSaturation.Name = "trackSaturation";
            this.trackSaturation.Size = new System.Drawing.Size(108, 24);
            this.trackSaturation.TabIndex = 7;
            this.trackSaturation.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // numContrast
            // 
            this.numContrast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numContrast.DecimalPlaces = 2;
            this.numContrast.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numContrast.Location = new System.Drawing.Point(163, 30);
            this.numContrast.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numContrast.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numContrast.Name = "numContrast";
            this.numContrast.Size = new System.Drawing.Size(49, 20);
            this.numContrast.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "C&ontrast";
            // 
            // trackContrast
            // 
            this.trackContrast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackContrast.AutoSize = false;
            this.trackContrast.Location = new System.Drawing.Point(56, 30);
            this.trackContrast.Maximum = 100;
            this.trackContrast.Minimum = -100;
            this.trackContrast.Name = "trackContrast";
            this.trackContrast.Size = new System.Drawing.Size(108, 24);
            this.trackContrast.TabIndex = 4;
            this.trackContrast.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // numBrightness
            // 
            this.numBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numBrightness.DecimalPlaces = 2;
            this.numBrightness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numBrightness.Location = new System.Drawing.Point(163, 4);
            this.numBrightness.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBrightness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numBrightness.Name = "numBrightness";
            this.numBrightness.Size = new System.Drawing.Size(49, 20);
            this.numBrightness.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "&Brightness";
            // 
            // trackBrightness
            // 
            this.trackBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBrightness.AutoSize = false;
            this.trackBrightness.Location = new System.Drawing.Point(56, 4);
            this.trackBrightness.Maximum = 100;
            this.trackBrightness.Minimum = -100;
            this.trackBrightness.Name = "trackBrightness";
            this.trackBrightness.Size = new System.Drawing.Size(108, 24);
            this.trackBrightness.TabIndex = 1;
            this.trackBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // btnResetColors
            // 
            this.btnResetColors.Location = new System.Drawing.Point(151, 26);
            this.btnResetColors.Name = "btnResetColors";
            this.btnResetColors.Size = new System.Drawing.Size(49, 23);
            this.btnResetColors.TabIndex = 2;
            this.btnResetColors.Text = "&Reset";
            this.btnResetColors.UseVisualStyleBackColor = true;
            this.btnResetColors.Click += new System.EventHandler(this.btnResetColors_Click);
            // 
            // labelRuler15
            // 
            this.labelRuler15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRuler15.Location = new System.Drawing.Point(0, 58);
            this.labelRuler15.Name = "labelRuler15";
            this.labelRuler15.Size = new System.Drawing.Size(218, 13);
            this.labelRuler15.TabIndex = 3;
            // 
            // chkCustomizeColors
            // 
            this.chkCustomizeColors.AutoSize = true;
            this.chkCustomizeColors.Location = new System.Drawing.Point(19, 30);
            this.chkCustomizeColors.Name = "chkCustomizeColors";
            this.chkCustomizeColors.Size = new System.Drawing.Size(74, 17);
            this.chkCustomizeColors.TabIndex = 1;
            this.chkCustomizeColors.Text = "&Customize";
            this.chkCustomizeColors.UseVisualStyleBackColor = true;
            // 
            // labelRuler16
            // 
            this.labelRuler16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRuler16.Location = new System.Drawing.Point(0, 0);
            this.labelRuler16.Name = "labelRuler16";
            this.labelRuler16.Size = new System.Drawing.Size(218, 13);
            this.labelRuler16.TabIndex = 0;
            this.labelRuler16.Text = "Colors";
            // 
            // pagePreferences
            // 
            this.pagePreferences.Controls.Add(this.chkPromptOnUpdate);
            this.pagePreferences.Controls.Add(this.chkAutomaticUpdates);
            this.pagePreferences.Controls.Add(this.labelRuler14);
            this.pagePreferences.Controls.Add(this.chkCloseToTray);
            this.pagePreferences.Controls.Add(this.chkMinimzeToTray);
            this.pagePreferences.Controls.Add(this.labelRuler13);
            this.pagePreferences.Location = new System.Drawing.Point(0, 0);
            this.pagePreferences.Name = "pagePreferences";
            this.pagePreferences.Padding = new System.Windows.Forms.Padding(3);
            this.pagePreferences.Size = new System.Drawing.Size(218, 251);
            this.pagePreferences.TabIndex = 9;
            this.pagePreferences.Text = "Preferences";
            // 
            // chkPromptOnUpdate
            // 
            this.chkPromptOnUpdate.AutoSize = true;
            this.chkPromptOnUpdate.Location = new System.Drawing.Point(20, 99);
            this.chkPromptOnUpdate.Name = "chkPromptOnUpdate";
            this.chkPromptOnUpdate.Size = new System.Drawing.Size(114, 17);
            this.chkPromptOnUpdate.TabIndex = 5;
            this.chkPromptOnUpdate.Text = "&Prompt On Update";
            this.chkPromptOnUpdate.UseVisualStyleBackColor = true;
            // 
            // chkAutomaticUpdates
            // 
            this.chkAutomaticUpdates.AutoSize = true;
            this.chkAutomaticUpdates.Location = new System.Drawing.Point(20, 76);
            this.chkAutomaticUpdates.Name = "chkAutomaticUpdates";
            this.chkAutomaticUpdates.Size = new System.Drawing.Size(116, 17);
            this.chkAutomaticUpdates.TabIndex = 4;
            this.chkAutomaticUpdates.Text = "&Automatic Updates";
            this.chkAutomaticUpdates.UseVisualStyleBackColor = true;
            // 
            // labelRuler14
            // 
            this.labelRuler14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRuler14.Location = new System.Drawing.Point(0, 122);
            this.labelRuler14.Name = "labelRuler14";
            this.labelRuler14.Size = new System.Drawing.Size(218, 13);
            this.labelRuler14.TabIndex = 3;
            // 
            // chkCloseToTray
            // 
            this.chkCloseToTray.AutoSize = true;
            this.chkCloseToTray.Location = new System.Drawing.Point(20, 47);
            this.chkCloseToTray.Name = "chkCloseToTray";
            this.chkCloseToTray.Size = new System.Drawing.Size(88, 17);
            this.chkCloseToTray.TabIndex = 2;
            this.chkCloseToTray.Text = "&Close to Tray";
            this.chkCloseToTray.UseVisualStyleBackColor = true;
            // 
            // chkMinimzeToTray
            // 
            this.chkMinimzeToTray.AutoSize = true;
            this.chkMinimzeToTray.Location = new System.Drawing.Point(20, 24);
            this.chkMinimzeToTray.Name = "chkMinimzeToTray";
            this.chkMinimzeToTray.Size = new System.Drawing.Size(102, 17);
            this.chkMinimzeToTray.TabIndex = 1;
            this.chkMinimzeToTray.Text = "&Minimize to Tray";
            this.chkMinimzeToTray.UseVisualStyleBackColor = true;
            // 
            // labelRuler13
            // 
            this.labelRuler13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRuler13.Location = new System.Drawing.Point(0, 0);
            this.labelRuler13.Name = "labelRuler13";
            this.labelRuler13.Size = new System.Drawing.Size(218, 13);
            this.labelRuler13.TabIndex = 0;
            this.labelRuler13.Text = "Preferences";
            // 
            // pageInfo
            // 
            this.pageInfo.Controls.Add(this.txtLog);
            this.pageInfo.Controls.Add(this.btnInfoMenu);
            this.pageInfo.Location = new System.Drawing.Point(0, 0);
            this.pageInfo.Name = "pageInfo";
            this.pageInfo.Size = new System.Drawing.Size(218, 251);
            this.pageInfo.TabIndex = 3;
            this.pageInfo.Text = "Info";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(218, 235);
            this.txtLog.TabIndex = 0;
            this.txtLog.WordWrap = false;
            // 
            // btnInfoMenu
            // 
            this.btnInfoMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoMenu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInfoMenu.Location = new System.Drawing.Point(144, 234);
            this.btnInfoMenu.Name = "btnInfoMenu";
            this.btnInfoMenu.Size = new System.Drawing.Size(75, 17);
            this.btnInfoMenu.TabIndex = 1;
            this.btnInfoMenu.Text = "&v";
            this.btnInfoMenu.UseVisualStyleBackColor = true;
            this.btnInfoMenu.Click += new System.EventHandler(this.btnInfoMenu_Click);
            // 
            // pageFOV
            // 
            this.pageFOV.Controls.Add(this.label13);
            this.pageFOV.Controls.Add(this.numFovNPCTalk);
            this.pageFOV.Controls.Add(this.trackFovNPCTalk);
            this.pageFOV.Controls.Add(this.label11);
            this.pageFOV.Controls.Add(this.numFovTPS);
            this.pageFOV.Controls.Add(this.trackFovTPS);
            this.pageFOV.Controls.Add(this.label9);
            this.pageFOV.Controls.Add(this.numFovNormal);
            this.pageFOV.Controls.Add(this.trackFovNormal);
            this.pageFOV.Controls.Add(this.labelRuler8);
            this.pageFOV.Controls.Add(this.labelRuler7);
            this.pageFOV.Location = new System.Drawing.Point(0, 0);
            this.pageFOV.Name = "pageFOV";
            this.pageFOV.Size = new System.Drawing.Size(218, 251);
            this.pageFOV.TabIndex = 7;
            this.pageFOV.Text = "FOV";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "&NPC Talk";
            // 
            // numFovNPCTalk
            // 
            this.numFovNPCTalk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numFovNPCTalk.DecimalPlaces = 1;
            this.numFovNPCTalk.Location = new System.Drawing.Point(163, 91);
            this.numFovNPCTalk.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numFovNPCTalk.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numFovNPCTalk.Name = "numFovNPCTalk";
            this.numFovNPCTalk.Size = new System.Drawing.Size(49, 20);
            this.numFovNPCTalk.TabIndex = 14;
            this.numFovNPCTalk.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // trackFovNPCTalk
            // 
            this.trackFovNPCTalk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackFovNPCTalk.AutoSize = false;
            this.trackFovNPCTalk.Location = new System.Drawing.Point(56, 91);
            this.trackFovNPCTalk.Maximum = 180;
            this.trackFovNPCTalk.Minimum = 15;
            this.trackFovNPCTalk.Name = "trackFovNPCTalk";
            this.trackFovNPCTalk.Size = new System.Drawing.Size(108, 24);
            this.trackFovNPCTalk.TabIndex = 13;
            this.trackFovNPCTalk.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackFovNPCTalk.Value = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "&TPS";
            // 
            // numFovTPS
            // 
            this.numFovTPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numFovTPS.DecimalPlaces = 1;
            this.numFovTPS.Location = new System.Drawing.Point(163, 61);
            this.numFovTPS.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numFovTPS.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numFovTPS.Name = "numFovTPS";
            this.numFovTPS.Size = new System.Drawing.Size(49, 20);
            this.numFovTPS.TabIndex = 8;
            this.numFovTPS.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // trackFovTPS
            // 
            this.trackFovTPS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackFovTPS.AutoSize = false;
            this.trackFovTPS.Location = new System.Drawing.Point(56, 61);
            this.trackFovTPS.Maximum = 180;
            this.trackFovTPS.Minimum = 15;
            this.trackFovTPS.Name = "trackFovTPS";
            this.trackFovTPS.Size = new System.Drawing.Size(108, 24);
            this.trackFovTPS.TabIndex = 7;
            this.trackFovTPS.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackFovTPS.Value = 100;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "&Normal";
            // 
            // numFovNormal
            // 
            this.numFovNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numFovNormal.DecimalPlaces = 1;
            this.numFovNormal.Location = new System.Drawing.Point(163, 31);
            this.numFovNormal.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numFovNormal.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numFovNormal.Name = "numFovNormal";
            this.numFovNormal.Size = new System.Drawing.Size(49, 20);
            this.numFovNormal.TabIndex = 5;
            this.numFovNormal.Value = new decimal(new int[] {
            44,
            0,
            0,
            0});
            // 
            // trackFovNormal
            // 
            this.trackFovNormal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackFovNormal.AutoSize = false;
            this.trackFovNormal.Location = new System.Drawing.Point(56, 31);
            this.trackFovNormal.Maximum = 180;
            this.trackFovNormal.Minimum = 15;
            this.trackFovNormal.Name = "trackFovNormal";
            this.trackFovNormal.Size = new System.Drawing.Size(108, 24);
            this.trackFovNormal.TabIndex = 4;
            this.trackFovNormal.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackFovNormal.Value = 100;
            // 
            // labelRuler8
            // 
            this.labelRuler8.Location = new System.Drawing.Point(0, 165);
            this.labelRuler8.Name = "labelRuler8";
            this.labelRuler8.Size = new System.Drawing.Size(218, 13);
            this.labelRuler8.TabIndex = 1;
            // 
            // labelRuler7
            // 
            this.labelRuler7.Location = new System.Drawing.Point(0, 0);
            this.labelRuler7.Name = "labelRuler7";
            this.labelRuler7.Size = new System.Drawing.Size(218, 13);
            this.labelRuler7.TabIndex = 0;
            this.labelRuler7.Text = "Field of View";
            // 
            // pageBlank
            // 
            this.pageBlank.Location = new System.Drawing.Point(0, 0);
            this.pageBlank.Name = "pageBlank";
            this.pageBlank.Padding = new System.Windows.Forms.Padding(3);
            this.pageBlank.Size = new System.Drawing.Size(218, 251);
            this.pageBlank.TabIndex = 6;
            this.pageBlank.Text = "Blank";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(13, 300);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(343, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // tmrAppUpdate
            // 
            this.tmrAppUpdate.Interval = 5000;
            this.tmrAppUpdate.Tick += new System.EventHandler(this.tmrAppUpdate_Tick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProjectPageToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(174, 48);
            // 
            // openProjectPageToolStripMenuItem
            // 
            this.openProjectPageToolStripMenuItem.Name = "openProjectPageToolStripMenuItem";
            this.openProjectPageToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openProjectPageToolStripMenuItem.Text = "&Open Project Page";
            this.openProjectPageToolStripMenuItem.Click += new System.EventHandler(this.openProjectPageToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "&Check For Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // upclientForeground
            // 
            this.upclientForeground.TimeStampFile = "time.txt";
            this.upclientForeground.UpdateFile = "ArksModTool.zip";
            this.upclientForeground.UpdateServer = null;
            this.upclientForeground.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(this.upclientForeground_DownloadProgressChanged);
            // 
            // upclientBackground
            // 
            this.upclientBackground.TimeStampFile = "time.txt";
            this.upclientBackground.UpdateFile = "ArksModTool.zip";
            this.upclientBackground.UpdateServer = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 329);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.popupPanel1);
            this.Controls.Add(this.pageControl1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.ruler1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(385, 368);
            this.Name = "Form1";
            this.Text = "Arks Mod Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.popupPanel1.ResumeLayout(false);
            this.pageControl1.ResumeLayout(false);
            this.pageGeneral.ResumeLayout(false);
            this.pageGeneral.PerformLayout();
            this.pageCamera1.ResumeLayout(false);
            this.pageCamera1.PerformLayout();
            this.pnlCam1Customize.ResumeLayout(false);
            this.pnlCam1Customize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCam1Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam1Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCam1Distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam1Distance)).EndInit();
            this.pageCamera2.ResumeLayout(false);
            this.pageCamera2.PerformLayout();
            this.pnlCam2Customize.ResumeLayout(false);
            this.pnlCam2Customize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCam2Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam2Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCam2Pitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam2Pitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCam2Yaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam2Yaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCam2X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCam2Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam2X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam2Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCam2Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCam2Y)).EndInit();
            this.pageInput.ResumeLayout(false);
            this.pageInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRunInputScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRunInputScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWalkInputScale)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackWalkInputScale)).EndInit();
            this.pageUI.ResumeLayout(false);
            this.pageUI.PerformLayout();
            this.pageColors.ResumeLayout(false);
            this.pageColors.PerformLayout();
            this.pnlCustomizeColors.ResumeLayout(false);
            this.pnlCustomizeColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlueBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreenBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreenBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRedBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRedBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).EndInit();
            this.pagePreferences.ResumeLayout(false);
            this.pagePreferences.PerformLayout();
            this.pageInfo.ResumeLayout(false);
            this.pageInfo.PerformLayout();
            this.pageFOV.ResumeLayout(false);
            this.pageFOV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFovNPCTalk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFovNPCTalk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFovTPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFovTPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFovNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFovNormal)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label ruler1;
        private System.Windows.Forms.Label lblVersion;
        private ArksModTool.PageControl pageControl1;
        private System.Windows.Forms.TabPage pageGeneral;
        private System.Windows.Forms.TabPage pageCamera1;
        private System.Windows.Forms.TabPage pageInfo;
        private System.Windows.Forms.TabPage pageInput;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox chkDisableFarCulling;
        private System.Windows.Forms.CheckBox chkDisableNearCulling;
        private System.Windows.Forms.CheckBox chkDisableIntro;
        private System.Windows.Forms.TextBox txtLog;
        private ArksModTool.LabelRuler labelRuler1;
        private System.Windows.Forms.TrackBar trackWalkInputScale;
        private System.Windows.Forms.RadioButton radWalking;
        private System.Windows.Forms.RadioButton radRunning;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer tmrScan;
        private System.Windows.Forms.Timer tmrCommunicationUpdate;
        private System.Windows.Forms.NumericUpDown numWalkInputScale;
        private System.Windows.Forms.NumericUpDown numRunInputScale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackRunInputScale;
        private System.Windows.Forms.CheckBox chkDisableUpdateCulling;
        private System.Windows.Forms.TabPage pageUI;
        private ArksModTool.LabelRuler labelRuler4;
        private System.Windows.Forms.CheckBox chkHideAllUI;
        private System.Windows.Forms.CheckBox chkHideHud;
        private ArksModTool.LabelRuler labelRuler3;
        private System.Windows.Forms.CheckBox chkHideCommandPalette;
        private PopupPanel popupPanel1;
        private System.Windows.Forms.TabPage pageBlank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private LabelRuler labelRuler2;
        private HotkeyPanel hotkeyPanel1;
        private LabelRuler labelRuler5;
        private LabelRuler labelRuler6;
        private HotkeySelector hkselToggleMode;
        private HotkeySelector hkselHideUI;
        private System.Windows.Forms.CheckBox chkDisableLODReduction;
        private System.Windows.Forms.TabPage pageFOV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numFovTPS;
        private System.Windows.Forms.TrackBar trackFovTPS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numFovNormal;
        private System.Windows.Forms.TrackBar trackFovNormal;
        private LabelRuler labelRuler8;
        private LabelRuler labelRuler7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numFovNPCTalk;
        private System.Windows.Forms.TrackBar trackFovNPCTalk;
        private System.Windows.Forms.CheckBox chkHideScreenNotifications;
        private System.Windows.Forms.CheckBox chkHideEmergencyCodes;
        private System.Windows.Forms.TabPage pageCamera2;
        private System.Windows.Forms.CheckBox chkCam1Customize;
        private LabelRuler labelRuler9;
        private System.Windows.Forms.NumericUpDown numCam2Z;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackCam2Z;
        private System.Windows.Forms.NumericUpDown numCam2Y;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackCam2Y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCam2X;
        private System.Windows.Forms.TrackBar trackCam2X;
        private System.Windows.Forms.NumericUpDown numCam1Distance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackCam1Distance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCam1Height;
        private System.Windows.Forms.TrackBar trackCam1Height;
        private ArksModTool.BufferedPanel pnlCam1Customize;
        private LabelRuler labelRuler10;
        private LabelRuler labelRuler12;
        private System.Windows.Forms.CheckBox chkCam2Customize;
        private LabelRuler labelRuler11;
        private ArksModTool.BufferedPanel pnlCam2Customize;
        private System.Windows.Forms.NumericUpDown numCam2Pitch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackCam2Pitch;
        private System.Windows.Forms.NumericUpDown numCam2Yaw;
        private System.Windows.Forms.TrackBar trackCam2Yaw;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numCam2Height;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TrackBar trackCam2Height;
        private System.Windows.Forms.Button btnCam1Reset;
        private System.Windows.Forms.Button btnCam2Reset;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage pagePreferences;
        private LabelRuler labelRuler14;
        private System.Windows.Forms.CheckBox chkCloseToTray;
        private System.Windows.Forms.CheckBox chkMinimzeToTray;
        private LabelRuler labelRuler13;
        private System.Windows.Forms.TabPage pageColors;
        private BufferedPanel pnlCustomizeColors;
        private System.Windows.Forms.NumericUpDown numBlueBalance;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TrackBar trackBlueBalance;
        private System.Windows.Forms.NumericUpDown numGreenBalance;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TrackBar trackGreenBalance;
        private System.Windows.Forms.NumericUpDown numRedBalance;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TrackBar trackRedBalance;
        private System.Windows.Forms.NumericUpDown numSaturation;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar trackSaturation;
        private System.Windows.Forms.NumericUpDown numContrast;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar trackContrast;
        private System.Windows.Forms.NumericUpDown numBrightness;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TrackBar trackBrightness;
        private System.Windows.Forms.Button btnResetColors;
        private LabelRuler labelRuler15;
        private System.Windows.Forms.CheckBox chkCustomizeColors;
        private LabelRuler labelRuler16;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox chkAutomaticUpdates;
        private System.Windows.Forms.CheckBox chkPromptOnUpdate;
        private System.Windows.Forms.Timer tmrAppUpdate;
        private System.Windows.Forms.Button btnInfoMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem openProjectPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private UpdateClient upclientForeground;
        private UpdateClient upclientBackground;
    }
}

