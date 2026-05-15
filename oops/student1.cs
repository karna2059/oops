//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace oops
//{
//    class student1
//    {
//        int Sid;
//        string Sname;
//        string Sbranch;

//        public student1()
//        {
//            Sid = 101;
//            Sname = "karna";
//            Sbranch = "cse";
//        }

//        public student1(int sid, string sname, string sbranch)
//        {
//            Sid = sid;
//            Sname = sname;
//            Sbranch = sbranch;
//        }

//        public void display()
//        {
//            Console.WriteLine("student id: " + Sid);
//            Console.WriteLine("student name: " + Sname);
//            Console.WriteLine("student branch: " + Sbranch);
//        }
//    }

//    internal class program
//    {
//        static void Main(string[] args)
//        {
//            student1 student = new student1();
//            student.display();

//            student1 student1 = new student1(102, "arjun", "ece");
//            student1.display();
//        }
//    }
//}
