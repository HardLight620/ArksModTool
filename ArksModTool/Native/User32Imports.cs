using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

internal static class User32Imports
{
    [DllImport("user32.dll", SetLastError = true)]
    internal static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll", SetLastError = true)]
    internal static extern IntPtr SetForegroundWindow(IntPtr hWnd);

    [DllImport("user32.dll", SetLastError = true)]
    internal static extern IntPtr GetActiveWindow();

    [DllImport("user32.dll", SetLastError = true)]
    internal static extern IntPtr GetFocus();

    [DllImport("user32.dll", SetLastError = true)]
    internal static extern bool ShowWindow(IntPtr hWnd, ShowWindowCommands nCmdShow);

    [DllImport("user32.dll", SetLastError=true)]
    internal static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);

    [DllImport("user32.dll", SetLastError = true)]
    internal static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

    [DllImport("user32.dll", SetLastError = true)]
    internal static extern UInt32 GetWindowLong(IntPtr hWnd, int nIndex);

    [DllImport("user32.dll", SetLastError = true)]
    internal static extern UInt32 SetWindowLong(IntPtr hWnd, int nIndex, UInt32 dwNewLong);

    [DllImport("user32.dll", SetLastError = true)]
    internal static extern int SetScrollPos(IntPtr hWnd, System.Windows.Forms.Orientation nBar, int nPos, bool bRedraw);

    [DllImport("user32.dll", SetLastError = true)]
    internal static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, RedrawWindowFlags flags);

    [DllImport("user32.dll", SetLastError = true)]
    internal static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll")]
    internal static extern bool FlashWindowEx(ref FLASHWINFO pwfi);


    internal const int GWL_HWNDPARENT = -8;
    internal const int GWL_ID = -12;
    internal const int GWL_STYLE = -16;
    internal const int GWL_EXSTYLE = -20;

    // Window Styles
    internal const UInt32 WS_OVERLAPPED = 0;
    internal const UInt32 WS_POPUP = 0x80000000;
    internal const UInt32 WS_CHILD = 0x40000000;
    internal const UInt32 WS_MINIMIZE = 0x20000000;
    internal const UInt32 WS_VISIBLE = 0x10000000;
    internal const UInt32 WS_DISABLED = 0x8000000;
    internal const UInt32 WS_CLIPSIBLINGS = 0x4000000;
    internal const UInt32 WS_CLIPCHILDREN = 0x2000000;
    internal const UInt32 WS_MAXIMIZE = 0x1000000;
    internal const UInt32 WS_CAPTION = 0xC00000;      // WS_BORDER or WS_DLGFRAME  
    internal const UInt32 WS_BORDER = 0x800000;
    internal const UInt32 WS_DLGFRAME = 0x400000;
    internal const UInt32 WS_VSCROLL = 0x200000;
    internal const UInt32 WS_HSCROLL = 0x100000;
    internal const UInt32 WS_SYSMENU = 0x80000;
    internal const UInt32 WS_THICKFRAME = 0x40000;
    internal const UInt32 WS_GROUP = 0x20000;
    internal const UInt32 WS_TABSTOP = 0x10000;
    internal const UInt32 WS_MINIMIZEBOX = 0x20000;
    internal const UInt32 WS_MAXIMIZEBOX = 0x10000;
    internal const UInt32 WS_TILED = WS_OVERLAPPED;
    internal const UInt32 WS_ICONIC = WS_MINIMIZE;
    internal const UInt32 WS_SIZEBOX = WS_THICKFRAME;

    // Extended Window Styles
    internal const UInt32 WS_EX_DLGMODALFRAME = 0x0001;
    internal const UInt32 WS_EX_NOPARENTNOTIFY = 0x0004;
    internal const UInt32 WS_EX_TOPMOST = 0x0008;
    internal const UInt32 WS_EX_ACCEPTFILES = 0x0010;
    internal const UInt32 WS_EX_TRANSPARENT = 0x0020;
    internal const UInt32 WS_EX_MDICHILD = 0x0040;
    internal const UInt32 WS_EX_TOOLWINDOW = 0x0080;
    internal const UInt32 WS_EX_WINDOWEDGE = 0x0100;
    internal const UInt32 WS_EX_CLIENTEDGE = 0x0200;
    internal const UInt32 WS_EX_CONTEXTHELP = 0x0400;
    internal const UInt32 WS_EX_RIGHT = 0x1000;
    internal const UInt32 WS_EX_LEFT = 0x0000;
    internal const UInt32 WS_EX_RTLREADING = 0x2000;
    internal const UInt32 WS_EX_LTRREADING = 0x0000;
    internal const UInt32 WS_EX_LEFTSCROLLBAR = 0x4000;
    internal const UInt32 WS_EX_RIGHTSCROLLBAR = 0x0000;
    internal const UInt32 WS_EX_CONTROLPARENT = 0x10000;
    internal const UInt32 WS_EX_STATICEDGE = 0x20000;
    internal const UInt32 WS_EX_APPWINDOW = 0x40000;
    internal const UInt32 WS_EX_OVERLAPPEDWINDOW = (WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE);
    internal const UInt32 WS_EX_PALETTEWINDOW = (WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST);
    internal const UInt32 WS_EX_LAYERED = 0x00080000;
    internal const UInt32 WS_EX_NOINHERITLAYOUT = 0x00100000; // Disable inheritence of mirroring by children
    internal const UInt32 WS_EX_LAYOUTRTL = 0x00400000; // Right to left mirroring
    internal const UInt32 WS_EX_COMPOSITED = 0x02000000;
    internal const UInt32 WS_EX_NOACTIVATE = 0x08000000;
}

