using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Constructor
{
    class Human
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // constructor
        public Human(string firstName,string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void introduceMyself()
        {
            if (age == 1)
            {
                Console.WriteLine("Hi, I'm {0} {1}. I'm {2} year old and my eyes are {3}.", firstName, lastName, age, eyeColor);
            }
            else
            {
                Console.WriteLine("Hi, I'm {0} {1}. I'm {2} years old and my eyes are {3}.", firstName, lastName, age, eyeColor);
            }
        }
    }
}
