using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class myclass
    {
        public void Add()
        {
            int a, b, c;
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("the sum of a+b is:" + c);
        }
        public void Add(int a, int b)
        {
            int c;
            c=a+ b;
            Console.WriteLine("the sum of a+b is:" + c);
        }
        public void Greet(string x)
        {
            Console.WriteLine("heelo!welcome to the methods " +  x);
        }
    }
    internal class methodswithparametersnoreturnvalue
    {
        static void Main(string[] args)
        {
            myclass myclass = new myclass();
            myclass.Add();
            myclass.Add(10,20);
            myclass.Greet("karna");
        }
    }
}
