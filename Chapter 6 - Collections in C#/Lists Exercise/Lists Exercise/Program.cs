using System;
using System.Collections.Generic;

namespace Lists_Exercise
{
    class Program
    {

        // Write a method that returns a list of even integer numbers between 100 and 170 (inclusive)

        static void Main(string[] args)
        {

            Solution();
            Console.ReadKey();
        }

        public static List<int> Solution()
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 100; i <= 170; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                }
            }
            foreach (int element in evenNumbers)
            {
                Console.Write(element + " ");
            }
            return evenNumbers;
        }
    }
}

