using System;

namespace Declaring_and_Initializing_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 18;
            grades[2] = 14;
            grades[3] = 12;
            grades[4] = 7;

            Console.WriteLine("grade in the index 0: {0}", grades[0]);

            string input = Console.ReadLine();
            // assign value to array grades at index 0
            grades[0] = int.Parse(input);
            Console.WriteLine("grade in the index 0: {0}", grades[0]);

            // another way of initializing an array
            int[] gradesMathA = { 9, 8, 7, 7, 6 };
            // third way of initializing an array
            int[] gradesMathB = new int[] { 9, 9, 8, 7, 7 };

            Console.WriteLine("Length of gradesMathA: " + gradesMathA.Length);

            Console.ReadKey();
        }
    }
}
