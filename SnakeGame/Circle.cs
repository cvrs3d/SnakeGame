using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public class Circle
    {
        public int X {  get; set; } 
        public int Y { get; set; }

        public Circle(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

    }
}
