using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_constructors
{
    class Human
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Default object created.");
        }

        // parameterized constructor
        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public Human(string firstName, string lastName, int age, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
        }

        public void introduceMyself()
        {
            if (eyeColor == null && age != 0 && lastName != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1} and I have {2} years old.", firstName, lastName, age);
            else if (eyeColor == null && age == 0 && lastName != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
            else if (eyeColor == null && age == 0 && lastName == null && firstName != null)
                Console.WriteLine("Hi, I'm " + firstName + ".");
            else if (eyeColor != null && age != 0 && lastName != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1} and I have {2} years old. My eyes are {3}.", firstName, lastName, age, eyeColor);
            else if (eyeColor == null && age == 0 && lastName == null && firstName == null)
                Console.WriteLine("Basic humans doesn't introduce themselves.");
        }
    }
}
