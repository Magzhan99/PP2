using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] m = s.Split(' ');
            
            bool ok = true;
            int cnt = 0;
            for (int i = 0; i < m.Length; i++)
            {
                string g = m[i];
                int left = 0;
                int right = g.Length - 1;
                while (left <= right)
                {
                    if (g[left] != g[right])
                    {
                        ok = false;
                        break;
                    }
                    left++;
                    right--;
                }
                if (ok)
                {
                    cnt++;
                    ok = true;
                    left = 0;
                    right = m.Length - 1;
                }
                else
                {
                    ok = true;
                    right = m.Length-1;
                    left = 0;
                }
            }
            Console.WriteLine(m.Count());
            Console.WriteLine(cnt);
            Console.ReadKey();
        }
    }
}
