using System;

namespace Random_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int numEyes;

            for (int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);
            }



            Console.WriteLine("Enter your question:");
            Console.ReadLine();

            Random one2or3 = new Random();
            int randomNum;

            randomNum = one2or3.Next(1, 4);
            if (randomNum == 1)
            {
                Console.WriteLine("Yes");
            }
            else if (randomNum == 2)
            {
                Console.WriteLine("Maybe");
            }
            else if (randomNum == 3)
            {
                Console.WriteLine("No");
            }

            Console.ReadKey(); 
        }
    }
}
