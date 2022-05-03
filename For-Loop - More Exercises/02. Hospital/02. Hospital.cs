using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int totalTreatedPatients = 0;
            int totalUntreatedPatients = 0;
            int countOfDoctors = 7;
            int totalTreatedForThreeDays = 0;
            int totalUntreatedForThreeDays = 0;

            for (int i = 1; i <= period; i++)
            {
                if (i % 3 == 0)
                {
                    if (totalTreatedPatients < totalUntreatedPatients)
                    {
                        countOfDoctors++;
                    }
                    //totalTreatedForThreeDays = 0;
                    //totalUntreatedForThreeDays = 0;
                }
                int treatedPatients = 0;
                int untreatedPatients = 0;
                int countOfPatients = int.Parse(Console.ReadLine());

                if (countOfPatients <= countOfDoctors)
                {
                    treatedPatients = countOfPatients;
                }
                else
                {
                    treatedPatients = countOfDoctors;
                    untreatedPatients = countOfPatients - countOfDoctors;
                }

                totalTreatedPatients += treatedPatients;
                totalUntreatedPatients += untreatedPatients;

                //totalTreatedForThreeDays += treatedPatients;
                //totalUntreatedForThreeDays += untreatedPatients;
            }


            // "Treated patients: {брой прегледани пациенти}."
            //•	На втория ред: "Untreated patients: {брой непрегледани пациенти}."

            Console.WriteLine($"Treated patients: {totalTreatedPatients}.");
            Console.WriteLine($"Untreated patients: {totalUntreatedPatients}.");
        }
    }
}
