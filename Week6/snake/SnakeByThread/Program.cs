using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeByThread
{
    class Program
    {
        static int direction = 1;

        static void MoveThread(object state)
        {
            while (true)
            {
                switch (direction)
                {
                    case 1:
                        GAME.snake.Move(1, 0);
                        break;
                    case 2:
                        GAME.snake.Move(0, 1);
                        break;
                    case 3:
                        GAME.snake.Move(-1, 0);
                        break;
                    case 4:
                        GAME.snake.Move(0, -1);
                        break;
                }
                GAME.Draw();
                Thread.Sleep(85);

                if (GAME.food.IsOnTheWall(GAME.wall) == false || GAME.food.IsOnTheSnake(GAME.snake) == false) // if wall and food in one place 
                {                                                                        // if snake and food in one place 
                    GAME.food.SetRandomPos();
                }

                if (GAME.snake.Die1(GAME.wall) == false || GAME.snake.Die2() == false) //  colision with itself or with wall 
                {
                    FileStream fs = new FileStream(@"GAME OVER.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(sr.ReadToEnd());
                    Console.ReadKey();
                    return;
                }
            }

        }

        static void Main(string[] args)
        {
            GAME.Start();
            
            Thread t = new Thread(MoveThread);
            t.Start();

            while (true)
            {
                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        direction = 4;
                        break;
                    case ConsoleKey.DownArrow:
                        direction = 2;
                        break;
                    case ConsoleKey.LeftArrow:
                        direction = 3;
                        break;
                    case ConsoleKey.RightArrow:
                        direction = 1;
                        break;
                }
            }
        }
    }
}