using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxPayerDemo;

namespace TaxpayerDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxpayer[] taxpayers = new Taxpayer[5];

            string ssn;
            double income;

            for (int i = 0; i < taxpayers.Length; i++)
            {
                Console.Write("Please enter your Social Security Number: ");
                ssn = Console.ReadLine();

                Console.Write("Please enter your yearly gross income: ");
                income = int.Parse(Console.ReadLine());

                taxpayers[i] = new Taxpayer(ssn, income);
            }

            Console.WriteLine();
            Console.WriteLine("BEFORE SORT +++++++++++++++++++++++++++++++++++++");

            foreach (Taxpayer t in taxpayers)
            {
                Console.WriteLine(t + "\n");
            }

            Console.WriteLine();
            Console.WriteLine("AFTER SORT +++++++++++++++++++++++++++++++++++++");

            Array.Sort(taxpayers);

            foreach (Taxpayer t in taxpayers)
            {
                Console.WriteLine(t + "\n");
            }
        }
    }
}
