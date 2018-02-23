using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeByThread 
{
    class Food
    {
        public char sign;
        public Point loc;
        public ConsoleColor color;

        public Food()
        {
            sign = '@';
            color = ConsoleColor.Red;
            SetRandomPos();
        }

        public void SetRandomPos()
        {
            int x = new Random().Next(0, 70);
            int y = new Random().Next(0, 20);

            loc = new Point(x, y);
        }

        public void Draw()
        {
            Console.ForegroundColor = color;

            Console.SetCursorPosition(loc.x, loc.y);
            Console.Write(sign);
        }

        public bool IsOnTheWall(Wall w)
        {
            for (int i = 1; i < w.body.Count; i++)
                if (loc.x == w.body[i].x && loc.y == w.body[i].y)
                    return false;
            return true;
        }
        public bool IsOnTheSnake(Snake s)
        {
            for (int i = 1; i < s.body.Count; i++)
                if (loc.x == s.body[i].x && loc.y == s.body[i].y)
                    return false;
            return true;
        }

    }
}