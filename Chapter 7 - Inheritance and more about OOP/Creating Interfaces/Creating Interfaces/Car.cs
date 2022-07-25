using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Interfaces
{
    class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }
        // Creating a new property to store the destroyable objects nearby when a car
        // gets destroyed it should also destroy the nearby object this list is of type
        // IDestroyable which means it can store any object that implements this
        // interface and we can only access the properties and methods in this interface
        public List<IDestroyable> DestroyablesNearby;
        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            // Initialize the interface's property with a value in the constructor
            DestructionSound = "CarDestruction.mp3";
            // Initialize the list of destroyable objects
            DestroyablesNearby = new List<IDestroyable>();
        }

        // Implementing the interface's method
        public void Destroy()
        {
            Console.WriteLine(DestructionSound);
            Console.WriteLine("Create fire.");
            foreach(IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }

    }
}
