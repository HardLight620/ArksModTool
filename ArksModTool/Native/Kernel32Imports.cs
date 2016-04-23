using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

internal static class Kernel32Imports
{
    [DllImport("kernel32.dll")]
    internal static extern uint GetLastError();


    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool inheritHandle, int processId);

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool CloseHandle([In] IntPtr hObject);



    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr baseAddress, IntPtr buffer, int size, IntPtr numberOfBytesRead);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr baseAddress, IntPtr buffer, int size, IntPtr numberOfBytesWritten);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr baseAddress, byte[] buffer, int size, IntPtr numberOfBytesWritten);



    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr address, int size, Protection newProtect, out Protection oldProtect);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern IntPtr VirtualAlloc(IntPtr address, IntPtr size, AllocationType allocationType, MemoryProtection protect);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr address, int size, AllocationType allocationType, MemoryProtection protect);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern bool VirtualFree(IntPtr address, IntPtr size, AllocationType freeType);

    [DllImport("Kernel32.dll", SetLastError = true)]
    internal static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr address, IntPtr size, AllocationType freeType);


    [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    internal static extern IntPtr CreateFileMapping(IntPtr hFile, IntPtr lpFileMappingAttributes, FileMapProtection flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow, string lpName);

    [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    internal static extern IntPtr OpenFileMapping(uint dwDesiredAccess, bool bInheritHandle, string lpName);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern IntPtr MapViewOfFile(IntPtr hFileMappingObject, FileMapAccess dwDesiredAccess, UInt32 dwFileOffsetHigh, UInt32 dwFileOffsetLow, UIntPtr dwNumberOfBytesToMap);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern bool UnmapViewOfFile(IntPtr lpBaseAddress);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern IntPtr CreateNamedPipe(string lpName, PipeOpenModeFlags dwOpenMode, PipeModeFlags dwPipeMode, uint nMaxInstances, int nOutBufferSize, int nInBufferSize, uint nDefaultTimeOut, IntPtr lpSecurityAttributes);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern bool CallNamedPipe(string lpNamedPipeName, byte[] lpInBuffer, uint nInBufferSize, [Out] byte[] lpOutBuffer, uint nOutBufferSize, out uint lpBytesRead, uint nTimeOut);

    [DllImport("kernel32.dll")]
    internal static extern bool PeekNamedPipe(IntPtr hNamedPipe, IntPtr lpBuffer, uint nBufferSize, out uint lpBytesRead, out uint lpTotalBytesAvail, out uint lpBytesLeftThisMessage);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern unsafe bool WriteFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, System.Threading.NativeOverlapped* lpOverlapped);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern unsafe bool ReadFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, System.Threading.NativeOverlapped* overlapped);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern unsafe bool ConnectNamedPipe(IntPtr hNamedPipe, System.Threading.NativeOverlapped* lpOverlapped);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern bool DisconnectNamedPipe(IntPtr hNamedPipe);


    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern IntPtr LoadLibrary(string lpFileName);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern bool FreeLibrary(IntPtr hModule);
}

[Flags]
internal enum SnapshotFlags : uint
{
    HeapList = 0x00000001,
    Process = 0x00000002,
    Thread = 0x00000004,
    Module = 0x00000008,
    Module32 = 0x00000010,
    Inherit = 0x80000000,
    All = 0x0000001F,
    NoHeaps = 0x40000000
}

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
internal struct PROCESSENTRY32
{
    public const int MAX_PATH = 260;
    public UInt32 dwSize;
    public UInt32 cntUsage;
    public UInt32 th32ProcessID;
    public IntPtr th32DefaultHeapID;
    public UInt32 th32ModuleID;
    public UInt32 cntThreads;
    public UInt32 th32ParentProcessID;
    public Int32 pcPriClassBase;
    public UInt32 dwFlags;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
    public string szExeFile;
}

