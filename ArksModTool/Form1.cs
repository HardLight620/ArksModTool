using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SharpDX;
using SharpDX.DirectInput;

using Color = System.Drawing.Color;
using Point = System.Drawing.Point;

using Resources = ArksModTool.Properties.Resources;

namespace ArksModTool
{
    public partial class Form1 : Form
    {
        public static readonly Version PSO2VERSION = new Version(4, 0502, 0, 1);
        public static readonly uint PCOMMDATA = 0x03DCCE00;
        public static readonly uint ORIGINAL_CRC = 0x423ABAD8;
        public static readonly uint PATCHED_CRC = 0xFF010981;

        private int m_pso2PID = 0;
        private IntPtr m_pso2HWND = IntPtr.Zero;
        private bool m_gameReplied = false;
        private DateTime m_lastTime = DateTime.MinValue;

        private IntPtr m_commBuffer = IntPtr.Zero;
        private IntPtr m_commBufferLocation = new IntPtr(0x48000000);
        private IntPtr m_commBufferSize = new IntPtr(0x100);

        private List<IntPtr> m_oldAllocations = new List<IntPtr>();

        private DirectInput m_directInput = null;
        private Keyboard m_keyboard = null;
        private KeyboardState m_curKeystate = null;
        private KeyboardState m_lastKeystate = null;

        public Form1()
        {
            InitializeComponent();
            InitializeComponent2();
            InitializeBindings();
            InitializeInput();
        }

        private void InitializeComponent2()
        {
            pageControl1.TabPages.Remove(pageBlank);
            pageControl1.TabPages.Remove(pageFOV);

            if (uxtheme.IsAvailable())
                uxtheme.SetWindowTheme(treeView1.Handle, "explorer", null);

            const uint TBS_DOWNISLEFT = 0x0400;
            AddStyleFlag(trackRunInputScale, TBS_DOWNISLEFT);
            AddStyleFlag(trackWalkInputScale, TBS_DOWNISLEFT);
            AddStyleFlag(trackCam1Distance, TBS_DOWNISLEFT);
            AddStyleFlag(trackCam1Height, TBS_DOWNISLEFT);
            AddStyleFlag(trackCam2X, TBS_DOWNISLEFT);
            AddStyleFlag(trackCam2Y, TBS_DOWNISLEFT);
            AddStyleFlag(trackCam2Z, TBS_DOWNISLEFT);
            AddStyleFlag(trackCam2Yaw, TBS_DOWNISLEFT);
            AddStyleFlag(trackCam2Pitch, TBS_DOWNISLEFT);
            AddStyleFlag(trackCam2Height, TBS_DOWNISLEFT);

            popupPanel1.CreateControl();

            hkselHideUI.Value = Program.Settings.HideUIHotkey;
            hkselHideUI.SetEditPanel(popupPanel1);
            hkselToggleMode.Value = Program.Settings.ToggleInputModeHotkey;
            hkselToggleMode.SetEditPanel(popupPanel1);

            upclientBackground.UpdateServer = Program.Settings.UpdateServer;
            upclientForeground.UpdateServer = Program.Settings.UpdateServer;
        }

