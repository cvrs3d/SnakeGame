using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    internal class Settings
    {
        public static int Width { get; set; }   
        public static int Height { get; set; }

        public static  Direction directions;

        public static int maxWidth;
        public static int maxHeight;

        public Settings(Control playCanvas)
        {
            Width = 16;
            Height = 16;
            directions = Direction.right;
            maxHeight = playCanvas.Height - 1;
            maxWidth = playCanvas.Width - 1;
        }
    }

    public enum Direction
    {
        initial,
        right ,
        left,
        up,
        down,
    }
}
