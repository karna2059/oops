using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class myclass
    {
        public int sum()
        {
            int a, b, c;
            a = 10;
            b = 20;
            c = a + b;
            return c;
        }
    }
        

    internal class methodswithnoparameterswithreturnvalue
    {
        static void Main(string[] args)
        {
            myclass myclass = new myclass();
            int result=myclass.sum();
            Console.WriteLine("the sum of a+b is:" + result);

        }
    }
}