        private void InitializeBindings()
        {
            CreateSettingBinding(chkDisableIntro, "Checked", "DisableIntroVideo");
            CreateSettingBinding(chkDisableNearCulling, "Checked", "DisableNearCulling");
            CreateSettingBinding(chkDisableFarCulling, "Checked", "DisableFarCulling");
            CreateSettingBinding(chkDisableUpdateCulling, "Checked", "DisableUpdateCulling");
            CreateSettingBinding(chkDisableLODReduction, "Checked", "DisableLODReduction");
            CreateSettingBinding(chkHideAllUI, "Checked", "HideUI");
            CreateSettingBinding(chkHideCommandPalette, "Checked", "HideSubpalette");
            CreateSettingBinding(chkHideScreenNotifications, "Checked", "HideScreenNotifications");
            CreateSettingBinding(chkHideEmergencyCodes, "Checked", "HideEmergencyCodes");
            CreateSettingBinding(chkHideHud, "Checked", "HideHud");
            CreateSettingBinding(chkMinimzeToTray, "Checked", "MinimizeToTray");
            CreateSettingBinding(chkCloseToTray, "Checked", "CloseToTray");
            CreateSettingBinding(chkAutomaticUpdates, "Checked", "AutomaticUpdates");
            CreateSettingBinding(chkPromptOnUpdate, "Checked", "PromptOnUpdate");
            CreateSettingBinding(radRunning, "Checked", "RunEnabled");
            CreateSettingBinding(radWalking, "Checked", "WalkEnabled");
            CreateSettingBinding(numRunInputScale, "Value", "RunInputScale");
            CreateSettingBinding(numWalkInputScale, "Value", "WalkInputScale");
            CreateSettingBinding(numFovNormal, "Value", "FovNormal");
            CreateSettingBinding(numFovTPS, "Value", "FovTPS");
            CreateSettingBinding(numFovNPCTalk, "Value", "FovNPCTalk");

            CreateSettingBinding(chkCam1Customize, "Checked", "CustomizeRegularCam");
            CreateSettingBinding(chkCam2Customize, "Checked", "CustomizeShooterCam");
            CreateSettingBinding(pnlCam1Customize, "Enabled", "CustomizeRegularCam");
            CreateSettingBinding(pnlCam2Customize, "Enabled", "CustomizeShooterCam");
            CreateSettingBinding(btnCam1Reset, "Enabled", "CustomizeRegularCam");
            CreateSettingBinding(btnCam2Reset, "Enabled", "CustomizeShooterCam");
            CreateSettingBinding(numCam1Distance, "Value", "RegularCamDistance");
            CreateSettingBinding(numCam1Height, "Value", "RegularCamHeight");
            CreateSettingBinding(numCam2X, "Value", "ShooterCamX");
            CreateSettingBinding(numCam2Y, "Value", "ShooterCamY");
            CreateSettingBinding(numCam2Z, "Value", "ShooterCamZ");
            CreateSettingBinding(numCam2Yaw, "Value", "ShooterCamYaw");
            CreateSettingBinding(numCam2Pitch, "Value", "ShooterCamPitch");
            CreateSettingBinding(numCam2Height, "Value", "ShooterCamHeight");

            CreateSettingBinding(chkCustomizeColors, "Checked", "CustomizeColors");
            CreateSettingBinding(pnlCustomizeColors, "Enabled", "CustomizeColors");
            CreateSettingBinding(btnResetColors, "Enabled", "CustomizeColors");
            CreateSettingBinding(numBrightness, "Value", "Brightness");
            CreateSettingBinding(numContrast, "Value", "Contrast");
            CreateSettingBinding(numSaturation, "Value", "Saturation");
            CreateSettingBinding(numRedBalance, "Value", "RedBalance");
            CreateSettingBinding(numGreenBalance, "Value", "GreenBalance");
            CreateSettingBinding(numBlueBalance, "Value", "BlueBalance");

            ConvertEventHandler parseBy10 = (object s, ConvertEventArgs e) => { e.Value = (decimal)((int)e.Value / 10.0f); };
            ConvertEventHandler formatBy10 = (object s, ConvertEventArgs e) => { e.Value = (int)((decimal)e.Value * 10); };
            ConvertEventHandler parseBy100 = (object s, ConvertEventArgs e) => { e.Value = (decimal)((int)e.Value / 100.0f); };
            ConvertEventHandler formatBy100 = (object s, ConvertEventArgs e) => { e.Value = (int)((decimal)e.Value * 100); };
            CreateTrackBinding(trackRunInputScale, numRunInputScale, parseBy100, formatBy100);
            CreateTrackBinding(trackWalkInputScale, numWalkInputScale, parseBy100, formatBy100);
            CreateTrackBinding(trackCam1Distance, numCam1Distance, parseBy10, formatBy10);
            CreateTrackBinding(trackCam1Height, numCam1Height, parseBy10, formatBy10);
            CreateTrackBinding(trackCam2X, numCam2X, parseBy10, formatBy10);
            CreateTrackBinding(trackCam2Y, numCam2Y, parseBy10, formatBy10);
            CreateTrackBinding(trackCam2Z, numCam2Z, parseBy10, formatBy10);
            CreateTrackBinding(trackCam2Yaw, numCam2Yaw, parseBy10, formatBy10);
            CreateTrackBinding(trackCam2Pitch, numCam2Pitch, parseBy10, formatBy10);
            CreateTrackBinding(trackCam2Height, numCam2Height, parseBy10, formatBy10);
            CreateTrackBinding(trackBrightness, numBrightness, parseBy100, formatBy100);
            CreateTrackBinding(trackContrast, numContrast, parseBy100, formatBy100);
            CreateTrackBinding(trackSaturation, numSaturation, parseBy100, formatBy100);
            CreateTrackBinding(trackRedBalance, numRedBalance, parseBy100, formatBy100);
            CreateTrackBinding(trackGreenBalance, numGreenBalance, parseBy100, formatBy100);
            CreateTrackBinding(trackBlueBalance, numBlueBalance, parseBy100, formatBy100);
        }

        private void InitializeInput()
        {
            m_directInput = new DirectInput();
            m_keyboard = new Keyboard(m_directInput);
            m_keyboard.SetCooperativeLevel(this, CooperativeLevel.Background | CooperativeLevel.NonExclusive);
            m_curKeystate = new KeyboardState();
            m_lastKeystate = new KeyboardState();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var letters = Enumerable.Range((int)'a', 26).Select(x => new string((char)x, 1));
            var letter = letters.ElementAtOrDefault(Program.Version.Revision - 1);
            lblVersion.Text = string.Format("v{0}{1}", Program.Version.ToString(2), letter);

            Log("Arks Mod Tool");
            Log("Version : {0}{1}", Program.Version.ToString(2), letter);
            Log("Target  : pso2.exe v{0}.{1:D4}.{2}", PSO2VERSION.Major, PSO2VERSION.Minor, PSO2VERSION.Revision);
            Log("-------------------------------");

            string[] args = Environment.GetCommandLineArgs();
            string updateResult = args.SkipWhile(x => x != "-on_update").ElementAtOrDefault(1);
            if (updateResult == "success")
                Log("Arks Mod Tool has been updated.");
            if (updateResult == "failure")
                Log("WARNING: The last update attempt failed.");
            else
                tmrAppUpdate.Start();

            AllocationType allocType = AllocationType.Reserve | AllocationType.Commit;
            m_commBuffer = Kernel32Imports.VirtualAlloc(m_commBufferLocation, m_commBufferSize, allocType, MemoryProtection.ReadWrite);
            if (m_commBuffer.ToInt64() >= 0x100000000 || m_commBuffer == IntPtr.Zero)
            {
                Log("ERROR: Could not initialize communication buffer.");
                SetStatus("Initialization Error", Color.Red);
                return;
            }

            WriteOutgoing();

            Log("Waiting for PSO2 to launch...");
            SetStatus("Waiting...", Color.Black);

            tmrScan.Start();
            tmrCommunicationUpdate.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Kernel32Imports.VirtualFree(m_commBuffer, m_commBufferSize, AllocationType.Release);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.Settings.CloseToTray && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (Program.Settings.MinimizeToTray && this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Index == -1)
                return;

            pageControl1.SelectTab(pageControl1.TabPages[e.Node.Tag as string]);
        }

