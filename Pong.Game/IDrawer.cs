using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pong.Game.Entities;

namespace Pong.Game
{
    public interface IDrawer
    {
        void Draw(Ball ball);
        void Draw(Paddle ball);
    }
}
