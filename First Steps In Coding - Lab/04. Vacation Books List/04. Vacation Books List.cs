using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPages = int.Parse(Console.ReadLine());
            int pagesReadPerHour = int.Parse(Console.ReadLine());
            int daysNeeded = int.Parse(Console.ReadLine());

            int totalTimeNeed = countPages / pagesReadPerHour;
            int totalDaysNeed = totalTimeNeed / daysNeeded;
            Console.WriteLine(totalDaysNeed);
        }
    }
}