        private void radWalkingRunning_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as RadioButton).Checked)
                return;

            WriteOutgoing();
        }

        private void btnCam1Reset_Click(object sender, EventArgs e)
        {
            Program.Settings.RegularCamDistance = Settings.Default.RegularCamDistance;
            Program.Settings.RegularCamHeight = Settings.Default.RegularCamHeight;
            numCam1Distance.DataBindings.Cast<Binding>().ForEach((Binding bind) => bind.ReadValue());
            numCam1Height.DataBindings.Cast<Binding>().ForEach((Binding bind) => bind.ReadValue());
        }

        private void btnCam2Reset_Click(object sender, EventArgs e)
        {
            Program.Settings.ShooterCamX = Settings.Default.ShooterCamX;
            Program.Settings.ShooterCamY = Settings.Default.ShooterCamY;
            Program.Settings.ShooterCamZ = Settings.Default.ShooterCamZ;
            Program.Settings.ShooterCamPitch = Settings.Default.ShooterCamPitch;
            Program.Settings.ShooterCamYaw = Settings.Default.ShooterCamYaw;
            Program.Settings.ShooterCamHeight = Settings.Default.ShooterCamHeight;
            numCam2X.DataBindings.Cast<Binding>().ForEach((Binding bind) => bind.ReadValue());
            numCam2Y.DataBindings.Cast<Binding>().ForEach((Binding bind) => bind.ReadValue());
            numCam2Z.DataBindings.Cast<Binding>().ForEach((Binding bind) => bind.ReadValue());
            numCam2Pitch.DataBindings.Cast<Binding>().ForEach((Binding bind) => bind.ReadValue());
            numCam2Yaw.DataBindings.Cast<Binding>().ForEach((Binding bind) => bind.ReadValue());
            numCam2Height.DataBindings.Cast<Binding>().ForEach((Binding bind) => bind.ReadValue());
        }

        private void btnResetColors_Click(object sender, EventArgs e)
        {
            Program.Settings.Brightness = Settings.Default.Brightness;
            Program.Settings.Contrast = Settings.Default.Contrast;
            Program.Settings.Saturation = Settings.Default.Saturation;
            Program.Settings.RedBalance = Settings.Default.RedBalance;
            Program.Settings.GreenBalance = Settings.Default.GreenBalance;
            Program.Settings.BlueBalance = Settings.Default.BlueBalance;
            numBrightness.DataBindings.Cast<Binding>().ForEach((Binding binding) => binding.ReadValue());
            numContrast.DataBindings.Cast<Binding>().ForEach((Binding binding) => binding.ReadValue());
            numSaturation.DataBindings.Cast<Binding>().ForEach((Binding binding) => binding.ReadValue());
            numRedBalance.DataBindings.Cast<Binding>().ForEach((Binding binding) => binding.ReadValue());
            numGreenBalance.DataBindings.Cast<Binding>().ForEach((Binding binding) => binding.ReadValue());
            numBlueBalance.DataBindings.Cast<Binding>().ForEach((Binding binding) => binding.ReadValue());
        }

        private void btnInfoMenu_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(btnInfoMenu, new Point(btnInfoMenu.Width, btnInfoMenu.Height), ToolStripDropDownDirection.BelowLeft);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                User32Imports.ShowWindow(this.Handle, ShowWindowCommands.Restore);
                User32Imports.SetForegroundWindow(this.Handle);
            }
        }

        private void openProjectPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Updater.PROJECT_PAGE);
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log("Checking for updates...");

            progressBar1.Value = 0;
            progressBar1.Visible = true;
            checkForUpdatesToolStripMenuItem.Enabled = false;

            upclientForeground.CheckForUpdate().ContinueWithThisContext(OnUpdateCheckCompleted);
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            User32Imports.ShowWindow(this.Handle, ShowWindowCommands.Restore);
            User32Imports.SetForegroundWindow(this.Handle);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void upclientForeground_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Maximum++;
            progressBar1.Value = progressBar1.Maximum;
            progressBar1.Value = e.ProgressPercentage;
            progressBar1.Maximum--;
        }

        private void tmrScan_Tick(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            var pso2 = processes.Where(x => Program.Settings.TargetProcesses.Contains(x.ProcessName));
            Process pso2Main = pso2.FirstOrDefault(x => !string.IsNullOrWhiteSpace(x.MainWindowTitle));

            if (pso2Main != null && m_pso2PID != pso2Main.Id)
            {
                Log("Detected PSO2 Window [PID:{0}]", pso2Main.Id);
                Log("Applying patches...");

                m_pso2PID = pso2Main.Id;
                m_pso2HWND = pso2Main.MainWindowHandle;
                m_gameReplied = false;

                bool isOkay = ApplyPatches(pso2Main);

                if (isOkay)
                {
                    Log("Waiting for response...");
                    SetStatus("Waiting For Response...", Color.DarkGoldenrod);
                    SetIcon(Resources.icon_idle);
                }
                else
                {
                    Log("Failed to apply patches.");
                    SetStatus("Patch Error", Color.Red);
                    SetIcon(Resources.icon);
                }
            }
        }

        private void tmrCommunicationUpdate_Tick(object sender, EventArgs e)
        {
            ReadInput();

            ReadIncoming();

            UpdateStatus();
        }

        private void tmrAppUpdate_Tick(object sender, EventArgs e)
        {
            if (!Program.Settings.AutomaticUpdates || m_gameReplied)
                return;

            if (upclientBackground.IsBusy)
                return;

            upclientBackground.CheckForUpdate().ContinueWithThisContext(OnUpdateCheckCompletedBackground);
        }

        private void ReadInput()
        {
            m_keyboard.Acquire();

            m_lastKeystate = m_curKeystate;
            m_curKeystate = m_keyboard.GetCurrentState();

            IntPtr hForeground = User32Imports.GetForegroundWindow();
            if (hForeground == this.Handle || hForeground == m_pso2HWND)
            {
                KeyBinding hideUI = Program.Settings.HideUIHotkey;
                if (hideUI.CheckKeystate(m_curKeystate, m_lastKeystate) && (hForeground == m_pso2HWND || hideUI.HasModifier()))
                {
                    Program.Settings.HideUI ^= true;
                    chkHideAllUI.DataBindings["Checked"].ReadValue();
                }


                KeyBinding toggleInput = Program.Settings.ToggleInputModeHotkey;
                if (toggleInput.CheckKeystate(m_curKeystate, m_lastKeystate) && (hForeground == m_pso2HWND || toggleInput.HasModifier()))
                {
                    Program.Settings.WalkEnabled ^= true;
                    radRunning.DataBindings["Checked"].ReadValue();
                    radWalking.DataBindings["Checked"].ReadValue();
                }
            }
        }

        private void ReadIncoming()
        {
            int status = Marshal.ReadInt32(m_commBuffer, 0x80);

            Marshal.WriteInt32(m_commBuffer, 0x80, 0x00000000);

            if (status != 0)
            {
                if (!m_gameReplied)
                {
                    m_gameReplied = true;
                    Log("Response received!");
                    Log("Arks Mod Tool is running.");
                }

                m_lastTime = DateTime.Now;
            }
        }

        private void WriteOutgoing()
        {
            if (m_commBuffer == IntPtr.Zero)
                return;

            float inputScale = (Program.Settings.WalkEnabled ? Program.Settings.WalkInputScale : Program.Settings.RunInputScale);
            float fovNormal = Program.Settings.FovNormal / 180.0f * (float)Math.PI;
            float fovTPS = Program.Settings.FovTPS / 180.0f * (float)Math.PI;
            float fovNPCTalk = Program.Settings.FovTPS / 180.0f * (float)Math.PI;
            float sensitivity = Program.Settings.RegularCamDistance * (0.024f / 6.50f);
            float regularCamDistance = Program.Settings.RegularCamDistance;
            float regularCamHeight = Program.Settings.RegularCamHeight;
            float shooterCamX = -Program.Settings.ShooterCamX;
            float shooterCamY = Program.Settings.ShooterCamY;
            float shooterCamZ = Program.Settings.ShooterCamZ;
            float shooterTargetX = -(float)(Math.Tan(Program.Settings.ShooterCamYaw * Math.PI / 180.0) * 14.96505737);
            float shooterTargetY = (float)(Math.Tan(Program.Settings.ShooterCamPitch * Math.PI / 180.0) * 14.96505737);
            float shooterHeight = Program.Settings.ShooterCamHeight;
            float brightness = Program.Settings.Brightness;
            float contrast = 1.0f + Program.Settings.Contrast;
            float saturation = 1.0f + Program.Settings.Saturation;
            float redBalance = 1.0f + Program.Settings.RedBalance;
            float greenBalance = 1.0f + Program.Settings.GreenBalance;
            float blueBalance = 1.0f + Program.Settings.BlueBalance;

            AdjustmentFlags adjustments = AdjustmentFlags.None;
            adjustments |= (Program.Settings.DisableIntroVideo ? AdjustmentFlags.DisableIntro : 0);
            adjustments |= (Program.Settings.HideUI ? AdjustmentFlags.HideUI : 0);
            adjustments |= (Program.Settings.HideSubpalette ? AdjustmentFlags.HideSubpalette : 0);
            adjustments |= (Program.Settings.HideScreenNotifications ? AdjustmentFlags.HideScreenNotifications : 0);
            adjustments |= (Program.Settings.HideEmergencyCodes ? AdjustmentFlags.HideECodes : 0);
            adjustments |= (Program.Settings.DisableNearCulling ? AdjustmentFlags.DisableNearCulling : 0);
            adjustments |= (Program.Settings.DisableFarCulling ? AdjustmentFlags.DisableFarCulling : 0);
            adjustments |= (Program.Settings.DisableUpdateCulling ? AdjustmentFlags.DisableUpdateCulling : 0);
            adjustments |= (Program.Settings.DisableLODReduction ? AdjustmentFlags.DisableLODReduction : 0);
            adjustments |= (Program.Settings.CustomizeRegularCam ? AdjustmentFlags.CustomizeCam1 : 0);
            adjustments |= (Program.Settings.CustomizeShooterCam ? AdjustmentFlags.CustomizeCam2 : 0);
            adjustments |= (Program.Settings.CustomizeColors ? AdjustmentFlags.CustomizeColors : 0);

            Marshal.WriteInt32(m_commBuffer, 0x0, (int)adjustments);
            Marshal.StructureToPtr(inputScale, IntPtr.Add(m_commBuffer, 0x4), false);
            Marshal.StructureToPtr(fovNormal, IntPtr.Add(m_commBuffer, 0x10), false);
            Marshal.StructureToPtr(fovTPS, IntPtr.Add(m_commBuffer, 0x14), false);
            Marshal.StructureToPtr(fovNPCTalk, IntPtr.Add(m_commBuffer, 0x18), false);
            Marshal.StructureToPtr(sensitivity, IntPtr.Add(m_commBuffer, 0x20), false);
            Marshal.StructureToPtr(sensitivity, IntPtr.Add(m_commBuffer, 0x24), false);
            Marshal.StructureToPtr(regularCamDistance, IntPtr.Add(m_commBuffer, 0x28), false);
            Marshal.StructureToPtr(regularCamHeight, IntPtr.Add(m_commBuffer, 0x2C), false);
            Marshal.StructureToPtr(shooterCamX, IntPtr.Add(m_commBuffer, 0x30), false);
            Marshal.StructureToPtr(shooterCamY, IntPtr.Add(m_commBuffer, 0x34), false);
            Marshal.StructureToPtr(shooterCamZ, IntPtr.Add(m_commBuffer, 0x38), false);
            Marshal.StructureToPtr(0x00000000, IntPtr.Add(m_commBuffer, 0x3C), false);
            Marshal.StructureToPtr(shooterTargetX, IntPtr.Add(m_commBuffer, 0x40), false);
            Marshal.StructureToPtr(shooterTargetY, IntPtr.Add(m_commBuffer, 0x44), false);
            Marshal.StructureToPtr(shooterHeight, IntPtr.Add(m_commBuffer, 0x48), false);
            Marshal.StructureToPtr(0x00000000, IntPtr.Add(m_commBuffer, 0x4C), false);
            Marshal.StructureToPtr(brightness, IntPtr.Add(m_commBuffer, 0x50), false);
            Marshal.StructureToPtr(contrast, IntPtr.Add(m_commBuffer, 0x54), false);
            Marshal.StructureToPtr(saturation, IntPtr.Add(m_commBuffer, 0x58), false);
            Marshal.StructureToPtr(0x00000000, IntPtr.Add(m_commBuffer, 0x5C), false);
            Marshal.StructureToPtr(redBalance, IntPtr.Add(m_commBuffer, 0x60), false);
            Marshal.StructureToPtr(greenBalance, IntPtr.Add(m_commBuffer, 0x64), false);
            Marshal.StructureToPtr(blueBalance, IntPtr.Add(m_commBuffer, 0x68), false);
            Marshal.StructureToPtr(0x3F800000, IntPtr.Add(m_commBuffer, 0x6C), false);
        }

        private void UpdateStatus()
        {
            if (!m_gameReplied)
                return;

            double time = (DateTime.Now - m_lastTime).TotalSeconds;
            if (time <= 3)
            {
                SetStatus("Connected", Color.DarkGreen);
                SetIcon(Resources.icon_active);
                tmrScan.Stop();
            }

            if (time > 3 && !tmrScan.Enabled)
            {
                SetStatus("Waiting...", Color.DarkGoldenrod);
                SetIcon(Resources.icon_idle);
                tmrScan.Start();
            }

            if (time > 10)
            {
                SetStatus("Waiting...", Color.Black);
                SetIcon(Resources.icon);
                m_gameReplied = false;
            }
        }

        private bool ApplyPatches(Process process)
        {
            if (process == null)
                return false;

            TOKEN_PRIVILEGES privilege = PrivilegeHelper.SetPrivilege("SeDebugPrivilege");
            IntPtr handle = OpenProcessVirtualAccess(process.Id);
            bool isOkay = true;

            isOkay = isOkay && handle != IntPtr.Zero;
            isOkay = isOkay && CheckCrc(handle);
            isOkay = isOkay && ApplyCrcPatch(handle);
            isOkay = isOkay && ApplyCommPatch(handle);
            isOkay = isOkay && ApplyGamePatches(handle);

            Kernel32Imports.CloseHandle(handle);
            PrivilegeHelper.RestorePrivilege(privilege);

            return isOkay;
        }

        private unsafe bool CheckCrc(IntPtr handle)
        {
            uint pso2Base = 0x00400000u;
            IntPtr pCrc = new IntPtr(pso2Base + 0x38);
            UInt32* crc = stackalloc UInt32[1];

            if (!Kernel32Imports.ReadProcessMemory(handle, pCrc, (IntPtr)crc, sizeof(UInt32), IntPtr.Zero))
                return LogLastWin32Error("ReadProcessMemory") == 0;

            if (*crc != ORIGINAL_CRC && *crc != PATCHED_CRC)
            {
                Log("Game signature mismatch.");
                Log("Please download the latest version of");
                Log("ArksMT when it becomes available.");
                SetStatus("Version Error", Color.Red);
                SetIcon(Resources.icon);
                return false;
            }

            return true;
        }

        private unsafe bool ApplyCrcPatch(IntPtr handle)
        {
            uint pso2Base = 0x00400000u;

            uint* bCrc = stackalloc uint[1];
            IntPtr pCrc = new IntPtr(pso2Base + 0x38);
            IntPtr dCrc = new IntPtr(bCrc);
            bCrc[0] = PATCHED_CRC;

            Protection newProtection = Protection.PAGE_EXECUTE_READWRITE;
            Protection oldProtection;
            if (!Kernel32Imports.VirtualProtectEx(handle, pCrc, 4, newProtection, out oldProtection))
                return LogLastWin32Error("VirtualProtectEx") == 0;

            if (!Kernel32Imports.WriteProcessMemory(handle, pCrc, dCrc, 4, IntPtr.Zero))
                return LogLastWin32Error("WriteProcessMemory") == 0;

            return true;
        }

        private bool ApplyCommPatch(IntPtr handle)
        {
            bool isOkay = true;

            isOkay = isOkay && ApplyCommDataPatch(handle);
            isOkay = isOkay && ApplyGamePatch(handle, Resources.CommInit);
            isOkay = isOkay && ApplyGamePatch(handle, Resources.CommMain);
            isOkay = isOkay && ApplyGamePatch(handle, Resources.CommMainHook);

            VirtualReleaseAll(handle, m_oldAllocations.ToArray());
            m_oldAllocations.Clear();

            return isOkay;
        }

        private unsafe bool ApplyCommDataPatch(IntPtr handle)
        {
            uint pso2Base = 0x00400000u;
            byte* bCommData = stackalloc byte[0x20];
            IntPtr dCommData = (IntPtr)bCommData;
            IntPtr pCommData = new IntPtr(pso2Base + PCOMMDATA);

            // Read out old data
            if (!Kernel32Imports.ReadProcessMemory(handle, pCommData, dCommData, 0x20, IntPtr.Zero))
                return LogLastWin32Error("ReadProcessMemory") == 0;

            // Apply Functions Patch
            IntPtr pOldCommFunctions = new IntPtr(Marshal.ReadInt32(dCommData, 0x18));
            IntPtr pCommFunctions = ApplyCommFunctionsPatch(handle, pOldCommFunctions);

            Marshal.Copy(Enumerable.Repeat((byte)0x00, 0x20).ToArray(), 0, dCommData, 0x18);
            Marshal.Copy(Encoding.ASCII.GetBytes("ARKSMT"), 0, dCommData, 6);
            Marshal.WriteInt32(dCommData, 0x10, Program.PID);
            Marshal.WriteInt32(dCommData, 0x14, m_commBuffer.ToInt32());
            Marshal.WriteInt32(dCommData, 0x18, pCommFunctions.ToInt32());

            if (!Kernel32Imports.WriteProcessMemory(handle, pCommData, dCommData, 0x20, IntPtr.Zero))
                return LogLastWin32Error("WriteProcessMemory") == 0;

            return true;
        }

        private unsafe IntPtr ApplyCommFunctionsPatch(IntPtr handle, IntPtr pOldCommFunctions)
        {
            if (pOldCommFunctions != IntPtr.Zero)
                return pOldCommFunctions;

            string[] functions = Resources.CommFunctions.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var byteCounts = functions.Select(x => Encoding.ASCII.GetByteCount(x) + 1);
            var paddedCounts = byteCounts.Select(x => (x + 0xF) & ~0xF);
            int[] offsets = paddedCounts.Select((x, i) => paddedCounts.Take(i).Sum()).ToArray();

            int cbFunctionPointers = ((functions.Length * 0x4) + 0x1F) & ~0x1F;
            int cbNamePointers = cbFunctionPointers;
            int cbNames = paddedCounts.Sum();
            int cbKernel32 = 0x10;
            int byteCount = cbFunctionPointers + cbNamePointers + cbNames + cbKernel32;

            byte* bCommFunctions = stackalloc byte[byteCount];
            IntPtr dCommFunctions = new IntPtr(bCommFunctions);
            IntPtr pCommFunctions = VirtualAlloc(handle, byteCount);
            if (pCommFunctions == IntPtr.Zero)
            {
                LogLastWin32Error("VirtualAllocEx");
                return IntPtr.Zero;
            }

            IntPtr dNamePointers = IntPtr.Add(dCommFunctions, cbFunctionPointers);
            for (int i = 0; i < functions.Length; ++i)
            {
                int nameOffset = cbFunctionPointers + cbNamePointers + offsets[i];
                IntPtr namePointer = IntPtr.Add(pCommFunctions, nameOffset);

                Marshal.WriteInt32(dNamePointers, i * 0x4, namePointer.ToInt32());
                Encoding.ASCII.WriteString(dCommFunctions, nameOffset, functions[i]);
            }

            int k32nameOffset = cbFunctionPointers + cbNamePointers + cbNames;
            IntPtr k32namePointer = IntPtr.Add(pCommFunctions, k32nameOffset);
            Marshal.WriteInt32(dCommFunctions, cbFunctionPointers - 0x4, k32namePointer.ToInt32());
            Encoding.ASCII.WriteString(dCommFunctions, k32nameOffset, "Kernel32.dll");

            if (!Kernel32Imports.WriteProcessMemory(handle, pCommFunctions, dCommFunctions, byteCount, IntPtr.Zero))
            {
                VirtualReleaseAll(handle, pCommFunctions);
                LogLastWin32Error("WriteProcessMemory");
                return IntPtr.Zero;
            }

            return pCommFunctions;
        }

        private bool ApplyGamePatches(IntPtr handle)
        {
            bool isOkay = true;

            isOkay &= isOkay && ApplyGamePatch(handle, Resources.ToggleIntroVideo);

            isOkay &= isOkay && ApplyGamePatch(handle, Resources.ToggleNearCulling);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.ToggleFarCulling);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.ToggleFarCullingTerrain);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.ToggleUpdateCulling);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.ToggleLOD);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.ToggleLODHook);


            isOkay &= isOkay && ApplyGamePatch(handle, Resources.UIHideMenus);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.UIHideSubpalette);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.UIHideScreenNotifications);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.UIHideECodes);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.UIHideECodesHook);

            isOkay &= isOkay && ApplyGamePatch(handle, Resources.InputScaleNormal);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.InputScaleAuto);

            isOkay &= isOkay && ApplyGamePatch(handle, Resources.DisableAutoShowLog);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.DisableECodeMapChange);

            isOkay &= isOkay && ApplyGamePatch(handle, Resources.Camera1Override);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.Camera2Override);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.Camera2TransOverride);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.CameraLandingOverride);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.CameraControlMain);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.CameraControlMainHook);

            isOkay &= isOkay && ApplyGamePatch(handle, Resources.ColorAdjustments);
            isOkay &= isOkay && ApplyGamePatch(handle, Resources.ColorAdjustmentsHook);

            return isOkay;
        }

        private unsafe bool ApplyGamePatch(IntPtr handle, byte[] patchData)
        {
            uint pso2Base = 0x00400000u;

            fixed (byte* ptr = patchData)
            {
                uint offset = *(uint*)ptr;
                IntPtr pPatch = new IntPtr(pso2Base + offset);
                IntPtr pData = new IntPtr(ptr + 0x10);
                int size = patchData.Length - 0x10;

                if (!Kernel32Imports.WriteProcessMemory(handle, pPatch, pData, size, IntPtr.Zero))
                    return LogLastWin32Error("WriteProcessMemory") == 0;
            }

            return true;
        }

        private IntPtr OpenProcessVirtualAccess(int processId)
        {
            IntPtr handle = Kernel32Imports.OpenProcess(ProcessAccessFlags.VirtualMemoryAll, false, processId);

            if (handle == IntPtr.Zero)
                LogLastWin32Error("OpenProcess");

            return handle;
        }

        private IntPtr VirtualAlloc(IntPtr handle, int byteCount)
        {
            AllocationType allocType = AllocationType.Reserve | AllocationType.Commit;
            return Kernel32Imports.VirtualAllocEx(handle, IntPtr.Zero, byteCount, allocType, MemoryProtection.ReadWrite);
        }

        private void VirtualReleaseAll(IntPtr handle, params IntPtr[] allocations)
        {
            foreach (IntPtr ptr in allocations)
            {
                Kernel32Imports.VirtualFreeEx(handle, ptr, IntPtr.Zero, AllocationType.Release);
            }
        }

        private void CreateSettingBinding(Control control, string propertyName, string settingName)
        {
            Binding binding = control.DataBindings.Add(propertyName, Program.Settings, settingName);
            binding.FormattingEnabled = true;
            binding.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            binding.BindingComplete += (object s, BindingCompleteEventArgs e) => { WriteOutgoing(); };
        }

        private void CreateTrackBinding(TrackBar track, NumericUpDown numeric, ConvertEventHandler parse, ConvertEventHandler format)
        {
            Binding binding = track.DataBindings.Add("Value", numeric, "Value");
            binding.FormattingEnabled = false;
            binding.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            if (parse != null)
                binding.Parse += parse;

            if (format != null)
                binding.Format += format;
        }

        private void AddStyleFlag(Control control, uint styleFlag)
        {
            uint style = User32Imports.GetWindowLong(control.Handle, User32Imports.GWL_STYLE);
            User32Imports.SetWindowLong(control.Handle, User32Imports.GWL_STYLE, style | styleFlag);
        }

        private void Log(string str)
        {
            txtLog.Text += str + Environment.NewLine;
            txtLog.Select(txtLog.Text.Length, 0);
            txtLog.ScrollToCaret();
        }

        private void Log(string format, params object[] args)
        {
            Log(string.Format(format, args));
        }

        private int LogLastWin32Error(string context)
        {
            int errorCode = Marshal.GetLastWin32Error();
            string message = new Win32Exception(errorCode).Message;
            Log("{0} : Error 0x{1:X8} - {2}", context, errorCode, message);

            if (errorCode != 0)
                return errorCode;
            else
                return -1;
        }

        private void SetStatus(string str, Color color)
        {
            lblStatus.ForeColor = color;
            lblStatus.Text = str;
        }

        private void SetIcon(Icon icon)
        {
            foreach (Form form in Application.OpenForms)
                form.Icon = icon;

            notifyIcon1.Icon = icon;
            Program.Icon = icon;
        }

        private void FlashWindow()
        {
            const UInt32 FLASHW_ALL = 0x00000003;
            const UInt32 FLASHW_TIMERNOFG = 0x0000000C;

            FLASHWINFO fwi;
            fwi.cbSize = (UInt32)Marshal.SizeOf(typeof(FLASHWINFO));
            fwi.hwnd = this.Handle;
            fwi.dwFlags = FLASHW_ALL | FLASHW_TIMERNOFG;
            fwi.uCount = 0;
            fwi.dwTimeout = 0;

            User32Imports.FlashWindowEx(ref fwi);
        }

        private void OnUpdateCheckCompleted(Task<bool> task)
        {
            progressBar1.Visible = false;
            checkForUpdatesToolStripMenuItem.Enabled = true;

            if (task.IsCancelledEx())
            {
                Log("Update Error - Cancelled");
                return;
            }

            if (task.IsFaulted)
            {
                Exception ex = task.Exception.GetBaseException();
                Log("Update Error - {0}", ex.Message);
                MessageBox.Show(string.Format("ERROR: Unable to check for updates.\n{0}", ex.Message), "Update Error");
                return;
            }

            if (!task.Result)
            {
                Log("Arks Mod Tool is up to date");
                return;
            }

            tmrAppUpdate.Stop();
            PromptUpdate();
        }

        private async void OnUpdateCheckCompletedBackground(Task<bool> task)
        {
            if (task.IsFaulted || !task.Result)
                return;

            tmrAppUpdate.Stop();

            if (Program.Settings.PromptOnUpdate)
            {
                if (!this.ContainsFocus)
                {
                    if (this.WindowState == FormWindowState.Minimized && !this.Visible)
                        this.Show();

                    FlashWindow();

                    TaskCompletionSource<object> signal = new TaskCompletionSource<object>(null);
                    EventHandler evt = (object s2, EventArgs e2) => { signal.SetResult(null); };
                    this.Activated += evt;
                    await signal.Task;
                    this.Activated -= evt;

                    if (this.WindowState != FormWindowState.Maximized)
                        User32Imports.ShowWindow(this.Handle, ShowWindowCommands.ShowNoActivate);
                }

                PromptUpdate();
            }
            else
            {
                DoUpdate();
            }
        }

        private void OnDownloadCompleted(Task<string> task)
        {
            checkForUpdatesToolStripMenuItem.Enabled = true;
            progressBar1.Visible = false;

            if (task.IsCancelledEx())
            {
                Log("Update Error - Cancelled");
                return;
            }

            if (task.IsFaulted)
            {
                Exception ex = task.Exception.GetBaseException();
                Log("Update Error - {0}", ex.Message);

                DialogResult result = MessageBox.Show(string.Format("ERROR: Could not retrieve update package.\n{0}", ex.Message), "Update Error", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                    DoUpdate();

                return;
            }

            Updater.UpdatePackage = task.Result;
            Updater.RestartState = this.WindowState;
            Application.Exit();
        }

        private void PromptUpdate()
        {
            Log("A new version of AMT is available");
            DialogResult result = MessageBox.Show("A new version of Arks Mod Tool is available. Install?", "Update", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                DoUpdate();
        }

        private void DoUpdate()
        {
            checkForUpdatesToolStripMenuItem.Enabled = false;
            progressBar1.Visible = true;
            progressBar1.Value = 0;

            Log("Downloading update files...");

            string appName = Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location);
            string packageName = string.Format("{0}_Update.zip", appName);
            upclientForeground.DownloadUpdate(packageName).ContinueWithThisContext(OnDownloadCompleted);
        }

        [Flags]
        public enum AdjustmentFlags : int
        {
            None = 0x00,
            DisableIntro = 0x01,

            HideUI = 0x10,
            HideSubpalette = 0x20,
            HideScreenNotifications = 0x40,
            HideECodes = 0x80,

            DisableNearCulling = 0x0100,
            DisableFarCulling = 0x0200,
            DisableUpdateCulling = 0x0400,
            DisableLODReduction = 0x0800,

            CustomizeCam1 = 0x1000,
            CustomizeCam2 = 0x2000,

            CustomizeColors = 0x010000
        }
    }
}
