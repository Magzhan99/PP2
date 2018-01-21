using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class Program
    {
        static void Primess(int a)
        {
            int ok = 1;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                    ok = 0;
            }
            if (ok == 1)
            {
                Console.Write(a);
            }
        }

        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\users\user\desktop\just\папка2\файл2.1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadLine();

            Console.WriteLine(s);

            string[] numbers = s.Split(' ');
            

            for(int i = 0; i < numbers.Length; i++)
            {
                int x = int.Parse(numbers[i]);
                Primess(x);
            }
            Console.WriteLine(numbers);
            Console.ReadKey();
        }

    }
}
