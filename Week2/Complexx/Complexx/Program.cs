using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexx
{
    class Comlex
    {
        public int p, t;
        public Comlex(int a, int b)   
        {
            p = a;
            t = b;
        }
    }
    class Program
    {

        public static int NOD(int a, int b)
        {
            if (a < b)
            {
                int x;
                x = a;
                a = b;
                b = x;
            }
            int p = a % b;
            if (p == 0)
                return b;
            else
                return NOD(p, b);
        }

        public static int NOM(int v, int g)
        { 
            return (v * g ) / NOD(v, g);
        }

        static void Main(string[] args)
        {
            Comlex q = new Comlex(1, 2);
            Comlex w = new Comlex(5, 7);

            int x = NOM(q.t, w.t);
            int a = x * q.p / q.t;   
            int b = x * w.p / w.t;   
            int c = a + b;                         

            string s = "";
            s = s + c + '/' + NOM(q.t, w.t);

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
