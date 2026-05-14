using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class emp
    {
        int empid;
        string empname;
        int empsalary;
        public emp()
        {
            empid = 101;
            empname = "karna";
            empsalary = 50000;
        }

       
        public void display()
        {
            Console.WriteLine("empid:" + empid);
            Console.WriteLine("empname:" + empname);
            Console.WriteLine("empsalary:" + empsalary);
            Console.WriteLine("salary hike is :"+ (empsalary * 0.1));
        }

        public int totalSalary()
        {
            return empsalary + (int)(empsalary * 0.1);
        }



        public static void displaycompany()
        {
            Console.WriteLine("company name is: wipro");
        }

    }
    internal class empdetails
    {
        static void Main(string[] args)
        {
            emp emps=new emp();
          
            emps.display();
           
            emps.totalSalary();
            Console.WriteLine("total salary is:" + emps.totalSalary());
            emp.displaycompany();
        }
    }
}
