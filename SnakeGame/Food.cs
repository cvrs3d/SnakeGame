using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{

    internal class Food : Circle
    {
        private Random random = new Random();
        public Food(int maxWidth, int maxHeight)
        {
            X = random.Next(12, maxWidth - 50) ; Y = random.Next(12, maxHeight - 50);
        }

        public Rectangle placeFood()
        {

            Rectangle r = new Rectangle(this.X, this.Y, Settings.Width, Settings.Height);

            return r;
        }
    }
}
