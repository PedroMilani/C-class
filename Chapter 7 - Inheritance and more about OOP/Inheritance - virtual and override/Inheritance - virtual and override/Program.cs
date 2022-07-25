using System;

namespace Inheritance___virtual_and_override
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Bacco", 15);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old.");
            dog.Play();
            dog.Eat();
            dog.MakeSound();

            Console.ReadKey();
        }
    }
}
