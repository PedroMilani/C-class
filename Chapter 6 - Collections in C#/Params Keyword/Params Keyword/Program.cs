using System;

namespace Params_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {

            int price = 10;
            float pi = 3.14f;
            char ch = '%';
            string book = "Dracula";

            ParamsMethod2(price, pi, ch, book);
            ParamsMethod2(10, "Another book", '$'); // use the variables or values directly
            ParamsMethod("We", "can", "print", "something");

            Console.ReadKey();
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            // for each loop to go through the array of objects
            foreach(object obj in stuff)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

    }
}
