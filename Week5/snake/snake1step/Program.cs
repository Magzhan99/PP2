using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake1step
{
    class Program
    {
        public static int direction = 1; 

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(85, 35);

            Snake snake = new Snake();
            Food food = new Food();
            Wall wall = new Wall();
            int score = 0;
            void Thread(object state)
            {

                while (!snake.Die1(wall) || !snake.Die2())
                {
                    switch (direction)
                    {
                        case 1:
                            snake.Move(1, 0);
                            break;
                        case 2:
                            snake.Move(0, 1);
                            break;
                        case 3:
                            snake.Move(-1, 0);
                            break;
                        case 4:
                            snake.Move(0, -1);
                            break;
                    }
                }
            }

            Thread t = new Thread(Thread);
            t.Start();

            while (!snake.Die1(wall) || !snake.Die2())
            {
                snake.Draw();
                food.Draw();
                wall.Draw();

                ConsoleKeyInfo button = Console.ReadKey();
                switch (button.Key)
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
                wall.ScoreWallDraw();

                if (snake.body[0].x < 0)
                    snake.body[0].x = 69;
                if (snake.body[0].x > 69)
                    snake.body[0].x = 0;
                if (snake.body[0].y < 0)
                    snake.body[0].y = 19;
                if (snake.body[0].y > 19)
                    snake.body[0].y = 0;

                if (snake.Eat(food))
                {
                    food.SetRandomPos();
                    score += 5;
                    Console.SetCursorPosition(0, 33);
                    Console.WriteLine("Score: " + score);
                }


                if(food.IsOnTheWall(wall) == false || food.IsOnTheSnake(snake) == false) // if wall and food in one place 
                {                                                                        // if snake and food in one place 
                    food.SetRandomPos();
                }

                if (snake.Die1(wall) == false || snake.Die2() == false) //  colision with itself or with wall 
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
    }
} 