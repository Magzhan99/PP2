using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFarManager
{
    class Program
    {

        static void ShowState(DirectoryInfo cursor, int position)
        {
            FileSystemInfo[] infos = cursor.GetFileSystemInfos();
            for(int i = 0; i < infos.Length; i++)
            {
                if (i == position)
                    Console.BackgroundColor = ConsoleColor.White;
                else
                    Console.BackgroundColor = ConsoleColor.Black;

                if (infos[i].GetType() == typeof(DirectoryInfo))
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(infos[i].Name);
            }
        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int pos = 0;

            DirectoryInfo dir = new DirectoryInfo(@"C:\users\user\desktop\just");

            while (true)
            {
                Console.CursorVisible = false;
                Console.Clear();
                ShowState(dir, pos);

                ConsoleKeyInfo button = Console.ReadKey();
                switch (button.Key)
                {
                    case ConsoleKey.UpArrow:
                        pos--;
                        if (pos < 0)
                            pos = dir.GetFileSystemInfos().Length - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        pos++;
                        if (pos > dir.GetFileSystemInfos().Length)
                            pos = 0;
                        break;
                    case ConsoleKey.Enter:
                        FileSystemInfo f = dir.GetFileSystemInfos()[pos];
                        if (f.GetType() == typeof(DirectoryInfo))
                        {
                            dir = new DirectoryInfo(f.FullName);
                            pos = 0;
                        }
                        else
                        {
                            FileStream g = new FileStream(f.FullName, FileMode.Open, FileAccess.Read);
                            StreamReader s = new StreamReader(g);

                            Console.Clear();
                            Console.WriteLine(s.ReadToEnd());
                            ConsoleKeyInfo knopka = Console.ReadKey();

                            while (knopka.Key != ConsoleKey.Q)
                            {
                                knopka = Console.ReadKey();
                            }
                        }
                        break;
                    case ConsoleKey.Escape:
                        dir = dir.Parent;
                        break;
                }

            }
        }
    }
}