using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    abstract class person
    {
        protected string name;
        private int age;

        public person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("person constructor called");
        }
        public void display()
        {
            Console.WriteLine("student name :"+name);
            Console.WriteLine("student age is :" + age);
        }
        public abstract void role();
       
    }

    class student : person
    {
        public int rollno;

        public student(string name,int age, int rollno) : base(name,age)
        {
            this.rollno = rollno;
        }
        public override void role()
        {
            Console.WriteLine("roll no is :" + rollno);
            Console.WriteLine("I am a student ");
        }
    }

    class teacher : person
    {
        public teacher(string name, int age ) : base(name, age)
        {

        }
        public override void role()
        {
            Console.WriteLine("I am a teacher");
        }
    }
    internal class abstractclass1
    {
        static void Main(string[] args)
        {
            person s = new student("karna",22,101);
            s.display();
            s.role();
            person t = new teacher("sai kumar", 40);
            t.display();
            t.role();
            
        }
    }
}
