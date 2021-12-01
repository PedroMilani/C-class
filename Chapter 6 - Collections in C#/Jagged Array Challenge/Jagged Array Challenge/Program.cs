using System;

namespace Jagged_Array_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a jagged array which contains 3 "friends arrays", in which two family members should be stored
            // introduce family members from different families to each other via console (three introductions)

            string[][] threeFriends =
            {
                new string[]{"Dad1","Mom1"},
                new string[]{"Dad2","Mom2"},
                new string[]{"Dad3","Mom3"}
            };

            Console.WriteLine("Hey {0}, this is {1}", threeFriends[0][0], threeFriends[1][1]);
            Console.WriteLine("Hey {0}, this is {1}", threeFriends[1][0], threeFriends[2][1]);
            Console.WriteLine("Hey {0}, this is {1}", threeFriends[2][0], threeFriends[0][1]);
            Console.ReadKey();
        }
    }
}
