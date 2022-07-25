using System;

namespace Foreach_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for(int i = 0; i < 10; i++)
            {
                nums[i] = i + 1;
            }

            //for(int j = 0; j < 10; j++) // it is dangerous because we may have an exception when j is not in the array range, so:
            for(int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element {0} = {1}", j, nums[j]);
            }

            int counter = 0;
            foreach(int k in nums) // in most cases for loop is faster than foreach loop
            {
                Console.WriteLine("Element {0} = {1}", counter, k);
                counter++;
            }

            // foreach loop to greet all names of a array

            string[] names = { "Ab", "Bc", "Cd", "De", "Ef" };

            foreach(string name in names)
            {
                Console.WriteLine("Hello there {0}!", name);
            }

            Console.ReadKey();
        }
    }
}
