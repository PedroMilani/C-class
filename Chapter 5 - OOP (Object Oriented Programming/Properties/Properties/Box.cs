using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    // EXAMPLES OF PROPERTIES

    class Box
    {
        // member variable
        private double length = 3;
        private double height;
        //public double width;
        private double volume;

        // "prop" double tab:
        public double Width { get; set; } // deafault getter and setter
        // implicit this means:
        /*
        public double Width()
        {
        get{return this.width;}
        set{this.width = value;}
        }
        */

        public double Heigth
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Heigth cannot be 0 or less.");
                else
                    height = value;
            }
        }

        public Box(double length, double height, double width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }

        public void SetLength(double length)
        {
            if (length <= 0)
                throw new Exception("The length hould be higher than 0.");
            else
                this.length = length;
        }

        public double GetLength()
        {
            return this.length;
        }

        public double Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
        }



        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1} and width is {2} so the volume is {3}", 
                length, height, Width, Volume);
        }

    }
}
