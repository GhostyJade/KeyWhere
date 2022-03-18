using System;
using System.Runtime.InteropServices;

namespace KeyWhere.Core.Native.macOS
{
    public static class MacOSNativeAPI
    {
        [DllImport("/System/Library/Frameworks/CoreGraphics.framework/CoreGraphics")]
        public static extern int CGWarpMouseCursorPosition(CGPoint point);

        [DllImport("/System/Library/Frameworks/CoreGraphics.framework/CoreGraphics")]
        public static extern IntPtr CGEventCreate(IntPtr source);

        [DllImport("/System/Library/Frameworks/CoreGraphics.framework/CoreGraphics")]
        public static extern CGPoint CGEventGetLocation(IntPtr evt);

        [DllImport("/System/Library/Frameworks/CoreGraphics.framework/CoreGraphics")]
        public static extern void CFRelease(IntPtr cf);
    }
}
