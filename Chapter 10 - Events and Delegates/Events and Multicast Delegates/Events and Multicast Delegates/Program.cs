using System;

namespace Events_and_Multicast_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();

            RenderingEngine renderingEngine = new RenderingEngine();

            Player player1 = new Player("PMilani");
            Player player2 = new Player("Nosferatu");
            Player player3 = new Player("Dogg");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is Runing... Press any key to end the game.");

            Console.Read();

            GameEventManager.TriggerGameOver();
        }
    }
}
