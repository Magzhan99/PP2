using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Complex_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string q = Console.ReadLine();
            int a_ = int.Parse(s.Split('/')[0]);
            int b_ = int.Parse(s.Split('/')[1]);
            int c_ = int.Parse(q.Split('/')[0]);
            int d_ = int.Parse(q.Split('/')[1]);
            Complex a = new Complex(a_, b_);
            Complex b = new Complex(c_, d_);
            Complex res = a + b;
            Console.WriteLine(res.ToString());
            Console.ReadKey();
        }
    }
}
