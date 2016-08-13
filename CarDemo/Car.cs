using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    class Car
    {
        public string Model { get; set; }
        public int MilesPerGallon { get; set; }

        public Car(string model, int mpg)
        {
            this.Model = model;
            this.MilesPerGallon = mpg;
        }

        public Car(string model) : this(model, 20) { }

        public static Car operator ++(Car c)
        {
            c.MilesPerGallon++;
            return c;
        }

        public override string ToString()
        {
            return string.Format("Model: {0}\nMiles per Gallon: {1}",
                this.Model, this.MilesPerGallon);
        }
    }
}
