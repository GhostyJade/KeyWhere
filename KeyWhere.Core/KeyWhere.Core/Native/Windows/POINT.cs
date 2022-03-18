using System.Runtime.InteropServices;

namespace KeyWhere.Core.Native.Windows
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public long x;
        public long y;
    }
}
