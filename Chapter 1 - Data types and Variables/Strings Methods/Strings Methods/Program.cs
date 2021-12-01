using System;

namespace Strings_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Pedro";
            string lastName = "Milani";
            string fullName = string.Concat("", firstName, lastName, "");

            Console.WriteLine(firstName.Substring(2)); // Output: "dro"
            Console.WriteLine(firstName.ToLower()); // Output: "pedro"
            Console.WriteLine(firstName.ToUpper()); // Output: "PEDRO"
            Console.WriteLine(fullName.Trim()); // Output: "PedroMilani"
            Console.WriteLine(firstName.IndexOf('e')); // Output: "1"
            Console.WriteLine(String.IsNullOrWhiteSpace(firstName)); // Output: false
            Console.ReadKey();
        }
    }
}
