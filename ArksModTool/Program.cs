using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArksModTool
{
    static class Program
    {
        public static int PID { get { return System.Diagnostics.Process.GetCurrentProcess().Id; } }
        public static Version Version { get { return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version; } }
        public static DateTime BuildTime { get { return DateTime.Parse(ArksModTool.Properties.Resources.time); } }

        public static Settings Settings { get; private set; }

        public static Icon Icon { get { return m_icon; } set { m_icon = value; } }
        private static Icon m_icon = Properties.Resources.icon;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            Settings = Settings.Load("Preferences.ini") ?? new Settings();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            ApplicationEx.ClearExitState();

            Settings.Save("Preferences.ini");

            if (Updater.UpdatePackage != null)
                Updater.DoUpdate();
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs e)
        {
            AssemblyName requestedAssembly = new AssemblyName(e.Name);
            if (requestedAssembly.Name == "SharpDX")
                return Assembly.Load(ArksModTool.Properties.Resources.SharpDX);
            else if (requestedAssembly.Name == "SharpDX.DirectInput")
                return Assembly.Load(ArksModTool.Properties.Resources.SharpDX_DirectInput);

            return null;
        }
    }
}
