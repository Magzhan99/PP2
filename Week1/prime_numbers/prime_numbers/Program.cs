using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            args = n.Split(' ');
            foreach (string t in args)
            {
                int a = int.Parse(t);
                int ok = 1;
                for (int j = 2; j <= Math.Sqrt(a); j++)
                {
                    if(a % j == 0)
                    {
                        ok = 0;
                    }
                }
                if(ok == 1)
                {
                    Console.WriteLine(a);
                    ok = 1;
                }
            }
            Console.ReadKey();
        }
    }
}
