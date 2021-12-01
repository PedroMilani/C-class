using System;

namespace Conversation
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            int num = 23523412;
            long bigNum = num;
            float myFloat = 13.61f;
            double myNewDouble = myFloat;

            double myDouble = 13.61;
            int myInt;
            // explicit conversion
            // cast double to int
            myInt = (int)myDouble;

            // type conversion
            string myString = myDouble.ToString(); // "13.61"
            string myStringFloat = myFloat.ToString();
            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myStringFloat);


            //Parsing string to integer
            string stringNum1 = "15";
            string stringNum2 = "12";
            int num1 = Int32.Parse(stringNum1);
            int num2 = Int32.Parse(stringNum2);
            int result = num1 + num2;

            Console.WriteLine(result);
        
            Console.Read();

        }
    }
}
