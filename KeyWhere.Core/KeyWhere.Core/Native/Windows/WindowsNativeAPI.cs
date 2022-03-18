using System.Runtime.InteropServices;

namespace KeyWhere.Core.Native.Windows
{
    public static class WindowsNativeAPI
    {
        [DllImport("user32.dll")]
        internal static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        internal static extern bool GetCursorPos(out POINT lpPoint);
    }
}
