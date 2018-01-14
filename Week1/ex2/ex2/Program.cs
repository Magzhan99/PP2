using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 16; counter++)
            {
                int reminder3 = counter % 3;
                int reminder5 = counter % 5;

                /*if (reminder3 == 0 && reminder5 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                }
                else */if (reminder3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                }
                if (reminder5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                }
                else
                {
                    System.Console.WriteLine(counter);
                }
            }
            string s = Console.ReadLine();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
