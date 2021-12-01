using System;

namespace Using_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Human pedro = new Human("Pedro", "Milani", "Black", 28);
            Human jessica = new Human("Jessica", "Moraes", "Black", 1);
            pedro.introduceMyself();
            jessica.introduceMyself();

            Console.ReadKey();
        }
    }
}
