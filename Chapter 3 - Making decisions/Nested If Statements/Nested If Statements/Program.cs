using System;

namespace Nested_If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Enter user name: ");
            userName = Console.ReadLine();
            if (isRegistered && userName != "" && userName.Equals("Admin")) // avoid lots of "ifs" inside of each other
            {
                /*Console.WriteLine("Hi there registered user");
                if(userName != "")
                {
                    Console.WriteLine("Hi there " + userName );
                    if(userName.Equals("Admin"))
                    {*/
                        Console.WriteLine("Hi there Admin");/*
                    }
                }*/
            }

            if(isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }

            Console.ReadKey();
        }
    }
}
