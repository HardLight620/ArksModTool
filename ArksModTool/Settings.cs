using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SharpDX.DirectInput;

namespace ArksModTool
{
    public class Settings
    {
        public static readonly Settings Default = new Settings();

        public string[] TargetProcesses { get { return m_targetProcesses; } }

        public bool DisableIntroVideo { get { return m_disableIntroVideo; } set { m_disableIntroVideo = value; } }
        public bool DisableNearCulling { get { return m_disableNearCulling; } set { m_disableNearCulling = value; } }
        public bool DisableFarCulling { get { return m_disableFarCulling; } set { m_disableFarCulling = value; } }
        public bool DisableUpdateCulling { get { return m_disableUpdateCulling; } set { m_disableUpdateCulling = value; } }
        public bool DisableLODReduction { get { return m_disableLODReduction; } set { m_disableLODReduction = value; } }

        public float RunInputScale { get { return m_runInputScale; } set { m_runInputScale = value; } }
        public float WalkInputScale { get { return m_walkInputScale; } set { m_walkInputScale = value; } }
        public bool WalkEnabled { get { return m_walkEnabled; } set { m_walkEnabled = value; } }
        public bool RunEnabled { get { return !m_walkEnabled; } set { m_walkEnabled = !value; } }
        public KeyBinding ToggleInputModeHotkey { get { return m_toggleInputModeHotkey; } set { m_toggleInputModeHotkey = value; } }

        public bool HideUI { get { return m_hideUI; } set { m_hideUI = value; } }
        public bool HideHud { get { return m_hideHud; } set { m_hideHud = value; } }
        public bool HideSubpalette { get { return m_hideSubpalette; } set { m_hideSubpalette = value; } }
        public bool HideScreenNotifications { get { return m_hideScreenNotifications; } set { m_hideScreenNotifications = value; } }
        public bool HideEmergencyCodes { get { return m_hideEmergencyCodes; } set { m_hideEmergencyCodes = value; } }
        public KeyBinding HideUIHotkey { get { return m_hideUIHotkey; } set { m_hideUIHotkey = value; } }

        public float FovNormal { get { return m_fovNormal; } set { m_fovNormal = value; } }
        public float FovTPS { get { return m_fovTPS; } set { m_fovTPS = value; } }
        public float FovNPCTalk { get { return m_fovNPCTalk; } set { m_fovNPCTalk = value; } }

        public bool CustomizeRegularCam { get { return m_customizeRegularCam; } set { m_customizeRegularCam = value; } }
        public bool CustomizeShooterCam { get { return m_customizeShooterCam; } set { m_customizeShooterCam = value; } }
        public float RegularCamHeight { get { return m_regularCamHeight; } set { m_regularCamHeight = value; } }
        public float RegularCamDistance { get { return m_regularCamDistance; } set { m_regularCamDistance = value; } }
        public float ShooterCamX { get { return m_shooterCamX; } set { m_shooterCamX = value; } }
        public float ShooterCamY { get { return m_shooterCamY; } set { m_shooterCamY = value; } }
        public float ShooterCamZ { get { return m_shooterCamZ; } set { m_shooterCamZ = value; } }
        public float ShooterCamYaw { get { return m_shooterCamYaw; } set { m_shooterCamYaw = value; } }
        public float ShooterCamPitch { get { return m_shooterCamPitch; } set { m_shooterCamPitch = value; } }
        public float ShooterCamHeight { get { return m_shooterCamHeight; } set { m_shooterCamHeight = value; } }

        public bool CustomizeColors { get { return m_customizeColors; } set { m_customizeColors = value; } }
        public float Brightness { get { return m_brightness; } set { m_brightness = value; } }
        public float Contrast { get { return m_contrast; } set { m_contrast = value; } }
        public float Saturation { get { return m_saturation; } set { m_saturation = value; } }
        public float RedBalance { get { return m_redBalance; } set { m_redBalance = value; } }
        public float GreenBalance { get { return m_greenBalance; } set { m_greenBalance = value; } }
        public float BlueBalance { get { return m_blueBalance; } set { m_blueBalance = value; } }

        public bool MinimizeToTray { get { return m_minimizeToTray; } set { m_minimizeToTray = value; } }
        public bool CloseToTray { get { return m_closeToTray; } set { m_closeToTray = value; } }

