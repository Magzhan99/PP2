using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeByThread
{
    class GAME
    {
        public static Snake snake;
        public static Wall wall;
        public static Food food;

        public static void Start()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(70, 35);

            snake = new Snake();
            food = new Food();
            wall = new Wall();
        }

        public static void Draw()
        {
            snake.Draw();
            food.Draw();
            wall.Draw();
            wall.ScoreWallDraw();
        }


    }
}
