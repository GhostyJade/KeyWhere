using KeyWhere.Core.Native.Abstraction;

namespace KeyWhere.Core.Native.Windows
{
    public class WindowsInputManager : IMouseBase
    {
        public Point GetCursorPosition()
        {
            WindowsNativeAPI.GetCursorPos(out POINT p);
            return new Point(p.x, p.y);
        }

        public void SetCursorPosition(Point point)
        {
            WindowsNativeAPI.SetCursorPos((int)point.X, (int)point.Y);
        }
    }
}
