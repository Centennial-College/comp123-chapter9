using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Conference[] conferences = new Conference[5];

            string groupName;
            string startDate;
            int numAttendees;

            for (int i = 0; i < conferences.Length; i++)
            {
                Console.Write("Please enter the name of the conference group: ");
                groupName = Console.ReadLine();
                Console.Write("Please enter the start date of the conference: ");
                startDate = Console.ReadLine();
                Console.Write("Please enter the number of expected attendees: ");
                numAttendees = int.Parse(Console.ReadLine());

                conferences[i] = new Conference(groupName, startDate, numAttendees);
            }

            //Sort and display Conference objects
            Array.Sort(conferences);

            foreach (Conference aConference in conferences)
            {
                Console.WriteLine(aConference);
                Console.WriteLine();
            }
        }
    }
}
