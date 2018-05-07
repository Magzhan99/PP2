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
        static void Main(string[] args)
        {

            FileStream fs = new FileStream(@"C:\users\user\desktop\just\папка2\read.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadLine();
            sr.Close();
            fs.Close();
            string[] numbers = s.Split(' ');

            int maxi = int.Parse(numbers[0]);
            int mini = int.Parse(numbers[0]);

            for (int i = 1; i < numbers.Length; i++)
            {
                int x = int.Parse(numbers[i]);
                if (x > maxi)
                    maxi = int.Parse(numbers[i]);
                if (x < mini)
                    mini = int.Parse(numbers[i]);
            }

            StreamWriter sw = new StreamWriter(@"C:\users\user\desktop\just\папка2\write.txt");
            sw.WriteLine("maximum number is " + maxi + "\n");
            sw.WriteLine("minimum number is " + mini + "\n");
            sw.Close();
            //Console.Write("maximum number is " + maxi + "\n");
            //Console.Write("minimum number is " + mini);
            Console.ReadKey();

        }
    }
}
