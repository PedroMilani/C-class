using System;

namespace Conventions_and_standards
{
    class Program //Class names like ClientActivity (nouns)
    {
        // Method names like CalculateValue (verbs)
        // Method arguments like firstNumber
        static void Main(string[] args)
        {
            // local variables like itemCount

            // use userControl instead of usrCtr

            // don't use numbers at the start of variable names

            // Correct
            string myName;
            int lastNum;
            bool isSaved;

            // Avoid
            // String myName;
            // Int32 lastNum;
            // Boolean isSaved;

            // more info on https://dofactory.com/csharp-coding-standards
        }
    }
}
