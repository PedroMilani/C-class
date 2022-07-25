using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic_parameters
{
    class BMW : Car
    {
        public string Model { get; set; }
        private string Brand = "BMW";
        public BMW(string color, int hp, string model) : base(color, hp)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("The {0} is {1} and have {2} HP!", Brand, Color, HP);
        }

        public sealed override void Repair() // sealed prevents further children classes to override this method
        {
            Console.WriteLine("The BMW {0} was repaired.", Model);
        }

    }
}
