using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SnakeGame
{
    internal class FileWorker
    {
        private static string  filePath = "highscore.txt";


        public static void createFile()
        {
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("0");
                }
            }
        }

        public static void saveHighScore(string highScore)
        {
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, highScore);
            }
            else
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine(highScore);
                }
            }
        }

        public static string getHighScore()
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
            else
            {
                return "0";
            }
        }
    }
}
