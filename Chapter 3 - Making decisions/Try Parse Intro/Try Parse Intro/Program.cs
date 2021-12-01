using System;

namespace Try_Parse_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = "10";
            int parsedValue;

            bool success = int.TryParse(numberAsString, out parsedValue);

            if(success)
            {
                Console.WriteLine("Parsing success. Number is {0}", parsedValue);
            }
            else
            {
                Console.WriteLine("Parsing failed.");
            }

            Console.ReadKey();
        }
    }
}
