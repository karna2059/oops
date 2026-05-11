//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace oops
//{
//    class counter
//    {
//        private int instanceCount = 0;
//        private int staticCount = 0;

//        public void increment()
//        {
//            instanceCount++;
//            staticCount++;

//            Console.WriteLine ("instance count: " + instanceCount);
//            Console.WriteLine ("static count: " + staticCount);
//        }
//    }
   
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            counter c1 = new counter();
//            counter c2 = new counter();

//            c1.increment();
//            c1.increment();
//            c2.increment();
//            c2.increment(); 
//        }
//    }
//}
