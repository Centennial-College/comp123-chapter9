using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoJobs
{
    class Program
    {
        static void Main(string[] args)
        {
            Job j1 = new Job("wash windows", 3.5, 25);
            Job j2 = new Job("peer tutor", 10, 12);
            Job j3 = new Job("college faculty", 15, 50);

            Console.WriteLine(j1);
            Console.WriteLine();
            Console.WriteLine(j2);
            Console.WriteLine();
            Console.WriteLine(j3);
            Console.WriteLine();

            Console.WriteLine("OPERATOR + OVERLOADED TESTING ++++++++++++++++++++++++++++++++");
            Console.WriteLine(j1 + j2);
        }
    }
}
