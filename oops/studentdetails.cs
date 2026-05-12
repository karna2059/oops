using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{ 
    class student
    {
       
        public static void display()
        {
            Console.WriteLine("student id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("student name:");
            string name = Console.ReadLine();
            Console.WriteLine("student age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("student course:");
            string course = Console.ReadLine();
            
           
        }
    }
    internal class studentdetails
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine("Enter Details for Student " + i);
                student.display();

            }
        }
    }
}
