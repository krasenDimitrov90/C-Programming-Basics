using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfgroups = int.Parse(Console.ReadLine());// броя на групите

            int totalPeople = 0;
            int musala = 0;
            int monblan = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;

            for (int i = 0; i < numberOfgroups; i++)
            {
                int people = int.Parse(Console.ReadLine()); //боря на хората в група
                totalPeople += people;

                if (people < 6)
                {
                    musala += people;
                }
                else if (people < 13)
                {
                    monblan += people;
                }
                else if (people < 26)
                {
                    kilimandjaro += people;
                }
                else if (people < 41)
                {
                    k2 += people;
                }
                else
                {
                    everest += people;
                }
            }

            // Умножаваме по десетично число иначе програмата не разрешава ,
            // действия за променлива от тип double с такива от тип Int
            double p1 = 100.0 * musala / totalPeople;
            double p2 = 100.0 * monblan / totalPeople;
            double p3 = 100.0 * kilimandjaro / totalPeople;
            double p4 = 100.0 * k2 / totalPeople;
            double p5 = 100.0 * everest / totalPeople;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}
