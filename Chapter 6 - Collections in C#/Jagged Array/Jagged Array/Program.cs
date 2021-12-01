using System;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare jagged array
            int[][] jaggedArray = new int[3][]; // so there is 3 arrays within the jaggedArray

            jaggedArray[0] = new int[4];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[] { 5, 6, 7 };
            jaggedArray[2] = new int[] { 8, 9 };

            // alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[]{1,2,3,4,5},
                new int[]{7,9,11}
            };

            Console.WriteLine("The value in the middle of the first entry is {0}",jaggedArray2[0][2]);

            Console.WriteLine("Length of Jagged Array is " + jaggedArray2.Length);

            // get all values
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("jaggedArray[i].Length = " + jaggedArray2[i].Length);

                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("jaggedArray[{0}][{1}] = {2} ", i, j, jaggedArray2[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}
