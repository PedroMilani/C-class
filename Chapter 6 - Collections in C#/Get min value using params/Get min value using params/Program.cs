using System;

namespace Get_min_value_using_params
{
    class Program
    {
        static void Main(string[] args)
        {

            int standardMin = Math.Min(1, 2); // this method allows to get the min of only 2 values
            Console.WriteLine(standardMin);

            int min = MinV2(6, 2, 72, 8, 11, -14);
            Console.WriteLine("The minimum is: {0}", min);

            Console.ReadKey();
        }
        public static int MinV2(params int[] numbers) 
        {
            // params is quite useful when we have a method that can take any number of parameters

            int min = int.MaxValue; //the maximum value an integer can hold

            foreach (int number in numbers)
            {
                if (number < min)
                    min = number;
            }
            return min;
        }
    }
}
