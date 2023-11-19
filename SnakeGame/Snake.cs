using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Snake
    {

        private static List<Circle> SnakeBody {  get; set; }
        private static int step = 16;

        public Snake()
        {
            SnakeBody = new List<Circle>();
        }

        public bool isCollidingWithFood(Food food)
        {
            Rectangle head = new Rectangle(SnakeBody[0].X, SnakeBody[0].Y, Settings.Width, Settings.Height);
            Rectangle f = new Rectangle(food.X, food.Y, Settings.Width, Settings.Height);

            return head.IntersectsWith(f);
        }
        public bool isCollidingWithItself(int pos2)
        {
            Rectangle head = new Rectangle(SnakeBody[0].X, SnakeBody[0].Y, Settings.Width, Settings.Height);
            Rectangle body = new Rectangle(SnakeBody[pos2].X, SnakeBody[pos2].Y, Settings.Width, Settings.Height);

            return head.IntersectsWith(body);
        }

        public void feedSnake()
        {
            Circle body = new Circle
                (
                x: SnakeBody[snakeLength() - 1].X,
                y: SnakeBody[snakeLength() - 1].Y
                );
            SnakeBody.Add( body );
        }

        public void desposeSnake()
        {
            SnakeBody.Clear();
        }

        public void createSnake()
        {
            Circle head = new Circle (x: 12, y: 12);
            SnakeBody.Add(head);
        }

        public void updateSnake(int bodyParts = 5)
        {
            for(int  i = 0; i < bodyParts; i++)
            {
                Circle body = new Circle();
                SnakeBody.Add(body);
            }
        }

        public int snakeLength()
        {
            return SnakeBody.Count;
        }

        public Rectangle placeSnakePart(int position)
        {

            Rectangle r = new Rectangle(SnakeBody[position].X, SnakeBody[position].Y,
                Settings.Width, Settings.Height);

            return r;
        }

        public void makeMove(int position, int maxWidth, int maxHeight)
        {
            if(position == 0)
            {
                switch (Settings.directions)
                {
                    case Direction.right:
                        SnakeBody[position].X += step;
                        break;
                    case Direction.left:
                        SnakeBody[position].X -= step;
                        break;
                    case Direction.up:
                        SnakeBody[position].Y -= step;
                        break;
                    case Direction.down:
                        SnakeBody[position].Y += step;
                        break;

                }
                if (SnakeBody[position].X < 0)
                {
                    SnakeBody[position].X = maxWidth; 
                }
                if(SnakeBody[position].X > maxWidth)
                {
                    SnakeBody[position].X = 0;
                }
                if (SnakeBody[position].Y < 0)
                {
                    SnakeBody[position].Y = maxHeight;
                }
                if (SnakeBody[position].Y > maxHeight)
                {
                    SnakeBody[position].Y = 0;
                }
            }
            else
            {
                SnakeBody[position].X = SnakeBody[position - 1].X;
                SnakeBody[position].Y = SnakeBody[position - 1].Y;
            }
        }

    }
}
