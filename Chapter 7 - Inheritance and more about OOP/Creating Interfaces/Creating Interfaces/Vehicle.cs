using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Interfaces
{
    class Vehicle
    {
        public float Speed { get; set; }
        public string Color { get; set; }
        public Vehicle()
        {
            Speed = 120f;
            Color = "Black";
        }

        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
