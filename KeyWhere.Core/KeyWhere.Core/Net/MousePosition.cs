namespace KeyWhere.Core.Net
{
    public class MousePosition
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public MousePosition(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
