using System;

namespace Method_With_Return
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Add(15,31));
            Console.WriteLine(Multiply(3, 7));
            Console.WriteLine(Divide(31, 23));
            Greeting("Pedro");
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static void Greeting(string name) // no return here
        {
            Console.WriteLine("Hello {0}, my friend!", name);
        }
    }
}
