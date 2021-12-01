using System;

namespace Nested_For_and_2D_Array
{
    class Program
    {
        static int[,] matrix =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        static void Main(string[] args)
        {
            foreach(int item in matrix)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nThis is our 2D array printed using nested for loop:");
            // outer for loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // print diagonal
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i==j)
                        Console.Write(matrix[i, j] + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // or
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i,i]);
            }
            Console.WriteLine();

            // the opposite diagonal
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix[i,j]);
            }
            Console.WriteLine();
            
            // print even numbers only
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                        Console.Write(matrix[i, j] + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // print odd numbers only
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 1)
                        Console.Write(matrix[i, j] + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
