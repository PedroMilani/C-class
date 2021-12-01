using System;


namespace ChallengeStringAndItsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;

            Console.Write("Please enter your name and press enter: ");
            myName = Console.ReadLine();
            /*Console.WriteLine(myName);
            Console.WriteLine(myName.ToUpper());
            Console.WriteLine(myName.ToLower());
            Console.WriteLine(string.IsNullOrWhiteSpace(myName));
            Console.WriteLine(myName.Substring(2));
            Console.ReadKey();*/

            // Solution

            string myNameUpperCase = String.Format("Upper case: {0}", myName.ToUpper());
            string myNameLowerCase = String.Format("Lower case: {0}", myName.ToLower());
            string myNameTrimmed = String.Format("Trimmed value: {0}", myName.Trim());
            string myNameSubString = String.Format("SubString value: {0}", myName.Substring(0, 5));
            Console.WriteLine(myNameUpperCase);
            Console.WriteLine(myNameLowerCase);
            Console.WriteLine(myNameTrimmed);
            Console.WriteLine(myNameSubString);
            Console.ReadKey();
        }
    }
}
