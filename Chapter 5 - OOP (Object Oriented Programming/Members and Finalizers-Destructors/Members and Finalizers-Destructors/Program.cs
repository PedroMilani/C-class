using System;

namespace Members_and_Finalizers_Destructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Members member1 = new Members();
            member1.Introducing(true); // calling a public method that contains a private method, so it works
        }            
    }
}