        private string[] m_targetProcesses = new string[] { "pso2", "pso2_nogg_multi" };

        private bool m_disableIntroVideo = false;
        private bool m_disableNearCulling = false;
        private bool m_disableFarCulling = false;
        private bool m_disableUpdateCulling = false;
        private bool m_disableLODReduction = false;

        private float m_runInputScale = 1.00f;
        private float m_walkInputScale = 0.25f;
        private KeyBinding m_toggleInputModeHotkey = new KeyBinding(Key.Grave, false, false, true);

        private bool m_hideUI = false;
        private bool m_hideHud = false;
        private bool m_hideSubpalette = false;
        private bool m_hideScreenNotifications = false;
        private bool m_hideEmergencyCodes = false;
        private KeyBinding m_hideUIHotkey = new KeyBinding(Key.Grave, true, false, false);

        private float m_fovNormal = 44;
        private float m_fovTPS = 45;
        private float m_fovNPCTalk = 45;

        private bool m_customizeRegularCam = false;
        private bool m_customizeShooterCam = false;
        private float m_regularCamHeight = 2.0f;
        private float m_regularCamDistance = 6.5f;
        private float m_shooterCamX = 1.0f;
        private float m_shooterCamY = 0.4f;
        private float m_shooterCamZ = -3.2f;
        private float m_shooterCamYaw = -3.9f;
        private float m_shooterCamPitch = 0.0f;
        private float m_shooterCamHeight = 1.5f;

        private bool m_customizeColors = false;
        private float m_brightness = 0.0f;
        private float m_contrast = 0.0f;
        private float m_saturation = 0.0f;
        private float m_redBalance = 0.0f;
        private float m_blueBalance = 0.0f;
        private float m_greenBalance = 0.0f;

        private bool m_minimizeToTray = false;
        private bool m_closeToTray = false;

        // No Save
        private bool m_walkEnabled = false;

        public Settings()
        {
            
        }

        public void Reset()
        {
            m_targetProcesses = new string[] { "pso2.exe", "pso2_nogg_multi" };

            m_disableIntroVideo = false;
            m_disableNearCulling = false;
            m_disableFarCulling = false;
            m_disableUpdateCulling = false;
            m_disableLODReduction = false;

            m_runInputScale = 1.00f;
            m_walkInputScale = 0.25f;

            m_hideUI = false;
            m_hideHud = false;
            m_hideSubpalette = false;
            m_hideScreenNotifications = false;
            m_hideEmergencyCodes = false;

            m_fovNormal = 44;
            m_fovTPS = 45;
            m_fovNPCTalk = 45;

            m_customizeRegularCam = false;
            m_customizeShooterCam = false;
            m_regularCamHeight = 2.0f;
            m_regularCamDistance = 6.5f;
            m_shooterCamX = 1.0f;
            m_shooterCamY = 0.4f;
            m_shooterCamZ = -3.2f;
            m_shooterCamYaw = -3.9f;
            m_shooterCamPitch = 0.0f;
            m_shooterCamHeight = 1.5f;

            m_customizeColors = false;
            m_brightness = 0.0f;
            m_contrast = 0.0f;
            m_saturation = 0.0f;
            m_redBalance = 0.0f;
            m_blueBalance = 0.0f;
            m_greenBalance = 0.0f;

            m_minimizeToTray = false;
            m_closeToTray = false;
        }

