using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Odd numbers: ");
            foreach(int i in OddNumbers(numbers))
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        static IEnumerable<int> OddNumbers(int[] numbers)
        {

            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

            return oddNumbers;
        }
    }
}