internal enum ShowWindowCommands
{
    /// <summary>
    /// Hides the window and activates another window.
    /// </summary>
    Hide = 0,
    /// <summary>
    /// Activates and displays a window. If the window is minimized or
    /// maximized, the system restores it to its original size and position.
    /// An application should specify this flag when displaying the window
    /// for the first time.
    /// </summary>
    Normal = 1,
    /// <summary>
    /// Activates the window and displays it as a minimized window.
    /// </summary>
    ShowMinimized = 2,
    /// <summary>
    /// Maximizes the specified window.
    /// </summary>
    Maximize = 3, // is this the right value?
    /// <summary>
    /// Activates the window and displays it as a maximized window.
    /// </summary>      
    ShowMaximized = 3,
    /// <summary>
    /// Displays a window in its most recent size and position. This value
    /// is similar to <see cref="Win32.ShowWindowCommand.Normal"/>, except
    /// the window is not activated.
    /// </summary>
    ShowNoActivate = 4,
    /// <summary>
    /// Activates the window and displays it in its current size and position.
    /// </summary>
    Show = 5,
    /// <summary>
    /// Minimizes the specified window and activates the next top-level
    /// window in the Z order.
    /// </summary>
    Minimize = 6,
    /// <summary>
    /// Displays the window as a minimized window. This value is similar to
    /// <see cref="Win32.ShowWindowCommand.ShowMinimized"/>, except the
    /// window is not activated.
    /// </summary>
    ShowMinNoActive = 7,
    /// <summary>
    /// Displays the window in its current size and position. This value is
    /// similar to <see cref="Win32.ShowWindowCommand.Show"/>, except the
    /// window is not activated.
    /// </summary>
    ShowNA = 8,
    /// <summary>
    /// Activates and displays the window. If the window is minimized or
    /// maximized, the system restores it to its original size and position.
    /// An application should specify this flag when restoring a minimized window.
    /// </summary>
    Restore = 9,
    /// <summary>
    /// Sets the show state based on the SW_* value specified in the
    /// STARTUPINFO structure passed to the CreateProcess function by the
    /// program that started the application.
    /// </summary>
    ShowDefault = 10,
    /// <summary>
    ///  <b>Windows 2000/XP:</b> Minimizes a window, even if the thread
    /// that owns the window is not responding. This flag should only be
    /// used when minimizing windows from a different thread.
    /// </summary>
}