        public bool Save(string path)
        {
            List<string> settings = new List<string>();

            settings.Add(string.Format("{0, -25} : {1}", "Target Process", string.Join(", ", m_targetProcesses)));

            settings.Add(string.Format("{0, -25} : {1}", "Disable Intro Video", m_disableIntroVideo));
            settings.Add(string.Format("{0, -25} : {1}", "Disable Near Culling", m_disableNearCulling));
            settings.Add(string.Format("{0, -25} : {1}", "Disable Far Culling", m_disableFarCulling));
            settings.Add(string.Format("{0, -25} : {1}", "Disable Update Culling", m_disableUpdateCulling));
            settings.Add(string.Format("{0, -25} : {1}", "Disable LOD Reduction", m_disableLODReduction));

            settings.Add(string.Format("{0, -25} : {1}", "Run Input Scale", m_runInputScale));
            settings.Add(string.Format("{0, -25} : {1}", "Walk Input Scale", m_walkInputScale));

            settings.Add(string.Format("{0, -25} : {1}", "Hide UI", m_hideUI));
            settings.Add(string.Format("{0, -25} : {1}", "Hide Hud", m_hideHud));
            settings.Add(string.Format("{0, -25} : {1}", "Hide Subpalette", m_hideSubpalette));
            settings.Add(string.Format("{0, -25} : {1}", "Hide Screen Notifications", m_hideScreenNotifications));
            settings.Add(string.Format("{0, -25} : {1}", "Hide Emergency Codes", m_hideEmergencyCodes));

            settings.Add(string.Format("{0, -25} : {1}", "Key Hide UI", m_hideUIHotkey));
            settings.Add(string.Format("{0, -25} : {1}", "Key Toggle Input Mode", m_toggleInputModeHotkey));

            //settings.Add(string.Format("{0, -25} : {1}", "FOV Normal", m_fovNormal));
            //settings.Add(string.Format("{0, -25} : {1}", "FOV TPS", m_fovTPS));
            //settings.Add(string.Format("{0, -25} : {1}", "FOV NPC Talk", m_fovNPCTalk));

            settings.Add(string.Format("{0, -25} : {1}", "Customize Regular Cam", m_customizeRegularCam));
            settings.Add(string.Format("{0, -25} : {1}", "Customize Shooter Cam", m_customizeShooterCam));
            settings.Add(string.Format("{0, -25} : {1}", "Regular Cam Distance", m_regularCamDistance));
            settings.Add(string.Format("{0, -25} : {1}", "Regular Cam Height", m_regularCamHeight));
            settings.Add(string.Format("{0, -25} : {1}", "Shooter Cam X", m_shooterCamX));
            settings.Add(string.Format("{0, -25} : {1}", "Shooter Cam Y", m_shooterCamY));
            settings.Add(string.Format("{0, -25} : {1}", "Shooter Cam Z", m_shooterCamZ));
            settings.Add(string.Format("{0, -25} : {1}", "Shooter Cam Pitch", m_shooterCamPitch));
            settings.Add(string.Format("{0, -25} : {1}", "Shooter Cam Yaw", m_shooterCamYaw));
            settings.Add(string.Format("{0, -25} : {1}", "Shooter Cam Height", m_shooterCamHeight));

            settings.Add(string.Format("{0, -25} : {1}", "Customize Colors", m_customizeColors));
            settings.Add(string.Format("{0, -25} : {1}", "Brightness", m_brightness));
            settings.Add(string.Format("{0, -25} : {1}", "Contrast", m_contrast));
            settings.Add(string.Format("{0, -25} : {1}", "Saturation", m_saturation));
            settings.Add(string.Format("{0, -25} : {1}", "Red Balance", m_redBalance));
            settings.Add(string.Format("{0, -25} : {1}", "Green Balance", m_greenBalance));
            settings.Add(string.Format("{0, -25} : {1}", "Blue Balance", m_blueBalance));

            settings.Add(string.Format("{0, -25} : {1}", "Minimize To Tray", m_minimizeToTray));
            settings.Add(string.Format("{0, -25} : {1}", "Close To Tray", m_closeToTray));
            
            try
            {
                File.WriteAllLines(path, settings.ToArray());

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #region Static Members

        public static Settings Load(string path)
        {
            try
            {
                Settings settings = new Settings();

                string[] lines = File.ReadAllLines(path);
                IEnumerable<string[]> pairs = lines.Select(x => x.Split(new char[] { ':' }, 2)).Where(x => x.Count() == 2);
                KeyValuePair<string, string>[] entries = pairs.Select(x => new KeyValuePair<string, string>(x.First().Trim(), x.Last().Trim())).ToArray();

                foreach (KeyValuePair<string, string> kvp in entries)
                {
                    switch (kvp.Key)
                    {
                        case "Target Process":          settings.m_targetProcesses = kvp.Value.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray(); break;

                        case "Disable Intro Video":     bool.TryParse(kvp.Value, out settings.m_disableIntroVideo); break;
                        case "Disable Near Culling":    bool.TryParse(kvp.Value, out settings.m_disableNearCulling); break;
                        case "Disable Far Culling":     bool.TryParse(kvp.Value, out settings.m_disableFarCulling); break;
                        case "Disable Update Culling":  bool.TryParse(kvp.Value, out settings.m_disableUpdateCulling); break;
                        case "Disable LOD Reduction":   bool.TryParse(kvp.Value, out settings.m_disableLODReduction); break;

                        case "Hide UI":                 bool.TryParse(kvp.Value, out settings.m_hideUI); break;
                        case "Hide Hud":                bool.TryParse(kvp.Value, out settings.m_hideHud); break;
                        case "Hide Subpalette":         bool.TryParse(kvp.Value, out settings.m_hideSubpalette); break;
                        case "Hide Screen Notifications": bool.TryParse(kvp.Value, out settings.m_hideScreenNotifications); break;
                        case "Hide Emergency Codes":    bool.TryParse(kvp.Value, out settings.m_hideEmergencyCodes); break;

                        case "Run Input Scale":         float.TryParse(kvp.Value, out settings.m_runInputScale); break;
                        case "Walk Input Scale":        float.TryParse(kvp.Value, out settings.m_walkInputScale); break;

                        case "Key Hide UI":             settings.m_hideUIHotkey = KeyBinding.Parse(kvp.Value); break;
                        case "Key Toggle Input Mode":   settings.m_toggleInputModeHotkey = KeyBinding.Parse(kvp.Value); break;

                        case "FOV Normal":              float.TryParse(kvp.Value, out settings.m_fovNormal); break;
                        case "FOV TPS":                 float.TryParse(kvp.Value, out settings.m_fovTPS); break;
                        case "FOV NPC Talk":            float.TryParse(kvp.Value, out settings.m_fovNPCTalk); break;

                        case "Customize Regular Cam":   bool.TryParse(kvp.Value, out settings.m_customizeRegularCam); break;
                        case "Customize Shooter Cam":   bool.TryParse(kvp.Value, out settings.m_customizeShooterCam); break;
                        case "Regular Cam Distance":    float.TryParse(kvp.Value, out settings.m_regularCamDistance); break;
                        case "Regular Cam Height":      float.TryParse(kvp.Value, out settings.m_regularCamHeight); break;
                        case "Shooter Cam X":           float.TryParse(kvp.Value, out settings.m_shooterCamX); break;
                        case "Shooter Cam Y":           float.TryParse(kvp.Value, out settings.m_shooterCamY); break;
                        case "Shooter Cam Z":           float.TryParse(kvp.Value, out settings.m_shooterCamZ); break;
                        case "Shooter Cam Pitch":       float.TryParse(kvp.Value, out settings.m_shooterCamPitch); break;
                        case "Shooter Cam Yaw":         float.TryParse(kvp.Value, out settings.m_shooterCamYaw); break;
                        case "Shooter Cam Height":      float.TryParse(kvp.Value, out settings.m_shooterCamHeight); break;

                        case "Customize Colors":        bool.TryParse(kvp.Value, out settings.m_customizeColors); break;
                        case "Brightness":              float.TryParse(kvp.Value, out settings.m_brightness); break;
                        case "Contrast":                float.TryParse(kvp.Value, out settings.m_contrast); break;
                        case "Saturation":              float.TryParse(kvp.Value, out settings.m_saturation); break;
                        case "Red Balance":             float.TryParse(kvp.Value, out settings.m_redBalance); break;
                        case "Green Balance":           float.TryParse(kvp.Value, out settings.m_greenBalance); break;
                        case "Blue Balance":            float.TryParse(kvp.Value, out settings.m_blueBalance); break;

                        case "Minimize To Tray":        bool.TryParse(kvp.Value, out settings.m_minimizeToTray); break;
                        case "Close To Tray":           bool.TryParse(kvp.Value, out settings.m_closeToTray); break;
                    }
                }

                return settings;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static bool TryParseColor(string htmlColor, Color defaultValue, out Color result)
        {
            try
            {
                result = ColorTranslator.FromHtml(htmlColor);
                return true;
            }
            catch (Exception)
            {
                result = defaultValue;
                return false;
            }
        }

        private static bool TryParseFont(string strFont, Font defaultValue, out Font result)
        {
            try
            {
                result = (Font)new FontConverter().ConvertFromString(strFont);
                return true;
            }
            catch (Exception)
            {
                result = defaultValue;
                return false;
            }
        }

        #endregion
    }
}
