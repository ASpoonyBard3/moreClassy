using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreClassy
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.myMethod();

            /*
            myCar.Make = "OldMobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Colour = "Silver";
            

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            Car myOtherCar;
            myOtherCar = myCar;

            myOtherCar.Model = "98";

            myOtherCar = null;

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Colour);

            myOtherCar = null;

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Colour);
                */

            Console.ReadLine();

        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        public Car()
        {   
            // you could load from a configuration file, 
            // a database, etc.
            this.Make = "Nissan";
        }
        
        public Car(string make, string model, int year, string colour)
        {
            Make = make;
            Model = model;
            Year = year;
            Colour = colour;
        }

        public static void myMethod()
        {
            Console.WriteLine("Called the static MyMethod");
            Console.WriteLine(Make);
        }

    }
}
