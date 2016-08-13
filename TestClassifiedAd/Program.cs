using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassifiedAd
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassifiedAd c = new ClassifiedAd("Used Cars", 529);

            Console.WriteLine(c);
        }
    }
}
