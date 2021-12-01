using System;

namespace Break_and_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i < 20; i++)
            {
                if(i %2 == 0)
                {
                    Console.WriteLine("Only odd numbers allowed.");
                    continue;
                }
                Console.WriteLine(i);
                if (i == 9)
                {
                    Console.WriteLine("Although the loop goes to 20, in 9 I want it to finish.");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
