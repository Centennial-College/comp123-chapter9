using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesTransaction s1 = new SalesTransaction("Bob", 423.12, 0.02);
            SalesTransaction s2 = new SalesTransaction("Sally", 4323.12, 0.01);

            Console.WriteLine(s1);
            Console.WriteLine();
            Console.WriteLine(s2);
            Console.WriteLine();

            Console.WriteLine("SUM: {0:C}", (s1 + s2));
        }
    }
}
