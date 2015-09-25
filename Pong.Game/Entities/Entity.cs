using Pong.Game.Types;

namespace Pong.Game.Entities
{
    public abstract class Entity
    {
        public Vector2 Location { get; set; }

        public Vector2 Direction { get; set; }

        protected Entity(Vector2 location, Vector2 direction)
        {
            Location = location;
            Direction = direction;
        }
    }
}
