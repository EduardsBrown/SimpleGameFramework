using System.Numerics;

namespace Simple.Core
{
    public class Transform
    {
        public Vector2 Position { get; set; } = Vector2.Zero;
        public Vector2 Scale { get; set; } = Vector2.Zero;

        public float Rotation { get; set; } = 0;
    }
}
