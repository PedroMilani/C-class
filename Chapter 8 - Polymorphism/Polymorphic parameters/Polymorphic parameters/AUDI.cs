using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic_parameters
{
    class AUDI : Car
    {
        public string Model { get; set; }
        private string Brand = "AUDI";
        public AUDI(string color, int hp, string model) : base(color, hp)
        {
            this.Model = model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("The {0} is {1} and have {2} HP!", Brand, Color, HP);
        }

        public override void Repair()
        {
            Console.WriteLine("The AUDI {0} was repaired.", Model);
        }
    }
}
