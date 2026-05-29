//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace oops
//{
//    using System;

//    abstract class Person
//    {
//        // Properties
//        public string name { get; set; }
//        public int age { get; set; }

//        // Constructor
//        public Person(string name, int age)
//        {
//            this.name = name;
//            this.age = age;

//            Console.WriteLine("Person Constructor is Called");
//        }

//        // Normal Method
//        public void displayPerson()
//        {
//            Console.WriteLine("Person Name : " + name);
//            Console.WriteLine("Person Age  : " + age);
//        }

//        // Abstract Method
//        public abstract void Role(string sub);
//    }

//    // Student Class
//    class Student : Person
//    {
//        public int RollNo { get; set; }

//        // Constructor
//        public Student(int RollNo)
//            : base("Sai", 25)
//        {
//            this.RollNo = RollNo;
//        }

//        // Override Method
//        public override void Role(string sub)
//        {
//            Console.WriteLine("Student Subject is : " + sub);
//        }
//    }

//    // Teacher Class
//    class Teacher : Person
//    {
//        public string subject { get; set; }

//        // Constructor
//        public Teacher(string subject)
//            : base("Ram", 40)
//        {
//            this.subject = subject;
//        }

//        // Override Method
//        public override void Role(string sub)
//        {
//            Console.WriteLine("Teacher Role is to teach : " + sub);
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Student Object
//            Student s = new Student(101);

//            s.displayPerson();

//            Console.WriteLine("Student RollNo : " + s.RollNo);

//            s.Role(".Net");

//            Console.WriteLine();

//            // Teacher Object
//            Teacher t = new Teacher("C#");

//            t.displayPerson();

//            Console.WriteLine("Teacher Subject : " + t.subject);

//            t.Role("C#");
//        }
//    }
//}
