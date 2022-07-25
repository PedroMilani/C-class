using System;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? n1 = null;
            int? n2 = 123;

            double? n3 = new Double?();
            double? n4 = 3.14;

            bool? b1 = new bool?();

            Console.WriteLine("Our nullable numbers are: {0}, {1}, {2}, {3}", n1, n2, n3, n4);
            Console.WriteLine("The nullable boolean value is: {0}", b1);

            double? n5 = 16.1;
            double? n6 = null;
            double n7;

            if (n5 == null)
            {
                n7 = 0.0;
            }
            else
            {
                n7 = (double)n5;
            }

            Console.WriteLine("Value of n7 is {0}", n7);


            // Shorter: THE NULL COALESCING OPERATOR ??
            n7 = n5 ?? 5.32;
            Console.WriteLine("Value of n7 is {0}", n7);
            n7 = n6 ?? 5.32; // if n6 have no value, assign 5.32 to n7, if it does, assign n6 value to n7
            Console.WriteLine("Value of n7 is {0}", n7);


        }
    }
}
