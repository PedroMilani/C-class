using System;

namespace Constants
{
    class Program
    {
        //constants as fields
        const double pi = 3.14159265358979323846;
        const int weeks = 52, months = 12;
        const string myBirthday = "01.07.1993";


        static void Main(string[] args)
        {
            Console.WriteLine("My birthday will always going to be {0}", myBirthday);
            Console.ReadKey();

        }
    }
}
