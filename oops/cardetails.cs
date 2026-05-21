//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace oops
//{
//    using System;

//    namespace oops
//    {
//        class car
//        {
//            string ModelOfCar;
//            string ColorOfCar;
//            int yearofManufacture;

//            public car(string model, string color, int year)
//            {
//                ModelOfCar = model;
//                ColorOfCar = color;
//                yearofManufacture = year;
//            }
//            public void display()
//            {
//                Console.WriteLine("Model of car: " + ModelOfCar);
//                Console.WriteLine("Color of car: " + ColorOfCar);

//                if (yearofManufacture < 1886)
//                {

//                    Console.WriteLine("Invalid year of manufacture");

//                }
//                else
//                {
//                    Console.WriteLine("Year of manufacture: " + yearofManufacture);

//                }


//            }
//        }

//        internal class cardetails
//        {
//            static void Main(string[] args)
//            {
//                car car1 = new car("BMW", "Black", 2020);
//                car1.display();

//                car car2 = new car("Audi", "White", 1884);
//                car2.display();

            
//            }
//        }
//    }
//}
