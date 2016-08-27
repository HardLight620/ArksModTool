using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ArksModTool
{
    static class Updater
    {
        public static readonly string PROJECT_PAGE = "http://www.pso-world.com/forums/showthread.php?p=3287385#post3287385";
        public static readonly string DEFAULT_SERVER = @"https://raw.githubusercontent.com/HardLight620/ArksModTool/master/Distribution/";
        public static readonly string DEFAULT_SERVER_BUILD = DEFAULT_SERVER + (IntPtr.Size == 8 ? "x64" : "x86");

        public static string UpdatePackage { get { return m_updatePackage; } set { m_updatePackage = value; } }
        private static string m_updatePackage = null;

        public static FormWindowState RestartState { get { return m_restartState; } set { m_restartState = value; } }
        private static FormWindowState m_restartState = FormWindowState.Normal;

        static Updater()
        {

        }

        public static void DoUpdate()
        {
            string appPath = Assembly.GetExecutingAssembly().Location;

            bool rollbackOkay = TrySetupRollback(appPath);
            bool updateOkay = rollbackOkay && TryExtractUpdatePackage(m_updatePackage, appPath);

            Cleanup(m_updatePackage);

            Launch(appPath, updateOkay);
        }

        private static bool TrySetupRollback(string appPath)
        {
            try { return SetupRollback(appPath); }
            catch (Exception ex) { MessageBox.Show(string.Format("ERROR: Could not create backup folder.\n{0}", ex.Message), "Update Error"); }
            return false;
        }

        private static bool SetupRollback(string appPath)
        {
            string backupDir = Path.GetFileName(Path.ChangeExtension(appPath, "bak"));

            Directory.CreateDirectory(backupDir);

            string[] dataFiles = new string[] { "Readme.txt", "Preferences.ini" };
            foreach (string path in dataFiles)
            {
                FileInfo file = new FileInfo(path);
                string rollbackPath = Path.Combine(backupDir, file.Name);
                if (file.Exists)
                    file.CopyTo(rollbackPath, true);
            }

            FileInfo executable = new FileInfo(appPath);
            FileInfo backupExe = new FileInfo(Path.Combine(backupDir, executable.Name));
            if (executable.Exists)
            {
                backupExe.Delete();
                executable.MoveTo(backupExe.FullName);
            }

            return true;
        }

        private static bool TryExtractUpdatePackage(string updateArchive, string appPath)
        {
            try { return ExtractUpdatePackage(updateArchive, appPath); }
            catch (Exception ex) { MessageBox.Show(string.Format("ERROR: Could not extract update files.\n{0}", ex.Message), "Update Error"); }
            return false;
        }

        private static bool ExtractUpdatePackage(string archiveFileName, string appPath)
        {
            using (ZipArchive archive = ZipFile.OpenRead(archiveFileName))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    string path = entry.FullName;
                    string directory = Path.GetDirectoryName(path);

                    if (!string.IsNullOrWhiteSpace(directory))
                        Directory.CreateDirectory(directory);

                    if (Path.GetFileName(path) == "ArksModTool.exe")
                        path = Path.Combine(Path.GetDirectoryName(path), Path.GetFileName(appPath));

                    using (Stream stream = entry.Open())
                    using (FileStream fstream = new FileStream(path, System.IO.FileMode.Create))
                        stream.CopyTo(fstream);
                }
            }

            return true;
        }

        private static void Cleanup(string updatePackage)
        {
            try { File.Delete(updatePackage); }
            catch (Exception) { }
        }

        private static void Launch(string appPath, bool updateOkay)
        {
            string args = string.Format("-on_update {0}", (updateOkay ? "success" : "failure"));

            PROCESS_INFORMATION pInfo = new PROCESS_INFORMATION();
            STARTUPINFO sInfo = new STARTUPINFO();
            sInfo.cb = Marshal.SizeOf(sInfo);
            sInfo.dwFlags = 1;
            sInfo.wShowWindow = 1;

            if (m_restartState == FormWindowState.Maximized)
                sInfo.wShowWindow = 3; // SW_MAXIMIZE
            else if (m_restartState == FormWindowState.Minimized)
                sInfo.wShowWindow = 7; // SW_SHOWMINNOACTIVE
            else
                sInfo.wShowWindow = 1; // SW_SHOWNORMAL

            Kernel32Imports.CreateProcess(appPath, args, IntPtr.Zero, IntPtr.Zero, false, 0, IntPtr.Zero, null, ref sInfo, out pInfo);
        }
    }
}