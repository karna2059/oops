using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{



    abstract class Person
    {

        static Person()
        {
            Console.WriteLine("School Management Details");
        }

        public abstract void schoolmanagement();

        public void Schoolname()
        {

            Console.WriteLine("School Name :st.Joseph");
        }
    }

    class Teacher : Person
    {
        string name;
        string subject;

        public Teacher(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public override void schoolmanagement()
        {
            Console.WriteLine("-----Teacher Deatils -----");
            Console.WriteLine("Teacher Name : " + name);
            Console.WriteLine("Subject      : " + subject);
        }
    }

    class Student : Person
    {
        int rollno;
        string name;
        int age;


        public Student(int rollno, string name, int age)
        {
            this.rollno = rollno;
            this.name = name;
            this.age = age;
        }

        public override void schoolmanagement()
        {
            Console.WriteLine("-----Studnet Details -----");
            Console.WriteLine("Student Rollno : " + rollno);
            Console.WriteLine("Student Name   : " + name);
            Console.WriteLine("Student Age    : " + age);
        }
    }

    class Program
    {
        static void Main(string[]args)
        {
       
            Student s = new Student(101, "karna", 22);

            Teacher t = new Teacher("sai kumar", ".Net Fullstack");

            s.Schoolname();

            t.schoolmanagement();

            s.schoolmanagement();
        }
    }
}
