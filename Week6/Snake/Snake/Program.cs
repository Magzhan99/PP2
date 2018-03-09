using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Snake
{[Serializable]
    class Program
    {
        static int direction = 1;
        static int level = 1;
        static Snake snake = new Snake();
        static Wall wall = new Wall(level);
        static Random rdm = new Random();
        static int t = rdm.Next(0, 68);
        static int s = rdm.Next(0, 18);
        static int score = 0;
        static int speed = 100;
        //static int record = 0;

        public static void func()
        {
            while (true)
            {

                if ((t == snake.body[0].x && s == snake.body[0].y))
                {
                    snake.body.Add(new Point(t, s));
                    score++;
                    //speed = Math.Max(50, speed - 25);
                    // t = rdm.Next(0, 54);
                    //s = rdm.Next(0, 24);

                    CreateFood();
                    if (score % 3 == 0)
                    {
                        level++;
                        Console.Clear();
                        for (int i = 0; i < snake.body.Count; ++i)
                        {
                            snake.body[i].x = i + 10;
                            snake.body[i].y = 15;
                        }
                        wall = new Wall(level);
                    }
                }
                if (direction == 8)
                {
                    snake.Move(0, -1);
                }
                if (direction == 2)
                {
                    snake.Move(0, 1);
                }
                if (direction == 6)
                {
                    snake.Move(1, 0);
                }
                if (direction == 4)
                {
                    snake.Move(-1, 0);
                }
                if (snake.ColllisionWithWall(wall) || snake.Collision())
                {
                    Console.Clear();
                    Console.SetCursorPosition(20, 10);
                    Console.WriteLine("GAME OVER!!!");
                    speed = 100;
                    //F1(record);
                    score = 0;
                    Console.ReadKey();
                    Console.Clear();
                    snake = new Snake();
                    level = 1;
                    wall = new Wall(level);
                }

                Console.SetCursorPosition(t, s);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Q");
                snake.Draw();
                wall.Draw();
                Thread.Sleep(speed);

            }
        }
        static void CreateFood()
        {
            while (true)
            {

                int k = 0;
                rdm = new Random();
                t = rdm.Next(0, 68);
                s = rdm.Next(0, 18);
                for (int i = 0; i < wall.body.Count; ++i)
                {
                    for (int j = 0; j < snake.body.Count; ++j)
                    {
                        if ((snake.body[j].x == t && snake.body[j].y == s) || (wall.body[i].x == t && wall.body[i].y == s))
                            k = 1;
                    }
                }
                if (k == 0)
                {
                    Console.SetCursorPosition(t, s);
                    Console.WriteLine("Q");
                    break;
                }
            }
        }

        /*static void F1(int record)
        {
            StreamWriter sr = new StreamWriter(@"C:\Users\User\Desktop\Snake\Snake\bin\Debug\record.txt");
            sr.WriteLine(record);
            sr.Close();
        }
        static int F2()
        {
            StreamReader sr = new StreamReader(@"C:\Users\User\Desktop\Snake\Snake\bin\Debug\record.txt");
            string line = sr.ReadLine();
            sr.Close();
            int n = int.Parse(line);
            return n;
        }*/
        static void F3(Snake snake)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("data2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(fs, snake);
            fs.Close();

        }
        static Snake F4()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("data2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Snake snake = bf.Deserialize(fs) as Snake;
            fs.Close();
            return snake;
        }
            
        static void F5(Wall wal)
        {
            BinaryFormatter bb = new BinaryFormatter();
            FileStream ff = new FileStream("data3.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bb.Serialize(ff, wal);
            ff.Close();
        }

        static Wall F6()
        {
            BinaryFormatter bn = new BinaryFormatter();
            FileStream st = new FileStream("data3.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Wall wall = bn.Deserialize(st) as Wall;
            st.Close();
            return wall;
        }

        static void F7(int sco)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("data4.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(fs, sco);
            fs.Close();
        }

        static int F8()
        {
            BinaryFormatter bn = new BinaryFormatter();
            FileStream st = new FileStream("data4.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            int sc = (int)bn.Deserialize(st);
            st.Close();
            return sc;
        }

        static void Main(string[] args)
        {
            //record = F2();
            Console.CursorVisible = false;
            Console.SetWindowSize(71, 30);

            Console.SetCursorPosition(5, 10);
            Console.WriteLine("Enter your name : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(25, 10);
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("If you want to continue type W");
            ConsoleKeyInfo ki = Console.ReadKey();
            Console.Clear();
            if (ki.Key == ConsoleKey.W)
            {
                snake = F4();
                wall = F6();
                score = F8();
            }

            Thread thread = new Thread(func);
            thread.Start();

            Console.SetCursorPosition(t, s);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Q");

            while (true)
            {
                Console.SetCursorPosition(1, 27);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(name);
                Console.SetCursorPosition(name.Length + 2, 27);
                //record = Math.Max(record, score);
                Console.WriteLine("Score : " + score);
                //Console.WriteLine("Record: " + record);
                ConsoleKeyInfo k = Console.ReadKey();

                if (k.Key == ConsoleKey.UpArrow && direction != 2)
                    direction = 8;
                if (k.Key == ConsoleKey.DownArrow && direction != 8)
                    direction = 2;
                if (k.Key == ConsoleKey.RightArrow && direction != 4)
                    direction = 6;
                if (k.Key == ConsoleKey.LeftArrow && direction != 6)
                    direction = 4;
                if (k.Key == ConsoleKey.Q)
                {
                    F3(snake);
                    F5(wall);
                    F7(score);
                }
            }
        }
    }
}
