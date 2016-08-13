using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Room[] roomArr = new Room[10];
            Random ranNumGen = new Random();

            for (int i = 0; i < roomArr.Length; i++)
            {
                roomArr[i] = new Room(ranNumGen.Next(1, 101), ranNumGen.Next(1, 101));
            }


            foreach (Room room in roomArr)
            {
                Console.WriteLine(room);
            }

        }
    }
}
