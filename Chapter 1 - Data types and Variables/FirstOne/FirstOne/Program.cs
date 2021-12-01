using System;

namespace FirstOne
{
    class Program
    {
        // Entry point of our program
        static void Main(string[] args) // Metodo
        {
            //Console.WriteLine("Hello World!");

            //Declaring
            int n1;

            //Assigning a value
            n1 = 10;

            //Declaring and initializing a variable in one go
            int n2 = 14;
            int sum = n1 + n2;

            //Declaring multiple variables ate once
            int n3, n4, n5;

            Console.WriteLine(sum);

            //using concatination
            Console.WriteLine("n1: " + n1 + " + n2: " + n2 + " is "+ sum);

            double d1 = 2.2;
            double d2 = 3.34;
            double Divided = d1 / d2;
            Console.WriteLine("d1/d2 is " + Divided);

            float f1 = 2.2f;
            float f2 = 3.34f;
            float fD = f1 / f2;
            Console.WriteLine("f1/f2 is " + fD);

            string myname = "Pedro";
            string message = "My name is " + myname;
            string capsMessage = message.ToUpper();
            string lowerMessage = message.ToLower();
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerMessage);


            Console.Read();

        }
    }
}
