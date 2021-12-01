using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        // an array that fills the tic tac toe field
        static char[,] playField =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };

        static int player1Score = 0;
        static int player2Score = 0;

        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;


            // run code as long as the program runs
            do
            {

                if (player == 2)
                {
                    EnterXorO(player, input);
                    player = 1;
                }
                else if (player == 1)
                {
                    EnterXorO(player, input);
                    player = 2;
                }

                SetField();

                #region
                // check winning condition
                char[] playerChars = { 'X', 'O' };

                foreach(char playerChar in playerChars)
                {
                    if ((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar) ||
                        (playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar) ||
                        (playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar) ||
                        (playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar) ||
                        (playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar) ||
                        (playField[0, 2] == playerChar) && (playField[1, 2] == playerChar) && (playField[2, 2] == playerChar) ||
                        (playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar) ||
                        (playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar))
                    {
                        if (playerChar == 'O')
                        {
                            Console.WriteLine("Player 2 has won!");
                            ++player2Score;
                        }
                        else if (playerChar == 'X')
                        {
                            Console.WriteLine("Player 1 has won!");
                            ++player1Score;
                        }
                        Console.WriteLine("Press any key to reset the game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
   

                }
               
               // a simpler way is to create a variable turns and add turns++ in the setField method and set to 0 in resetField method,
               // when it reaches 10 and no one wins in the check winning condition the console should print "draw"
               if ((playField[0, 0] != '1') && (playField[0, 1] != '2') && (playField[0, 2] != '3') &&
                        (playField[1, 0] != '4') && (playField[1, 1] != '5') && (playField[1, 2] != '6') &&
                        (playField[2, 0] != '7') && (playField[2, 1] != '8') && (playField[2, 2] != '9'))
                {
                    Console.WriteLine("Draw!");
                    Console.WriteLine("Press any key to reset the game");
                    Console.ReadKey();
                    ResetField();
                }
               

                #endregion

                #region
                // test if the field is already taken
                do
                {

                    Console.Write("\nPlayer {0}, choose your field: ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number.");
                    }
                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("Incorrect input.");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);
                #endregion

            } while (true);

        }

        // resets the field
        public static void ResetField()
        {
            char[,] playFieldInitial =
            {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
            };
            playField = playFieldInitial;
            SetField();
        }

        // prints the tic tac toe field and scores
        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("    _________________");
            Console.WriteLine("   |     |     |     |");
            Console.WriteLine("   |  {0}  |  {1}  |  {2}  |", playField[0,0], playField[0,1], playField[0,2]);
            Console.WriteLine("   |_____|_____|_____|");
            Console.WriteLine("   |     |     |     |");
            Console.WriteLine("   |  {0}  |  {1}  |  {2}  |", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("   |_____|_____|_____|");
            Console.WriteLine("   |     |     |     |");
            Console.WriteLine("   |  {0}  |  {1}  |  {2}  |", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("   |_____|_____|_____|");
            Console.WriteLine();
            Console.WriteLine("SCORE:\nPlayer 1: {0} WINS\nPlayer 2: {1} WINS\n",player1Score,player2Score);

        }

        // set X or O in the tic tac toe
        public static void EnterXorO(int player, int input)
            {
                char playerSign = ' ';

                if (player == 1)
                {
                    playerSign = 'X';
                }
                else if (player == 2)
                {
                    playerSign = 'O';
                }
                switch (input)
                {
                    case 1: playField[0, 0] = playerSign; break;
                    case 2: playField[0, 1] = playerSign; break;
                    case 3: playField[0, 2] = playerSign; break;
                    case 4: playField[1, 0] = playerSign; break;
                    case 5: playField[1, 1] = playerSign; break;
                    case 6: playField[1, 2] = playerSign; break;
                    case 7: playField[2, 0] = playerSign; break;
                    case 8: playField[2, 1] = playerSign; break;
                    case 9: playField[2, 2] = playerSign; break;
                }
            }
    }
}
