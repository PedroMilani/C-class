using System;

namespace Enhanced_If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {

            // condition ? first_expression : second_expression;
            // condition has to be either true or false
            // the conditional operatoris right - associative.
            // the expression a ? b : (c ? d : e),
            // not as (a ? b : c) ? d : e
            // the conditional operator cannot be overloaded

            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 30;

            // in short:
            stateOfMatter = temperature < 0 ? "solid" : "liquid"; // this is the enhanced if statement format

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 100;

            stateOfMatter = temperature < 0 ? "solid" : (temperature > 100 ? "gas" : "liquid");

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            Console.ReadKey();
        }
    }
}
