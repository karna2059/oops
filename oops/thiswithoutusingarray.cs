//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



//    namespace oops
//    {
//        class student
//        {
//            int id;
//            string name;
//            string email;

//            public student(int id, string name, string email)
//            {
//                this.id = id;
//                this.name = name;
//                this.email = email;
//            }

//            public void display()
//            {
//                Console.WriteLine("Student id is : " + id);
//                Console.WriteLine("Student name is : " + name);
//                Console.WriteLine("Student email is : " + email);
//                Console.WriteLine("---------------------------");
//            }
//        }

//        internal class thisexample
//        {
//            static void Main(string[] args)
//            {
//                Console.WriteLine("Enter how many students:");
//                int n = Convert.ToInt32(Console.ReadLine());

//                for (int i = 1; i <= n; i++)
//                {
//                    Console.WriteLine("Enter details for student " + i);

//                    Console.WriteLine("Please enter student id:");
//                    int id = Convert.ToInt32(Console.ReadLine());

//                    Console.WriteLine("Please enter student name:");
//                    string name = Console.ReadLine();

//                    Console.WriteLine("Please enter student email:");
//                    string email = Console.ReadLine();

//                    // object creation
//                    student obj = new student(id, name, email);

//                    // display method
//                    obj.display();
//                }
//            }
//        }
//    }
   

