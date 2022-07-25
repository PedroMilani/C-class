using System;
using System.Collections.Generic;

namespace Creating_Delegate
{
    class Program
    {
        // defining a delegate type that takes a person object and return a bool
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 67 };
            Person p3 = new Person() { Name = "Walter", Age = 14 };
            Person p4 = new Person() { Name = "Pedro", Age = 28 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Seniors", people, IsSenior);


            // ############# ANONYMOUS METHOD ##############

            // Here we created a new variable called filter of type FilteDelegate
            // then we assigned an anonymous method to it instead of an already defined method
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            }; // it has the ; at the end because we are declaring and assigning a value to the variable filter

            DisplayPeople("Young adults", people, filter);

            // also works like:
            DisplayPeople("All:", people, delegate (Person p) { 
                return true; 
            }
            );

            // ############## LAMBDA EXPRESSION ################
            string searchKeyword = "A";
            DisplayPeople("age > 20 with searchKeyword: " + searchKeyword, people, /* THE LAMBDA EXPRESSION: */ (p) =>
            {
                if(p.Name.Contains(searchKeyword) && p.Age > 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            DisplayPeople("Exactly 28", people, p => p.Age == 28); // The beaty of lambda expressions:
                                                                  // One line of code
            Console.ReadKey();
        }

        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);
            
            foreach(Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine("{0}, {1} years old.", p.Name, p.Age);
                }
            }
            Console.WriteLine();
        }


        // ############# FILTERS ###############
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 60;
        }
    }
}
