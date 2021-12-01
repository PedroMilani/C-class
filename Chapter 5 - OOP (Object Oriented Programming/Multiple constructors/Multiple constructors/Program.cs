using System;

namespace Multiple_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human basicHuman = new Human();
            Human pedro1 = new Human("Pedro");
            Human pedro2 = new Human("Pedro", "Milani");
            Human pedro3 = new Human("Pedro", "Milani", 28);
            Human pedro4 = new Human("Pedro", "Milani", 28, "Black");

            basicHuman.introduceMyself();
            pedro1.introduceMyself();
            pedro2.introduceMyself();
            pedro3.introduceMyself();
            pedro4.introduceMyself();

            Console.ReadKey();
        }
    }
}
