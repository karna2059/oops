using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class car
    {
        string ModelOfCar;  
        string ColorOfCar;
        int yearofManufacture;

        public car(string model, string color, int year)
        {
            ModelOfCar = model;
            ColorOfCar = color;
            yearofManufacture = year;
        }

        public void display()
        {
            Console.WriteLine("model of car: " + ModelOfCar);
            Console.WriteLine("color of car: " + ColorOfCar);
            Console.WriteLine("year of manufacture: " + yearofManufacture);
        }
    }
    internal class cardetails
    {
        static void Main(string[] args)
        {
            car car1 = new car("BMW", "black", 2020);
            car1.display();
             car car2 = new car("Audi", "white", 2019);
            car2.display();
        }
    }
}
