using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic_parameters
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // Has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}.", carIDInfo.IDNum, carIDInfo.Owner);
        }

        public Car()
        {
            Color = "Black";
            HP = 100;
        }

        public Car(string color, int hp)
        {
            this.Color = color;
            this.HP = hp;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("The car is {0} and have {1} HP!", Color, HP);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
