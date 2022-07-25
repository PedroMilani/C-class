using System;
using System.Collections.Generic;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Pedro" };

            Console.WriteLine("------before------");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("------after------");
            names.RemoveAll(Filter);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }

        // a method that takes a string and returns boolean value
        static bool Filter(string s)
        {
            return s.Contains("i"); // the contains method returns a bool that tells if the string s contains the letter 'i'
        }
    }
}
