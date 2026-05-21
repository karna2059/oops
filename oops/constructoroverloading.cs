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
        string college;

        public student()
        {
            id = 1;
            name = "karna";
            college = "Anna university";
        }
        public student(int id, string name, string college)
        {
            this.id = id;
            this.name = name;
            this.college = college;
        }
        public student(int id,string name)
        {
            this.id=id;
            this.name = name;
            college = "not provided"; 
        }
        public void display()
        {
            Console.WriteLine("student id is :" + id);
            Console.WriteLine("student name is :" + name);
            Console.WriteLine("student college name is :" + college);
        }
    }
    internal class constructoroverloading
    {
        static void Main(string[] args)
        {
            student obj= new student();
            obj.display();
            student obj1= new student(2,"charan","jntu");
            obj1.display();
            student obj2 = new student(3, "jagan");
            obj2.display();
            
        }
    }
}
