using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeByThread 
{
    class Wall
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

        public Wall()
        {
            sign = '#';
            color = ConsoleColor.DarkYellow;

            body = new List<Point>();
            Level(1);
        }


        public void Level(int a)
        {
            string path = string.Format(@"levels\level{0}.txt", a);
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line = "";
            int i = 0;
            int row = 0;
            while (i < 20)
            {
                line = sr.ReadLine();
                for (int col = 0; col < line.Length; col++)
                {
                    if (line[col] == '#')
                    {
                        body.Add(new Point(col, row));
                    }
                }
                i++;
                row++;
            }
        }

        public void Draw()
        {
            Console.ForegroundColor = color;

            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }

        }

        public void ScoreWallDraw()
        {
            List<Point> score;
            score = new List<Point>();
            for (int j = 0; j < 11; j++)
            {
                score.Add(new Point(j, 23));
                score.Add(new Point(j, 25));
            }
            for (int j = 23; j < 26; j++)
                score.Add(new Point(11, j));

            int i = 0;
            foreach (Point p in score)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write('.');
                i++;
            }
        }


    }
}