using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Student
    {
        public string fname;
        public string lname;
        public int age;
        public double GPI;

        public Student()
        {
            fname = "Magzhan";
            lname = "Kadylbekov";
            age = 18;
            GPI = 4;
        }
        public Student(string a, string b, int c, double d)
        {
            fname = a;
            lname = b;
            age = c;
            GPI = d;
        }
        public override string ToString()
        {
            return fname + " " + lname + " " + age + " " + GPI;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.GPI = 6;
            //Console.WriteLine(s1.ToString());
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}









