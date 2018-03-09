using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{[Serializable]
    class Wall
    {
        public List<Point> body;
        public string sign;
        public ConsoleColor color;
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

        public Wall(int level)
        {
            body = new List<Point>();
            sign = "o";
            color = ConsoleColor.Blue;
            Level(level);
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
    }
}
