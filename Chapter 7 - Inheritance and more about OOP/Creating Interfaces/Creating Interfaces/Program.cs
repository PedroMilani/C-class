using System;

namespace Creating_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Chair officeChair = new Chair("Brown", "Wood");
            Chair gamingChair = new Chair("Red", "Leather");

            Car damagedCar = new Car(80f, "Blue");

            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();

            Console.ReadKey();
        }
    }
}
