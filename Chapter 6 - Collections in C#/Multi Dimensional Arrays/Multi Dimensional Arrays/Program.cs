using System;

namespace Multi_Dimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare 2D array
            string[,] matrix;
            // matrix = { { 1, 2}, {3, 4} }; cannot initialize that way
            // but we can initialize:
            string[,] matrix2 = { { "1", "2" }, { "3", "4" } };

            // 3D array
            int[,,] tD;

            int[,] array2D = new int[,]
            {
                {1, 2, 3}, // row 1
                {4, 5, 6}, // row 2
                {7, 8, 9}  // row 3
            };

            Console.WriteLine("Central value of array2D is {0}", array2D[1,1]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"020", "021"}
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"120", "121"}
                }
            };
            Console.WriteLine("The value is {0}", array3D[1,2,0]);

            string[,] array2DString = new string[3, 2]
            {
                {"one", "two"},
                {"three", "four"},
                {"five", "six"}
            };

            // change "four":
            array2DString[1, 1] = "not four";
            Console.WriteLine(array2DString[1,1]);

            // Rank returns the amount of dimension
            int dimensions = array2DString.Rank;

            Console.WriteLine("Dimension (rank) of array is {0}", dimensions);

            Console.ReadKey();
        }
    }
}