[Flags()]
internal enum SetWindowPosFlags : uint
{
    /// <summary>If the calling thread and the thread that owns the window are attached to different input queues,
    /// the system posts the request to the thread that owns the window. This prevents the calling thread from
    /// blocking its execution while other threads process the request.</summary>
    /// <remarks>SWP_ASYNCWINDOWPOS</remarks>
    AsynchronousWindowPosition = 0x4000,
    /// <summary>Prevents generation of the WM_SYNCPAINT message.</summary>
    /// <remarks>SWP_DEFERERASE</remarks>
    DeferErase = 0x2000,
    /// <summary>Draws a frame (defined in the window's class description) around the window.</summary>
    /// <remarks>SWP_DRAWFRAME</remarks>
    DrawFrame = 0x0020,
    /// <summary>Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE message to
    /// the window, even if the window's size is not being changed. If this flag is not specified, WM_NCCALCSIZE
    /// is sent only when the window's size is being changed.</summary>
    /// <remarks>SWP_FRAMECHANGED</remarks>
    FrameChanged = 0x0020,
    /// <summary>Hides the window.</summary>
    /// <remarks>SWP_HIDEWINDOW</remarks>
    HideWindow = 0x0080,
    /// <summary>Does not activate the window. If this flag is not set, the window is activated and moved to the
    /// top of either the topmost or non-topmost group (depending on the setting of the hWndInsertAfter
    /// parameter).</summary>
    /// <remarks>SWP_NOACTIVATE</remarks>
    DoNotActivate = 0x0010,
    /// <summary>Discards the entire contents of the client area. If this flag is not specified, the valid
    /// contents of the client area are saved and copied back into the client area after the window is sized or
    /// repositioned.</summary>
    /// <remarks>SWP_NOCOPYBITS</remarks>
    DoNotCopyBits = 0x0100,
    /// <summary>Retains the current position (ignores X and Y parameters).</summary>
    /// <remarks>SWP_NOMOVE</remarks>
    IgnoreMove = 0x0002,
    /// <summary>Does not change the owner window's position in the Z order.</summary>
    /// <remarks>SWP_NOOWNERZORDER</remarks>
    DoNotChangeOwnerZOrder = 0x0200,
    /// <summary>Does not redraw changes. If this flag is set, no repainting of any kind occurs. This applies to
    /// the client area, the nonclient area (including the title bar and scroll bars), and any part of the parent
    /// window uncovered as a result of the window being moved. When this flag is set, the application must
    /// explicitly invalidate or redraw any parts of the window and parent window that need redrawing.</summary>
    /// <remarks>SWP_NOREDRAW</remarks>
    DoNotRedraw = 0x0008,
    /// <summary>Same as the SWP_NOOWNERZORDER flag.</summary>
    /// <remarks>SWP_NOREPOSITION</remarks>
    DoNotReposition = 0x0200,
    /// <summary>Prevents the window from receiving the WM_WINDOWPOSCHANGING message.</summary>
    /// <remarks>SWP_NOSENDCHANGING</remarks>
    DoNotSendChangingEvent = 0x0400,
    /// <summary>Retains the current size (ignores the cx and cy parameters).</summary>
    /// <remarks>SWP_NOSIZE</remarks>
    IgnoreResize = 0x0001,
    /// <summary>Retains the current Z order (ignores the hWndInsertAfter parameter).</summary>
    /// <remarks>SWP_NOZORDER</remarks>
    IgnoreZOrder = 0x0004,
    /// <summary>Displays the window.</summary>
    /// <remarks>SWP_SHOWWINDOW</remarks>
    ShowWindow = 0x0040,
}

[Flags()]
internal enum RedrawWindowFlags : uint
{
    /// <summary>
    /// Invalidates the rectangle or region that you specify in lprcUpdate or hrgnUpdate.
    /// You can set only one of these parameters to a non-NULL value. If both are NULL, RDW_INVALIDATE invalidates the entire window.
    /// </summary>
    Invalidate = 0x1,

    /// <summary>Causes the OS to post a WM_PAINT message to the window regardless of whether a portion of the window is invalid.</summary>
    InternalPaint = 0x2,

    /// <summary>
    /// Causes the window to receive a WM_ERASEBKGND message when the window is repainted.
    /// Specify this value in combination with the RDW_INVALIDATE value; otherwise, RDW_ERASE has no effect.
    /// </summary>
    Erase = 0x4,

    /// <summary>
    /// Validates the rectangle or region that you specify in lprcUpdate or hrgnUpdate.
    /// You can set only one of these parameters to a non-NULL value. If both are NULL, RDW_VALIDATE validates the entire window.
    /// This value does not affect internal WM_PAINT messages.
    /// </summary>
    Validate = 0x8,

    NoInternalPaint = 0x10,

    /// <summary>Suppresses any pending WM_ERASEBKGND messages.</summary>
    NoErase = 0x20,

    /// <summary>Excludes child windows, if any, from the repainting operation.</summary>
    NoChildren = 0x40,

    /// <summary>Includes child windows, if any, in the repainting operation.</summary>
    AllChildren = 0x80,

    /// <summary>Causes the affected windows, which you specify by setting the RDW_ALLCHILDREN and RDW_NOCHILDREN values, to receive WM_ERASEBKGND and WM_PAINT messages before the RedrawWindow returns, if necessary.</summary>
    UpdateNow = 0x100,

    /// <summary>
    /// Causes the affected windows, which you specify by setting the RDW_ALLCHILDREN and RDW_NOCHILDREN values, to receive WM_ERASEBKGND messages before RedrawWindow returns, if necessary.
    /// The affected windows receive WM_PAINT messages at the ordinary time.
    /// </summary>
    EraseNow = 0x200,

    Frame = 0x400,

    NoFrame = 0x800
}

[StructLayout(LayoutKind.Sequential)]
public struct FLASHWINFO
{
    public UInt32 cbSize;
    public IntPtr hwnd;
    public UInt32 dwFlags;
    public UInt32 uCount;
    public UInt32 dwTimeout;
}