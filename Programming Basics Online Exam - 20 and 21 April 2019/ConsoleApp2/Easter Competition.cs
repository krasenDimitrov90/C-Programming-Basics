using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int eastBreadCount = int.Parse(Console.ReadLine());

            string bestBaker = "";
            int bestPoints = 0;

            for (int i = 0; i < eastBreadCount; i++)
            {
                string backerName = Console.ReadLine();

                string pointsFromPerson = Console.ReadLine();
                int gradeFromPerson = 0;

                while (pointsFromPerson != "Stop")
                {
                    gradeFromPerson += int.Parse(pointsFromPerson);
                    pointsFromPerson = Console.ReadLine();
                }

                Console.WriteLine($"{backerName} has {gradeFromPerson} points.");

                if (bestPoints < gradeFromPerson)
                {
                    Console.WriteLine($"{backerName} is the new number 1!");
                    bestBaker = backerName;
                    bestPoints = gradeFromPerson;
                }
                
            }

            Console.WriteLine($"{bestBaker} won competition with {bestPoints} points!");


        }
    }
}
