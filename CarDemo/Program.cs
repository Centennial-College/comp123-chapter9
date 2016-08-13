using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Honda", 92);
            Car c2 = new Car("BMW");

            Console.WriteLine(c1);
            Console.WriteLine();
            Console.WriteLine(c2);
            Console.WriteLine();

            Console.WriteLine("Operator ++ testing +++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            c1++;
            Console.WriteLine(c1);
        }
    }
}
