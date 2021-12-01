using System;

namespace Switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your age: ");
            string age = Console.ReadLine();
            int ageInt;
            int.TryParse(age, out ageInt);

            switch (ageInt)
            {
                case 18: // similar to "if"
                    Console.WriteLine("Legal age");
                    break;
                case 17:
                    Console.WriteLine("Under age");
                    break;
                default: // similar to "else"
                    Console.WriteLine("How old are you then?");
                    break;
            }
            Console.ReadKey();
        }
    }
}
