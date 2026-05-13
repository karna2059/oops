using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class student
    {
        int id;
        string name;
        int age;
        string course;

        public void getdetails()
        {
            Console.WriteLine("student id:");
             id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("student name:");
             name = Console.ReadLine();
            Console.WriteLine("student age:");
             age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("student course:");
             course = Console.ReadLine();
            


        }
        public  void displaydetails()
        {
            Console.WriteLine("student details:");
            Console.WriteLine("student id: " +id );
            Console.WriteLine("student name: " + name);
            Console.WriteLine("student age: " + age);
            Console.WriteLine("student course: " + course);
        }

    }
    internal class studentdetails
    {
        static void Main(string[] args)
        {
            student student = new student();

            student[] students = new student[2];
            for(int i = 0; i < students.Length; i++)
            {
                students[i] = new student();
                students[i].getdetails();
               
            }
          for(int i = 0; i < students.Length; i++)
            {
                students[i].displaydetails();
            }
       

        }


    }
}
