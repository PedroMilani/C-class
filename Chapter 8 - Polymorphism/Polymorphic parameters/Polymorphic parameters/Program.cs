using System;
using System.Collections.Generic;

namespace Polymorphic_parameters
{
    class Program
    {
        static void Main(string[] args)
        {

            var cars = new List<Car>
            {
                new AUDI("blue", 200, "A4"),
                new BMW("White", 230, "M3"),
            };

            foreach(var car in cars)
            {
                car.Repair();
            }

            // Because it is a new Method() it uses the base method. The class should be BMW:
            // BMW b = new BMW("White", 10, "Bee");
            Car b = new BMW("White", 10, "Bee");
            b.ShowDetails();

            // The override method works
            Car c = new AUDI("Black", 10, "Aii");
            c.ShowDetails();

            BMW bmwZ3 = new BMW("White", 250, "Z3");

            bmwZ3.SetCarIDInfo(123, "Owner");
            bmwZ3.GetCarIDInfo();

            Console.ReadKey();

        }
    }
}
