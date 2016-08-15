using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(2, 1, 4);
            Fraction f2 = new Fraction(1, 3, 5);
            Fraction f3 = new Fraction(9, 4);
            Fraction f4 = new Fraction(8, 5);
            Fraction f5 = new Fraction(2, 0, 3);
            Fraction f6 = new Fraction(2, 4);
            Fraction f7 = new Fraction(4, 5);
            Fraction f8 = new Fraction(1, 1, 2);

            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f3);
            Console.WriteLine(f4);
            Console.WriteLine(f5);
            Console.WriteLine(f6);

            Console.WriteLine("REDUCE TEST ++++++++++++++++++++++++++++++");
            f6.Reduce();
            Console.WriteLine(f6);

            Console.WriteLine();
            Console.WriteLine("ADDITION TEST ++++++++++++++++++++++++++++++");
            Console.WriteLine("{0} + {1} = {2}", f1, f2, f1 + f2);

            Console.WriteLine();
            Console.WriteLine("MULTIPLICATION TEST ++++++++++++++++++++++++++++++");
            Console.WriteLine("{0} + {1} = {2}", f7, f8, f7 * f8);

            Console.WriteLine();
            Console.WriteLine("ALL POSSIBLE ADDITION COMBINATIONS IN ARRAY ++++++++++++++++++++++++++++++");
            Fraction[] fracArray = { f1, f2, f3, f4 };

            foreach (Fraction fraction1 in fracArray)
            {
                foreach (Fraction fraction2 in fracArray)
                {
                    Console.WriteLine("{0} + {1} = {2}",
                        fraction1, fraction2, fraction1 + fraction2);
                }
            }

            Console.WriteLine();
            Console.WriteLine("ALL POSSIBLE MULTIPLICATION COMBINATIONS IN ARRAY ++++++++++++++++++++++++++++++");

            foreach (Fraction fraction1 in fracArray)
            {
                foreach (Fraction fraction2 in fracArray)
                {
                    Console.WriteLine("{0} * {1} = {2}",
                        fraction1, fraction2, fraction1 * fraction2);
                }
            }

        }
    }
}
