using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 7;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3); // - before a number multiplies it by -1
            bool isSunny = false;
            Console.WriteLine("It is sunny: {0}", !isSunny); // ! before a bool makes it opposite

            int num = 0;
            // increment operator
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++); // ++ after the value adds 1 after the line
            Console.WriteLine("num is {0}", ++num); // ++ before the value adds 1 before the line (pre increment)

            // decrement operator
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--); 
            Console.WriteLine("num is {0}", --num);

            int result;

            result = num1 + num2;
            Console.WriteLine("Result of num1 + num2: {0}", result); // addition
            result = num1 - num2;
            Console.WriteLine("Result of num1 - num2: {0}", result); // subtraction
            result = num1 / num2;
            Console.WriteLine("Result of num1 / num2: {0}", result); // division
            result = num1 * num2;
            Console.WriteLine("Result of num1 * num2: {0}", result); // multiplication
            result = num1 % num2;
            Console.WriteLine("Result of num1 % num2: {0}", result); // it is the remainder of the division (resto)

            // relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("Result of num1 < num2: {0}", isLower);

            // equality operator (there is a method behind == and != which returns a bool)
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("Result of num1 == num2: {0}", isEqual);
            isEqual = num1 != num2;
            Console.WriteLine("Result of num1 != num2: {0}", isEqual);

            // conditional operators
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny; // AND - if both conditions are true the result is true, if no it is false
            Console.WriteLine("Result of isLower && isSunny: {0}", isLowerAndSunny);
            isLowerAndSunny = isLower || isSunny; // OR - if at least one condition is true the result is true
            Console.WriteLine("Result of isLower || isSunny: {0}", isLowerAndSunny);

            Console.ReadKey();
        }
    }
}
