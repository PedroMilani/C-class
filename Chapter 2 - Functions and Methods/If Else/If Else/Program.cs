using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the temperature now: ");
            string temperature = Console.ReadLine();
            float temperatureN;
            bool userEnteredANumber = float.TryParse(temperature, out temperatureN);

            if (userEnteredANumber)
            {
                if (temperatureN < 20)
                {
                    Console.WriteLine("Pretty cold.");
                }
                else if (temperatureN == 20)
                {
                    Console.WriteLine("Temperature ok.");
                }
                else
                {
                    Console.WriteLine("Pretty warm.");
                }
            }
            else
            {
                Console.WriteLine("Insert a valid value for temperature.");
            }
            Console.ReadKey();
        }
    }
}
