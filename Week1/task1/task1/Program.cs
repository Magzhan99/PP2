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
        public float GPA;

        public Student()
        {
            fname = "magzhan";
            lname = "kadylbekov";
            age = 18;
            GPA = 3; 
        }

        public Student(string fname, string surname,int age, float gpa)
        {
            this.fname = fname;
            lname = surname;
            this.age = age;
            GPA = gpa;
        }

        public override string ToString()
        {
            return fname + " " + lname + " " + age + " " + GPA;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.GPA = 4;


            Student s2 = new Student("KBTU", "FIT", 19, 3.5);
            Console.WriteLine(s);      //magzhan kadylbekov 18 4 
            Console.WriteLine(s2);     //magzhan kadylbekov 18 3
            
            Console.ReadKey();
        }
    }
}









