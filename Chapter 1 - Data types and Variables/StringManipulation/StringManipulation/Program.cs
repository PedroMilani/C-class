using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a few variables
            int age = 99;
            string name = "Jobson";
            string desire = "pizza";

            // 1. String concatenation
            Console.WriteLine("String concatenation");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old.");
            Console.WriteLine();

            // 2. String formatting
            // string formatting uses index
            Console.WriteLine("String formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old and I really want a {2}", name, age, desire);
            Console.WriteLine();

            // 3. String interpolation
            // string interpolation uses $ at the start which
            // will allow us to write our variables like this {variableName}
            Console.WriteLine("String interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old and I really want a {desire}");
            Console.WriteLine();

            // 4. Verbatim strings (verbatim = textualmente / palavra por palavra / literalmente)
            // verbatim strings starts with @ and tells the compiler to take the string
            // literally and ignore any spaces and escapes characters like \n (\n = line break)
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"Longtext long
            long text");

            // instead of using \\ to write file paths we can use verbatim strings to make it easier
            // if you remove the @ you will get an error because \U \A are not valid escape characters
            Console.WriteLine(@"C:\User\Admin");

            // with verbatim strings even valid escape characters won't work
            Console.WriteLine(@"Muahaha \n you have no powers here!");

            Console.ReadKey();
        }
    }
}
