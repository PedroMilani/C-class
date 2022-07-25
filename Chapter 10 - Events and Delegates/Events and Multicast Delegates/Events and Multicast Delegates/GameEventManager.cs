using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Multicast_Delegates
{
    class GameEventManager
    {
        // ############### ANNOTATIONS ############
        // Events are forced to behave like a list ( += -= )
        // Delegates allow a direct assignment ( myDelegate = myMethod )
        // Events can't be triggered from outside the class that defines them0

        public delegate void GameEvent();

        public static event GameEvent OnGameStart, OnGameOver;

        public static void TriggerGameStart()
        {
            if (OnGameStart != null)
            {
                Console.WriteLine("The game has started...");
                // call the OnGameStart that will trigger all the methods subscribed to this event
                OnGameStart();
            }
        }

        public static void TriggerGameOver()
        {
            if(OnGameOver != null)
            {
                Console.WriteLine("The game is over...");
                OnGameOver();
            }
        }


    }
}
