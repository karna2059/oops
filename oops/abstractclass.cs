//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace oops
//{



//    abstract class Person
//    {
//        public string location;

//        public Person(string location)
//        {
//            this.location = location;
//            Console.WriteLine("school location is "+location);
//        }

//        static Person()
//        {
//            Console.WriteLine("School Management Details");
//        }

//          public abstract void schoolmanagement();

//        public void Schoolname()
//        {

//            Console.WriteLine("School Name :st.Joseph");
//        }
//    }

//    class Teacher : Person
//    {
//       public string name {  get; set; }
//      public string subject {  get; set; }

//        public Teacher(string location,string name, string subject) 
//            : base(location)
//        {
//            this.name = name;
//            this.subject = subject;
//        }

//        public override void schoolmanagement()
//        {
//            Console.WriteLine("-----Teacher Deatils -----");
//            Console.WriteLine("Teacher Name : " + name);
//            Console.WriteLine("Subject      : " + subject);
//        }
//    }

//    class Student : Person
//    {
//       public int rollno {  get; set; }
//       public string name {  get; set; }
//        public int age {  get; set; }


//        public Student(string location, int rollno, string name, int age) 
//            : base(location)
//        {
//            this.rollno = rollno;
//            this.name = name;
//            this.age = age;
//        }

//        public override void schoolmanagement()
//        {
//            Console.WriteLine("-----Studnet Details -----");
//            Console.WriteLine("Student Rollno : " + rollno);
//            Console.WriteLine("Student Name   : " + name);
//            Console.WriteLine("Student Age    : " + age);
//        }
//    }

//    class Program
//    {
//        static void Main(string[]args)
//        {
       
//            Student s = new Student("hyderabad",101,"karna",22);

//            Teacher t = new Teacher("chennai","sai kumar", ".Net Fullstack");

//            s.Schoolname();

//            t.schoolmanagement();

//            s.schoolmanagement();

//            s.rollno= 102;

//            s.name = "shiva";

//            s.age = 21;

//            Console.WriteLine("student name is : "+ s.rollno);
//            Console.WriteLine("student name is :" + s.name);
//            Console.WriteLine("student age is  :" + s.age);


//            t.name = "santhosh";

//            t.subject = "java";

//            Console.WriteLine("teacher name is :" + t.name);
//            Console.WriteLine("subject is :" + t.subject);



//        }
//    }
//}





