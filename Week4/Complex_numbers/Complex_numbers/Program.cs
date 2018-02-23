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
    [Serializable]
    class Program
    {
        static void F1(Complex w)
        {
            BinaryFormatter bn = new BinaryFormatter(); 
            FileStream fs = new FileStream("data.txt", FileMode.Create, FileAccess.Write);
            bn.Serialize(fs, w);
            fs.Close();
        }

        static void F2()
        {
            BinaryFormatter bn = new BinaryFormatter();
            FileStream fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            Complex res = bn.Deserialize(fs) as Complex;
            fs.Close();
            Console.WriteLine("vot tebe : " + res);
        }

        static void F3(Complex w)
        {
            XmlSerializer xx = new XmlSerializer(typeof(Complex));
            FileStream ff = new FileStream("maga.xml", FileMode.Create, FileAccess.Write);
            xx.Serialize(ff, w);
            ff.Close();
        }
        static void F4()
        {
            XmlSerializer xx = new XmlSerializer(typeof(Complex));
            FileStream ff = new FileStream("maga.xml", FileMode.Open, FileAccess.Read);
            Complex total = xx.Deserialize(ff) as Complex;
            ff.Close();
            Console.WriteLine("vot vam:" + total);
        }

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
            F1(res);
            F2();
            //F3(res);
            //F4();
            //Console.WriteLine(res.ToString());
            Console.ReadKey();
        }
    }
}
