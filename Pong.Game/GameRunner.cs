using System.Security.Principal;
using Pong.Game.Entities;
using Pong.Game.Types;

namespace Pong.Game
{
    public class GameRunner
    {
        private int Width { get; set; }
        private int Height { get; set; }

        readonly Paddle[] _players = new Paddle[2];
        private readonly Ball _ball;

        public GameRunner(int width, int height)
        {
            Width = width;
            Height = height;

            _ball = new Ball(new Vector2(width / 2, height / 2), new Vector2(5, 5), 20.0f);
            _players[0] = new Paddle(Vector2.Empty, Vector2.Empty, 20, 80);
            _players[1] = new Paddle(new Vector2(width - 20, 0), Vector2.Empty, 20, 80);
        }
        
        public void Tick(IDrawer drawer)
        {
            //ball
            _ball.Location += _ball.Direction;

            if (_ball.Location.X <= 0 || _ball.Location.X >= Width)
            {
                _ball.Direction = new Vector2(-_ball.Direction.X, _ball.Direction.Y);
            }

            if (_ball.Location.Y <= 0 || _ball.Location.Y >= Height)
            {
                _ball.Direction = new Vector2(_ball.Direction.X, -_ball.Direction.Y);
            }
            
            drawer.Draw(_ball);
            foreach (var player in _players)
            {
                drawer.Draw(player);
            }
        }
    }
}
