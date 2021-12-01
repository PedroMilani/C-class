using System;

namespace ConsoleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.Write("Enter a string and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.Write("Enter a key and press enter: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII Value is {0}", asciiValue);

            Console.Beep(9000, 2000);
            Console.SetCursorPosition(0, 0);
            Console.ReadKey();

            
        }
    }
}

