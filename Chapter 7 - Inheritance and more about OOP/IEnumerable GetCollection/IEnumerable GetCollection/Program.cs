using System;
using System.Collections.Generic;

namespace IEnumerable_GetCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------- EXAMPLE 1 -----------------------

            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);
            Console.WriteLine("This was a List<int>");
            foreach(int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }

            unknownCollection = GetCollection(2);
            Console.WriteLine("\nThis was a Queue<int>");
            foreach(int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }

            unknownCollection = GetCollection(3);
            Console.WriteLine("\nThis was an Array of int[]");
            foreach(int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }

            // ----------------------- EXAMPLE 2 -----------------------

            List<int> numberList = new List<int>() { 8, 6, 2 };

            int[] numberArray = new int[] { 1, 7, 1, 3 };

            Console.WriteLine(" ");

            CollectionSum(numberList);
            CollectionSum(numberArray);

            Console.ReadKey();
        }

        static IEnumerable<int> GetCollection(int option) // FOR EXAMPLE 1
        {
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if (option == 1)
            {
                return numbersList;
            }
            else if (option == 2)
            {
                return numbersQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }

        }

        static void CollectionSum(IEnumerable<int> anyCollection) // FOR EXAMPLE 2
        {
            int sum = 0;

            foreach (int num in anyCollection)
            {
                sum += num;
            }

            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
