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
        static int Primess(int a)
        {
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                    return 0;
            }
            return 1;
        }

        static void Main(string[] args)
        {
            FileStream f1  = new FileStream(@"C:\users\user\desktop\just\папка2\read.txt", FileMode.Open, FileAccess.Read);
            StreamReader s1 = new StreamReader(f1);

            string s = s1.ReadLine();

            Console.WriteLine(s);

            string[] numbers = s.Split(' ');
            int mini = int.Parse(numbers[0]);

            for(int i = 0; i < numbers.Length; i++)
            {
                int t = int.Parse(numbers[i]);
                if (t < mini && Primess(t)==1)
                {
                    mini = t;
                }
            }
            FileStream f2 = new FileStream(@"C:\Users\user\Desktop\just\папка2\write.txt", FileMode.Open , FileAccess.Write);
            StreamWriter s2 = new StreamWriter(f2);
            s2.WriteLine(mini);

            s2.Close();
        }

    }
}
