//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace oops
//{
//    class myclass
//    {
//        int a;
//        int b;

//        public void display()
//        {
//            Console.WriteLine("value of a is :" + a);
//            Console.WriteLine("value of b is :" + b);
//        }
//        public int add()
//        {
//            Console.WriteLine("addition is called");
//            return a + b;
//        }
//        public int sub()
//        {
//            Console.WriteLine("subtraction is called");
//            return a - b;
//        }
//        public int mul()
//        {
//            Console.WriteLine("multiplication is called");
//            return a * b;

//        }
//        public int div()
//        {
//            Console.WriteLine("division is called");
//            return a / b;
//        }
//        public myclass()
//        {
//            a = 10;
//            b = 20;
//            Console.WriteLine("constructor is called");
//        }
//    }
//    internal class constructor
//    {
//        static void Main(string[] args)
//        {
//            myclass obj = new myclass();
//            obj.display();
//            int sum = obj.add();
//            Console.WriteLine("sum is :" + sum);
//            int sub = obj.sub();
//            Console.WriteLine("sub is :" + sub);
//            int mul = obj.mul();
//            Console.WriteLine("mul is :" + mul);
//            int div = obj.div();
//            Console.WriteLine("div is :" + div);
//        }
//    }
//}
