using System;

namespace Loop_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop - for(start value; condition; increment) - great for counters
            // while loop (check then go) - while(condition){ "action"; counter++;} - executes code as long as the condition is met
            // do while loop (do first then check) - (execute at least once) do{ "action"; counte++; }while(condition) - executes code as long as the condition is met
            // foreach loop (run through array or list) - only as long as there is content

            for(int counter=0; counter < 50; counter+=5) // +=5 increment by 5 // ++ increment by 1
            {
                Console.WriteLine(counter);
            }
            Console.WriteLine("For loop is done.");
            Console.WriteLine("");

            // ----------------------------------------------
            
            int count = 0;
            string enteredText = "";
            while (enteredText.Equals(""))
            {
                Console.WriteLine("Press enter to increase amount by one and anything else + enter to finish counting.");
                enteredText = Console.ReadLine();
                count++;
            }
            Console.WriteLine("Number of Empty entries is: {0}", count-1);
            Console.WriteLine("While loop is done.");
            Console.WriteLine("");

            // ----------------------------------------------

            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter a name.");
                string name = Console.ReadLine();
                int currentLenght = name.Length;
                lengthOfText += currentLenght;
                wholeText += name;

            } while (lengthOfText < 15);
            Console.WriteLine("Enought texte! " + wholeText);
            Console.WriteLine("Do while loop 1 is done.");
            Console.WriteLine("");
            
            // ------------------------------------------------
            int i = 0;
            double sum = 0;
            double noteInt;
            string note;
            int numOfNotes;
            Console.WriteLine("Tell how many notes will be entered:");
            string numOfNotesS = Console.ReadLine();
            int.TryParse(numOfNotesS, out numOfNotes);
            do
            {
                Console.Write("Type the note {0}: ",i+1);
                note = Console.ReadLine();
                double.TryParse(note, out noteInt);
                sum += noteInt;
                i++;
            } while (i < numOfNotes);
            double avg = sum / i;
            Console.WriteLine("The average is: " + avg);
            Console.WriteLine("Do while loop 2 is done.");



            Console.ReadKey();
        }
    }
}
