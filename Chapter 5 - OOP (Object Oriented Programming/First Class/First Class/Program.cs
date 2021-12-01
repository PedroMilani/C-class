using System;

namespace First_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object of my class
            // an instance of human
            Human pedro = new Human();
            Human jessica = new Human();

            // access public variable from outside and even change it
            pedro.firstName = "Pedro";
            pedro.lastName = "Milani";
            jessica.firstName = "Jessica";
            jessica.lastName = "Moraes";

            // call methods of the class
            pedro.introduceMyself();
            jessica.introduceMyself();

            Console.ReadKey();
        }
    }
}
