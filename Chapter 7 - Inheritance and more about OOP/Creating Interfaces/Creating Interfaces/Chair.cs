using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Interfaces
{
    class Chair: Furniture, IDestroyable
    {
        // Implementing the interface's property
        public string DestructionSound { get; set; }
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            // Initializing the interface's property with a value in the constructor
            DestructionSound = "ChairDestruction.mp3";
        }

        // Implementing the interface's method
        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed.");
            Console.WriteLine(DestructionSound);
            Console.WriteLine("Spawning chair parts.");
        }
    }
}
