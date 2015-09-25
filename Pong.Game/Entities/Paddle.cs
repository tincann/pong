using Pong.Game.Types;

namespace Pong.Game.Entities
{
    public class Paddle : Entity
    {
        public readonly float Width;
        public readonly float Height;

        public Paddle(Vector2 location, Vector2 direction, int width, int height) : base(location, direction)
        {
            Width = width;
            Height = height;
        }
    }
}
