using System;
using System.IO;

namespace Write_into_txt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 1
            string[] lines = { "First line", "Second line", "Third line" };

            File.WriteAllLines(@"C:\Users\Pedro\Documents\C#TESTS\writetxt.txt", lines);

            // Method 2
            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Pedro\Documents\C#TESTS\" + fileName + ".txt", input);

            // Method 3
            using (StreamWriter file = new StreamWriter(@"C:\Users\Pedro\Documents\C#TESTS\myText.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file2 = new StreamWriter(@"C:\Users\Pedro\Documents\C#TESTS\myText2.txt"))
            {
                file2.WriteLine("Additional line");
            }
        }
    }
}
