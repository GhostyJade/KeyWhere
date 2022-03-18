using System.Runtime.InteropServices;
using KeyWhere.Core.Native;
using KeyWhere.Core.Native.macOS;
using KeyWhere.Core.Native.Windows;

namespace KeyWhere.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                new WindowsInputManager().SetCursorPosition(new Point(0, 0));
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                new MacOSInputManager().SetCursorPosition(new Point(0, 0));
            }
        }
    }
}
