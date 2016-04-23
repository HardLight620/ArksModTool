using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


internal static class PrivilegeHelper
{
    public static TOKEN_PRIVILEGES SetPrivilege(string privilegeName)
    {
        IntPtr cpHandle = Process.GetCurrentProcess().Handle;
        IntPtr pHandle = IntPtr.Zero;
        IntPtr tHandle = IntPtr.Zero;

        TOKEN_PRIVILEGES tNewState = GetTokenPrivilege(privilegeName, true);
        TOKEN_PRIVILEGES tOldState = new TOKEN_PRIVILEGES();

        uint cb = (uint)Marshal.SizeOf(typeof(TOKEN_PRIVILEGES));
        uint tAccess = advapi32Imports.TOKEN_QUERY | advapi32Imports.TOKEN_ADJUST_PRIVILEGES;

        advapi32Imports.OpenProcessToken(cpHandle, tAccess, ref tHandle);
        advapi32Imports.AdjustTokenPrivileges(tHandle, false, ref tNewState, cb, ref tOldState, out cb);

        Kernel32Imports.CloseHandle(tHandle);

        return tOldState;
    }

    public static void RestorePrivilege(TOKEN_PRIVILEGES tokenPrivilage)
    {
        IntPtr cpHandle = Process.GetCurrentProcess().Handle;
        IntPtr pHandle = IntPtr.Zero;
        IntPtr tHandle = IntPtr.Zero;

        TOKEN_PRIVILEGES tOldState = new TOKEN_PRIVILEGES();

        uint cb = (uint)Marshal.SizeOf(typeof(TOKEN_PRIVILEGES));
        uint tAccess = advapi32Imports.TOKEN_QUERY | advapi32Imports.TOKEN_ADJUST_PRIVILEGES;

        advapi32Imports.OpenProcessToken(cpHandle, tAccess, ref tHandle);
        advapi32Imports.AdjustTokenPrivileges(tHandle, false, ref tokenPrivilage, cb, ref tOldState, out cb);

        Kernel32Imports.CloseHandle(tHandle);
    }

    private static TOKEN_PRIVILEGES GetTokenPrivilege(string privilage, bool enabled)
    {
        TOKEN_PRIVILEGES tp = new TOKEN_PRIVILEGES();
        LUID luid = new LUID();

        if (!advapi32Imports.LookupPrivilegeValue(null, privilage, ref luid))
            return tp;

        tp.PrivilegeCount = 1;
        tp.Luid = luid;
        tp.Attributes = 0;

        if (enabled)
            tp.Attributes = advapi32Imports.SE_PRIVILEGE_ENABLED;

        return tp;
    }
}