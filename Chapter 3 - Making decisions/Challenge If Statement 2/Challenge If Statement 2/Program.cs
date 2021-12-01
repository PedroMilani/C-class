using System;

namespace Challenge_If_Statement_2
{
    class Program
    {
        static int highscore = 1000;
        static string highscoreName = "Unknown";

        static void Main(string[] args)
        {
            CheckHighscore("Pedro",8000);
            CheckHighscore("A", 1);
            CheckHighscore("Jessica", 2342346);
            CheckHighscore("B", 2);

            Console.ReadKey();
        }

        public static void CheckHighscore(string playerName, int playerScore)
        {
            if (playerScore > highscore)
            {
                highscore = playerScore;
                highscoreName = playerName;
                Console.WriteLine("New highscore is " + playerScore);
                Console.WriteLine("New highscore holder is " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscoreName);
            }
        }
    }
}
