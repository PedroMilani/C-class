using System;

namespace MainArgs_CMD_App
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Please provide args. Pass help to get more details.");
                // pause
                Console.ReadKey();
                // quit the app
                return;
            }

            if (args[0].ToLower() == "help")   // Check f the first argument is help. To be sure we convert it to lower case
            {
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Use one of the commands below followed by two numbers");
                Console.WriteLine("add - to add two numbers");
                Console.WriteLine("sub - to sub two numbers");
                Console.WriteLine("*****************************************************");
                // pause
                Console.ReadKey();
                // quit the app
                return;
            }

            if (args.Length != 3)   // If the user did not input 3 arguments
            {
                Console.WriteLine("ERROR: Invalid number of arguments. Please use HELP function for instructions.");
                // pause
                Console.ReadKey();
                // quit the app
                return;
            }

            bool isNum1Parsed = float.TryParse(args[1], out float num1);
            bool isNum2Parsed = float.TryParse(args[2], out float num2);

            if (!isNum1Parsed || !isNum2Parsed) // Check if we could convert the numbers entered by the user
            {                                   // If we dont do this check, any failed conversion will be 0
                Console.WriteLine("ERROR: Failed to read the numbers you entered.");
                return;
            }

            float result;               // Store the result
            switch (args[0].ToLower())   // Convert the first argument to lower case and see if it is add or sub
            {
                case "add":
                    result = num1 + num2;
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
                    break;
                case "sub":
                    result = num1 - num2;
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid command");
                    break;
            }

            Console.ReadKey();
        }
    }
}
