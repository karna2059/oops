using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    abstract class vehicle
    {
        protected string vehiclename;

        public vehicle(string vehiclename)
        {
            this.vehiclename = vehiclename;
            Console.WriteLine("vehicle is called");
        }
        public void display()
        {
            Console.WriteLine($"vehicle :{vehiclename}");
        }
        public abstract void vehicletype();
    }

    abstract class vehiclemodel : vehicle
    {
        protected int year;
        public vehiclemodel(string vehiclename ,int year) : base(vehiclename)
        {
            this.year = year;
            Console.WriteLine("vehicle model is called");
        }
        public void displayinfo()
        {
            Console.WriteLine($"vehicle year :{year}");
        }
        public abstract void modeltype();
    }

    class vehicledata : vehiclemodel
    {

        protected string colour;
        public vehicledata(string colour, string vehiclename,int year) : base(vehiclename, year)
        {
           this.colour = colour;
            Console.WriteLine("vehicledata is called");
        }
        public void disp()
        {
            Console.WriteLine("car colour is :" + colour);
        }
        public override void vehicletype()
        {
            Console.WriteLine("car");
        }
        public override void modeltype()
        {
            Console.WriteLine("electric");
        }




    }

    internal class abstractsingleinheritence
    {
        static void Main()
        {
            vehicledata v = new vehicledata("Black","Tesla", 2025);

            v.display();
            v.displayinfo();
            v.disp();
            v.vehicletype();
            v.modeltype();
        }
    }
}
