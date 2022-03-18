using System;
using KeyWhere.Core.Native.Abstraction;

namespace KeyWhere.Core.Native.macOS
{
    public class MacOSInputManager : IMouseBase
    {
        public Point GetCursorPosition()
        {
            IntPtr ptr = MacOSNativeAPI.CGEventCreate(IntPtr.Zero);
            CGPoint location = MacOSNativeAPI.CGEventGetLocation(ptr);
            MacOSNativeAPI.CFRelease(ptr);

            return new Point(location.X, location.Y);
        }

        public void SetCursorPosition(Point point)
        {
            CGPoint ptr = new CGPoint() { X = point.X, Y = point.Y };
            MacOSNativeAPI.CGWarpMouseCursorPosition(ptr);
        }
    }
}
