using System;

namespace Foreach_loop_and_switch_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean valid = false;
            string inputValueType = string.Empty;

            Console.WriteLine("Enter a value: ");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the data type to validate the input you have entered");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");

            Console.WriteLine("Enter: ");
            string inputTypeS = Console.ReadLine();
            int inputType;
            bool validInputType = int.TryParse(inputTypeS, out inputType);

            static bool IsAllAlphabetic(string value)
            {
                foreach (char c in value)
                {
                    if (!Char.IsLetter(c))
                        return false;
                }
                return true;
            }

            switch (inputType)
            {
                case 1:
                    // check for string
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;

                case 2:
                    // check for integer
                    int retValue = 0;
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Integer";
                    break;

                case 3:
                    // check for boolean
                    bool retFlag = false;
                    valid = bool.TryParse(inputValue, out retFlag);
                    inputValueType = "Boolean";
                    break;

                default:
                    Console.WriteLine("Not able to detect the input type, something is wrong.");
                    break;
            }

            Console.WriteLine("You have entered {0}", inputValue);
            if(valid)
                Console.WriteLine("It is a valid {0}.", inputValueType);
            else
                Console.WriteLine("It is an invalid {0}.", inputValueType);

            Console.ReadKey();
        }
    }
}
