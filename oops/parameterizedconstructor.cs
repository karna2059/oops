//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace oops
//{
//    class employee
//    {
//        int Eid;
//        string Ename;
//        double Esalary;

//        public employee()
//        {
//            Eid = 101;
//            Ename = "karna";
//            Esalary = 50000;
//        }

//        public employee(int eid, string ename, double esalary)
//        {
//            Eid = eid;
//            Ename = ename;
//            Esalary = esalary;
//        }

//        public void display()
//        {
//            Console.WriteLine("empid:" + Eid);
//            Console.WriteLine("empname:" + Ename);
//            Console.WriteLine("empsalary:" + Esalary);
//        }
//    }

//    internal class parameterizedconstructor
//    {
//        static void Main(string[] args)
//        {
//            employee emp = new employee();
//            emp.display();
//            employee emp1 = new employee(102, "arjuna", 60000);
//            emp1.display();
//        }
//    }
//}
