using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Program
    {
        class Student
        {
            private string fname;
            private string lname;
            private double gpa;

            public Student() { }

            public Student(string fname, string lname, double gpa)
            {
                this.fname = fname;
                this.lname = lname;
                this.gpa = gpa;
            }

            public override string ToString()
            {
                return fname + " " + lname + " " + gpa;
            }

        }
        static void Main(string[] args)
        {
            Student s = new Student("Togzhan", "Abish", 3.8);
            Console.Write(s.ToString());

            Console.ReadKey();
        }
    }
}
