using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shirt s1 = new Shirt("Cotton", "Blue", 'L');
            Shirt s2 = new Shirt("Polyester", "Red", 'S');
            Shirt s3 = new Shirt("Paper", "White", 'M');

            Console.WriteLine("NO SHIRTS +++++++++++++++++++++++++++++++++++++++++++++");
            Display();
            Console.WriteLine();


            Console.WriteLine("ONE SHIRT +++++++++++++++++++++++++++++++++++++++++++++");
            Display(s1);
            Console.WriteLine();

            Console.WriteLine("TWO SHIRTS +++++++++++++++++++++++++++++++++++++++++++++");
            Display(s1, s2);
            Console.WriteLine();


            Console.WriteLine("THREE SHIRTS +++++++++++++++++++++++++++++++++++++++++++++");
            Display(s1, s2, s3);
            Console.WriteLine();

        }

        public static void Display(params Shirt[] shirts)
        {
            foreach (Shirt aShirt in shirts)
            {
                Console.WriteLine(aShirt);
                Console.WriteLine();
            }
        }
    }
}
