using System;

namespace ChallengeStrings2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a string here: ");
            // Read the string
            string theString = Console.ReadLine();

            Console.Write("Enter character to search: ");
            // Read the character input to search
            char theChar = Console.ReadLine()[0];
            // Gets the index of the character from the string
            int searchIndex = theString.IndexOf(theChar);
            // Print the index as a search result on console
            Console.WriteLine("The index of the character in the string is {0}",searchIndex);

            string firstName;
            string lastName;
            string fullName;

            Console.Write("Enter first name: ");
            //Read first name
            firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            // Read the last name
            lastName = Console.ReadLine();
            // Concatinate and assign the result in fullName
            fullName = string.Concat(firstName," ", lastName);
            // Prints full name
            Console.WriteLine("Your full name is {0}", fullName);
            Console.ReadKey();
        }
    }
}
