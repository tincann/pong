using Pong.Game.Types;

namespace Pong.Game.Entities
{
    public class Ball : Entity
    {
        public float Radius { get; private set; }

        public Ball(Vector2 location, Vector2 direction, float radius) : base(location, direction)
        {
            Radius = radius;
        }
    }
}
