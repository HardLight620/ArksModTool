using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

internal static class advapi32Imports
{
    [DllImport("advapi32.dll", SetLastError = true)]
    internal static extern bool AdjustTokenPrivileges(IntPtr tokenHandle,
                                                       bool disableAllPrivileges,
                                                       ref TOKEN_PRIVILEGES newState,
                                                       UInt32 bufferLengthInBytes,
                                                       ref TOKEN_PRIVILEGES previousState,
                                                       out UInt32 returnLengthInBytes);

    [DllImport("advapi32.dll", SetLastError = true)]
    internal static extern bool OpenProcessToken(IntPtr processHandle, UInt32 desiredAccess, ref IntPtr tokenHandle);

    [DllImport("advapi32.dll", SetLastError = true)]
    internal static extern bool LookupPrivilegeValue(string systemName, string name, ref LUID luid);



    internal const int SE_PRIVILEGE_ENABLED = 0x00000002;

    internal const int ERROR_NOT_ALL_ASSIGNED = 1300;

    internal const UInt32 STANDARD_RIGHTS_REQUIRED = 0x000F0000;
    internal const UInt32 STANDARD_RIGHTS_READ = 0x00020000;
    internal const UInt32 TOKEN_ASSIGN_PRIMARY = 0x0001;
    internal const UInt32 TOKEN_DUPLICATE = 0x0002;
    internal const UInt32 TOKEN_IMPERSONATE = 0x0004;
    internal const UInt32 TOKEN_QUERY = 0x0008;
    internal const UInt32 TOKEN_QUERY_SOURCE = 0x0010;
    internal const UInt32 TOKEN_ADJUST_PRIVILEGES = 0x0020;
    internal const UInt32 TOKEN_ADJUST_GROUPS = 0x0040;
    internal const UInt32 TOKEN_ADJUST_DEFAULT = 0x0080;
    internal const UInt32 TOKEN_ADJUST_SESSIONID = 0x0100;
    internal const UInt32 TOKEN_READ = (STANDARD_RIGHTS_READ | TOKEN_QUERY);
    internal const UInt32 TOKEN_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED |
                        TOKEN_ASSIGN_PRIMARY |
                        TOKEN_DUPLICATE |
                        TOKEN_IMPERSONATE |
                        TOKEN_QUERY |
                        TOKEN_QUERY_SOURCE |
                        TOKEN_ADJUST_PRIVILEGES |
                        TOKEN_ADJUST_GROUPS |
                        TOKEN_ADJUST_DEFAULT |
                        TOKEN_ADJUST_SESSIONID);

}

[StructLayout(LayoutKind.Sequential)]
internal struct LUID
{
    internal Int32 LowPart;
    internal UInt32 HighPart;
}

[StructLayout(LayoutKind.Sequential)]
internal struct TOKEN_PRIVILEGES
{
    internal Int32 PrivilegeCount;
    internal LUID Luid;
    internal Int32 Attributes;
}