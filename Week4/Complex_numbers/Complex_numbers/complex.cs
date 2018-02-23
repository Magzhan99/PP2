using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_numbers
{
    [Serializable]
    public class Complex
    {
        int p, t;
        
        public Complex()
        {

        }
        public Complex(int a, int b)
        {
            p = a;
            t = b;
        }

        public static int GCD(int a, int b)
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
                return GCD(p, b);
        }
        public static Complex operator +(Complex x, Complex y)
        {
            int b =  x.t * y.t / GCD(x.t, y.t);
            int a = b / x.t * x.p + b / y.t * y.p;
            Complex c = new Complex(a, b);
           
            return c;
        }

        public override string ToString()
        {
            if (t == 1)
                return p + "";
            else
                return p + "/" + t;
        }
    }
}
