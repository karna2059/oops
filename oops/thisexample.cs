using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class student
    {
        int id;
        string name;
        string email;

        public student(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }

        public  void display()
        {
            Console.WriteLine("student id is :" + id);
            Console.WriteLine("student name is :" + name);
            Console.WriteLine("student email is :" + email);
        }
    }
    internal class thisexample
    {
        static void Main(string[] args)
        {
            student obj=new student(1,"karna","abc@gamil.com");
            obj.display();
        }
    }
}
