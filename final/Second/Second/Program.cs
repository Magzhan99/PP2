using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        public static bool Prime(int x)
        {
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x%i == 0)
                {
                    return false;
                }
                
            }
            return true;
        }
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\users\user\desktop\final");
            FileInfo[] file = d.GetFiles();
            int cnt = 0;
            foreach(FileInfo f in file)
            {
                FileStream fs = new FileStream(f.FullName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string n = sr.ReadLine();
                fs.Close();
                sr.Close();
                string[] nums = n.Split(' ');
                for (int j = 0; j < nums.Length; j++)
                {
                    if (Prime(int.Parse(nums[j])))
                    {
                        cnt++;
                    }
                }
                if (cnt >= 1)
                {
                    Console.WriteLine(f.Name);
                    cnt = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
