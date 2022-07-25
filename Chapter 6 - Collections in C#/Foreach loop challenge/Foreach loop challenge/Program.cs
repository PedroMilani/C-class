using System;

namespace Foreach_loop_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input any value: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Input the data type of the previous input.\nType 1 for string (numbers not allowed).\nType 2 for integer.\nType 3 for boolean.");
            string input2 = Console.ReadLine();
            int input2n = int.Parse(input2);

            bool tryString = true;
            int tryInt;
            bool tryBool;

            Console.WriteLine("You have entered {0}", input1);

            switch (input2n)
            {
                case 1:
                    foreach(char c in input1)
                    {
                        if (!Char.IsLetter(c))
                            tryString = false;
                    }

                    if (string.IsNullOrEmpty(input1))
                        tryString = false;

                    if (tryString == true)
                        Console.WriteLine("It is a valid String.");
                    else
                        Console.WriteLine("It is an invalid String.");
                    break;

                case 2:
                    bool try2 = int.TryParse(input1, out tryInt);
                    if (try2 == true)
                        Console.WriteLine("It is a valid Integer.");
                    else
                        Console.WriteLine("It is an invalid Integer.");
                    break;
                
                case 3:
                    bool try3 = bool.TryParse(input1, out tryBool);
                    if (try3 == true)
                        Console.WriteLine("It is a valid Boolean.");
                    else
                        Console.WriteLine("It is an invalid Boolean.");
                    break;
            }

            Console.ReadKey();

        }
    }
}
