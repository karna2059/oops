using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class studentmarks
    {
        static void Main(string[] args)
        {
            int[] marks=new int[2];
            string[] name=new string[2];
            int[] age=new int[2];

            for(int i=0;i<2;i++)
            {
                Console.WriteLine("enter marks");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter name");
                name[i] = Console.ReadLine();
                Console.WriteLine("enter age");
                age[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("enter student name to search");
            string search = Console.ReadLine();
            for(int j=0;j<2;j++)
            {
                if (name[j] == search)
                {
                    Console.WriteLine("student name is :"+name[j]);
                    Console.WriteLine("student marks is :"+marks[j]);
                    Console.WriteLine("student age is :"+ age[j]);
                }
            }
        }
    }
}
