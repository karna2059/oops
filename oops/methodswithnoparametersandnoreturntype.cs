using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class myclass
    {
        public void Greet()
        {
            Console.WriteLine("hello!welcome to the methods");
        }
        public void Add()
        {
            int a, b, c;
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("the sum of a+b is:" + c);
        }
    }
    internal class methodswithnoparametersandnoreturntype
    {
        static void Main(string[] args)
        {
            myclass myclass = new myclass();
            myclass.Greet();
            myclass.Add();
        }

    }
}
