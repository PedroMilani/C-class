using System;

namespace Challenge_If_Statements
{
    class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.ReadKey();
        }

        public static void Register()
        {
            Console.Write("Sign up! Type the username and password.\nUsername: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed.\n------------------------------------------------");
        }

        public static void Login()
        {
            Console.Write("Now, let's log in.\nEnter Login: ");
            string tryusername = Console.ReadLine();
            if (tryusername.Equals(username))
            {
                Console.Write("Password: ");
                string trypassword = Console.ReadLine();
                if (trypassword.Equals(password))
                {
                    Console.WriteLine("Loged in.");
                }
                else
                {
                    Console.WriteLine("Wrong password.");
                }
            }
            else
            {
                Console.WriteLine("Wrong username.");
            }
        }
    }
}
