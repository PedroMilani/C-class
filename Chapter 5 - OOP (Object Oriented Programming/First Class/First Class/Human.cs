using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Class
{
    // this class is a blueprint (diagrama) for a datatype
    class Human
    {
        // member variable
        public string firstName;
        public string lastName;

        // member method
        public void introduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }

    }
}
