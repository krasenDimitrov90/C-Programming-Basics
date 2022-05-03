using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadionCapacity = int.Parse(Console.ReadLine());
            int countOfPeople = int.Parse(Console.ReadLine());

            // int capacityCounter = 0;
            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;
            for (int i = 1; i <= countOfPeople; i++)
            {
                
                char sector = char.Parse(Console.ReadLine());

                if (sector == 'A')
                {
                    sectorA++;
                }
                else if (sector == 'B')
                {
                    sectorB++;
                }
                else if (sector == 'V')
                {
                    sectorV++;
                }
                else if (sector == 'G')
                {
                    sectorG++;
                }
                // capacityCounter++;
                // if (capacityCounter == stadionCapacity)
                // {
                //     break;
                // }
            }

            Console.WriteLine($"{(1.0 * sectorA / countOfPeople)*100:f2}%");
            Console.WriteLine($"{(1.0 * sectorB / countOfPeople)*100:f2}%");
            Console.WriteLine($"{(1.0 * sectorV / countOfPeople)*100:f2}%");
            Console.WriteLine($"{(1.0 * sectorG / countOfPeople)*100:f2}%");
            Console.WriteLine($"{(1.0 * countOfPeople / stadionCapacity)*100:f2}%");
        }
    }
}
