using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtDemo
{
    class Shirt
    {
        public string Material { get; set; }
        public string Colour { get; set; }
        public char Size { get; set; }

        public Shirt(string mat, string color, char size)
        {
            this.Material = mat;
            this.Colour = color;
            this.Size = size;
        }

        public override string ToString()
        {
            return string.Format("Material: {0}\nColour: {1}\nSize: {2}",
                this.Material, this.Colour, this.Size);
        }

    }
}