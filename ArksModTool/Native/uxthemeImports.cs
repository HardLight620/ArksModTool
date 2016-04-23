using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

internal static class uxtheme
{
    public static bool IsAvailable()
    {
        IntPtr hModule = Kernel32Imports.LoadLibrary("uxtheme.dll");

        Kernel32Imports.FreeLibrary(hModule);

        return hModule != IntPtr.Zero;
    }

    [DllImport("uxtheme.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public extern static int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);
}