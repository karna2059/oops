//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace oops
//{
//    class employee
//    {
//        int id;
//        string name;
//        int age;
//        static string companyname="wipro";
        

//        public void getdetails()
//        {
//            Console.WriteLine("enter empid ");
//            id=Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter empname");
//            name=Console.ReadLine();
//            Console.WriteLine("enter age");
//            age = Convert.ToInt32(Console.ReadLine());
//        }

//        public static void dispaly1()
//        {
//            Console.WriteLine("company name is: " + companyname);
//        }

//        public void dispaly2()
//        {
//            Console.WriteLine("employee id :" + id);
//            Console.WriteLine("employee name :" + name);
//            Console.WriteLine("employee age :" + age);
//        }

//    }

//    internal class employeedetails
//    {
//        static void Main(string[] args)
//        {
//            employee details = new employee();
//            employee.dispaly1();

//            employee[] detail = new employee[5];
//            for(int i = 0; i < detail.Length; i++)
//            {
//                detail[i]=new employee();
//                detail[i].getdetails();
//            }

//            for(int i=0; i < detail.Length; i++)
//            {
//                detail[i].dispaly2();
//            }
//        }
//    }
//}
