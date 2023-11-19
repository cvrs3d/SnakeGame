using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private Food food;
        private Snake snake = new Snake();

        int score;
        int highscore;

        Random random = new Random();

        bool goLeft, goDown, goUp, goRight = false;

        public Form1()
        {
            InitializeComponent();
            new Settings(playCanvas);
            new FileWorker();
            food = new Food(Settings.maxWidth, Settings.maxHeight);
            FileWorker.createFile();
            highscore = int.Parse(FileWorker.getHighScore());
            gameOverPic.Visible = false;
        }

        private void startGame(object sender, EventArgs e)
        {
            restartGame();
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != Direction.right)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != Direction.left)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != Direction.down)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != Direction.up)
            {
                goDown = true;
            }



        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void gameEvent(object sender, EventArgs e)
        {
            if (goLeft)
            {
                Settings.directions = Direction.left;

            }
            if (goRight)
            {
                Settings.directions = Direction.right;

            }
            if (goDown)
            {
                Settings.directions = Direction.down;

            }
            if (goUp)
            {
                Settings.directions = Direction.up;

            }


            int length = snake.snakeLength();

            for(int i = length - 1 ; i >= 0; i--)
            {
                snake.makeMove(position: i, maxWidth: Settings.maxWidth, maxHeight: Settings.maxHeight) ;

                if (snake.isCollidingWithFood(food))
                {
                    eatFood();
                }
            }
            for (int j = length / 2; j < length; j++)
            {
                if (snake.isCollidingWithItself(j))
                {
                    gameOver();
                }
            }

            playCanvas.Invalidate();

        }

        private void updatePicBox(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColor = Brushes.DarkGreen;
            int length = snake.snakeLength();

            for (int i = 0; i < length; i++)
            {
                canvas.FillEllipse(snakeColor, snake.placeSnakePart(i));
            }

            Brush foodBrush = Brushes.Red;

            canvas.FillEllipse(foodBrush,
                food.placeFood());

        }

        private void restartGame()
        {
            gameOverPic.Visible = false;
            new Settings(playCanvas);
            snake.desposeSnake();
            

            startButton.Enabled = false;
            saveButton.Enabled = false;

            score = 0;
            
            updateTxtScore(score, txtScore);
            updateTxtScore(highscore, txtHighScore);
            txtHighScore.ForeColor = Color.Magenta;

            snake.createSnake();
            snake.updateSnake(bodyParts: 5);

            
            food = new Food(Settings.maxWidth,  Settings.maxHeight);

            gameTimer.Start();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileWorker.saveHighScore(highScore: highscore.ToString());
        }

        private void eatFood()
        {
            score += 1;
            updateTxtScore(score, txtScore);

            snake.feedSnake();

            food = new Food(Settings.maxWidth, Settings.maxHeight);


        }

        private void gameOver()
        {
            gameOverPic.Visible = true;
            gameTimer.Stop();
            startButton.Enabled = true;
            saveButton.Enabled = true;

            if(score > highscore)
            {
                highscore = score;  
            }
        }
        private void updateTxtScore(int score, Label txt)
        {
            txt.Text = score.ToString();
        }

    }   
}
