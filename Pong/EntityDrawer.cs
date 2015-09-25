using System.Drawing;
using Pong.Game;
using Pong.Game.Entities;

namespace Pong.Visualisation
{
    public class EntityDrawer : IDrawer
    {
        private readonly Graphics _graphics;
        private readonly Pen _blackPen = new Pen(Brushes.Black);

        public EntityDrawer(Graphics graphics)
        {
            _graphics = graphics;
        }

        public void Draw(Ball ball)
        {
            _graphics.DrawEllipse(_blackPen, ball.Location.X - ball.Radius, ball.Location.Y - ball.Radius, ball.Radius, ball.Radius);
        }

        public void Draw(Paddle paddle)
        {
            _graphics.DrawRectangle(_blackPen, paddle.Location.X - paddle.Width / 2.0f, paddle.Location.Y - paddle.Height / 2.0f, paddle.Width, paddle.Height);
        }
    }
}
