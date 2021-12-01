using System;

namespace Challenge_ternary_operator__enhanced_if_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the temperature: ");
            string temperature = Console.ReadLine();
            int tInt;
            bool tryInt = int.TryParse(temperature, out tInt);

            if (tryInt)
            {
                // condition ? ifTrue : ifFalse
                string msg = tInt <= 15 ? "It's too cold." : (tInt <= 28 && tInt > 15) ? "It's ok." : tInt > 28 ? "It's too hot." : "";
                Console.WriteLine(msg);
            }
            else
            Console.WriteLine("Input value incorrect.");

            Console.ReadKey();
        }
    }
}
