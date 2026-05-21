//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace oops
//{
//    class overloding1
//    {

//        int id;
//        string name;
//        string company;

//        public overloding1()
//        {
//            id = 1;
//            name = "karna";
//            company = "microsoft";
//        }
//        public overloding1(int id, string name, string company)
//        {
//            this.id = id;
//            this.name = name;
//            this.company = company;
//        }
//        public overloding1(int id)
//        {
//            this.id = id;
            
//        }
//        public overloding1( string name)
//        {
//            this.name = name;
//        }
//        public void display()
//        {
//            Console.WriteLine("emp id is :" + id);
//            Console.WriteLine("emp name is :" + name);
//            Console.WriteLine("company :" + company);
//        }
//    }

    

//    internal class overloding
//    {
//        static void Main(string[] args)
//        {
//            overloding1 obj=new overloding1();
//            obj.display();
//            overloding1 obj2 = new overloding1(2);
//            obj2.display();
//            overloding1 obj3 = new overloding1("charan");
//            obj3.display();
//            overloding1 obj1=new overloding1(3,"sai","wipro");
//            obj1.display();
           
//        }
       
//    }
//}
