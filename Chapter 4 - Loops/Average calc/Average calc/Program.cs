using System;

namespace Average_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string noteS = "";
            double note = 0;
            double sum = 0;
            int count = 0;
            Console.WriteLine("---------------------\nAVERAGE CALCULATOR\n---------------------\nEnter the notes from 0 to 10.");

            while(noteS != "-1")
            {
                noteS = Console.ReadLine();
                bool rightValue = double.TryParse(noteS, out note);
                if(rightValue == false) // check if entered value is valid
                {
                    Console.WriteLine("Enter a valid number.");
                    continue;
                }
                if (noteS.Equals("-1")) // end the loop
                {
                    break;
                }
                if (note > 10 || note < 0) // check if the enetered number is valid
                {
                    Console.WriteLine("Wrong value (0 to 10 only).");
                    continue;
                }
                sum += note;
                count++;
                Console.WriteLine("Last note entered is {0}.", note);
                Console.WriteLine("Current amount of entries {0}.", count);
                Console.WriteLine("Please enter -1 once you are ready to calculate the average.");
            }
            double avg = sum / count;
            Console.WriteLine("\nThe number of valid entries is " + count);
            Console.WriteLine("The average is: " + avg);
            Console.ReadKey();
        }
    }
}