[Flags]
internal enum ProcessAccessFlags : uint
{
    All = 0x001F0FFF,
    Terminate = 0x00000001,
    CreateThread = 0x00000002,
    VirtualMemoryOperation = 0x00000008,
    VirtualMemoryRead = 0x00000010,
    VirtualMemoryWrite = 0x00000020,
    DuplicateHandle = 0x00000040,
    CreateProcess = 0x000000080,
    SetQuota = 0x00000100,
    SetInformation = 0x00000200,
    QueryInformation = 0x00000400,
    QueryLimitedInformation = 0x00001000,
    Synchronize = 0x00100000,

    VirtualMemoryAll = 0x00000038
}

internal enum Protection : uint
{
    PAGE_NOACCESS = 0x01,
    PAGE_READONLY = 0x02,
    PAGE_READWRITE = 0x04,
    PAGE_WRITECOPY = 0x08,
    PAGE_EXECUTE = 0x10,
    PAGE_EXECUTE_READ = 0x20,
    PAGE_EXECUTE_READWRITE = 0x40,
    PAGE_EXECUTE_WRITECOPY = 0x80,
    PAGE_GUARD = 0x100,
    PAGE_NOCACHE = 0x200,
    PAGE_WRITECOMBINE = 0x400
}

[Flags]
internal enum AllocationType
{
    Commit = 0x1000,
    Reserve = 0x2000,
    Decommit = 0x4000,
    Release = 0x8000,
    Reset = 0x80000,
    Physical = 0x400000,
    TopDown = 0x100000,
    WriteWatch = 0x200000,
    LargePages = 0x20000000
}

[Flags]
internal enum MemoryProtection
{
    Execute = 0x10,
    ExecuteRead = 0x20,
    ExecuteReadWrite = 0x40,
    ExecuteWriteCopy = 0x80,
    NoAccess = 0x01,
    ReadOnly = 0x02,
    ReadWrite = 0x04,
    WriteCopy = 0x08,
    GuardModifierflag = 0x100,
    NoCacheModifierflag = 0x200,
    WriteCombineModifierflag = 0x400
}

[Flags]
internal enum FileMapProtection : uint
{
    PageReadonly = 0x02,
    PageReadWrite = 0x04,
    PageWriteCopy = 0x08,
    PageExecuteRead = 0x20,
    PageExecuteReadWrite = 0x40,
    SectionCommit = 0x8000000,
    SectionImage = 0x1000000,
    SectionNoCache = 0x10000000,
    SectionReserve = 0x4000000,
}

[Flags]
public enum FileMapAccess : uint
{
    FileMapCopy = 0x0001,
    FileMapWrite = 0x0002,
    FileMapRead = 0x0004,
    FileMapAllAccess = 0x001f,
    FileMapExecute = 0x0020,
}

[Flags]
public enum PipeOpenModeFlags : uint
{
    PIPE_ACCESS_DUPLEX = 0x00000003,
    PIPE_ACCESS_INBOUND = 0x00000001,
    PIPE_ACCESS_OUTBOUND = 0x00000002,
    FILE_FLAG_FIRST_PIPE_INSTANCE = 0x00080000,
    FILE_FLAG_WRITE_THROUGH = 0x80000000,
    FILE_FLAG_OVERLAPPED = 0x40000000,
    WRITE_DAC = 0x00040000,
    WRITE_OWNER = 0x00080000,
    ACCESS_SYSTEM_SECURITY = 0x01000000
}

[Flags]
public enum PipeModeFlags : uint
{
    PIPE_TYPE_BYTE = 0x00000000,
    PIPE_TYPE_MESSAGE = 0x00000004,
    PIPE_READMODE_BYTE = 0x00000000,
    PIPE_READMODE_MESSAGE = 0x00000002,
    PIPE_WAIT = 0x00000000,
    PIPE_NOWAIT = 0x00000001,
    PIPE_ACCEPT_REMOTE_CLIENTS = 0x00000000,
    PIPE_REJECT_REMOTE_CLIENTS = 0x00000008
}