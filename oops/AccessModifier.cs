using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class ac
    {
        public string a = "karna";

        public void name()
        {
            Console.WriteLine("the value of firstclass a is :"+a);
        }

     
        
    }
    class ac1
    {
        public void name1()
        {
            ac obj = new ac();
            Console.WriteLine("the value of second class a is :" + obj.a);
        }

    }
    internal class AccessModifier
    {
        static void Main(string[] args)
        {
            ac obj= new ac();
            obj.name();
           
            Console.WriteLine("the value of second class a is :"+obj.a);
            ac1 obj1= new ac1();
            obj1.name1();
            
        }
    }
}
