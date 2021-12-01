using System;

namespace Properties_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(3, 4, 5);
            Console.WriteLine("The front surface area is " + box1.FrontSurface);
            Console.ReadKey();
        }
    }
}
