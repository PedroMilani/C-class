using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_challenge
{
    // Challenge: create a read only property "FrontSurface" which
    // calculates the front surface based on height and length.
    class Box
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public Box(double length, double height, double width)
        {
            Length = length;
            Height = height;
            Width = width;
        }

        public double FrontSurface
        {
            get
            {
                return Length * Height;
            }
        }
    }
}
