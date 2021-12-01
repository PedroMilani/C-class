using System;

namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {

            Add();
            Console.ReadKey();
        }

        public static void Add()
        {
            Console.Write("Input number 1 to add: ");
            string stringNum1 = Console.ReadLine();  // Read the input value and assign to the variable
            Console.Write("Input number 2 to add: ");
            string stringNum2 = Console.ReadLine();

            int num1 = int.Parse(stringNum1); // Convert string to int
            int num2 = int.Parse(stringNum2);

            int result = num1 + num2;
            Console.WriteLine("The result is: " + result);
        }
      
    }
}
