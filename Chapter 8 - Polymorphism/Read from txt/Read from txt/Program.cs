using System;

namespace Read_from_txt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1 - reading text
            string text = System.IO.File.ReadAllText(@"C:\Users\Pedro\Documents\musicas.txt");

            Console.WriteLine("Text file contains:\n" + text);

            // Example 2 - reading lines
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Pedro\Documents\musicas.txt");

            Console.WriteLine("Lines contains:");
            foreach(string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            Console.ReadKey();
        }
    }
}
