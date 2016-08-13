using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxpayer[] taxpayers = new Taxpayer[10];

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

            foreach (Taxpayer t in taxpayers)
            {
                Console.WriteLine(t + "\n");
            }

        }
    }
}
