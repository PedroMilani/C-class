using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(3,4,5);
            //box1.length = 3; 
            Console.WriteLine("The box length is " + box1.GetLength());

            box1.SetLength(6); // set a private variable
            box1.Heigth = 4;
            box1.Width = 5;

            Console.WriteLine("The box length is " + box1.GetLength());

            box1.DisplayInfo();

            Console.ReadKey();
        }
    }
}
