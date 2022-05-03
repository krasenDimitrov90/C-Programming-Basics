using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int Days = int.Parse(Console.ReadLine());
            int Hours = int.Parse(Console.ReadLine());

            int counterDays = 0;
            double totalSumForTheDays = 0;
            for (int i = 1; i <= Days; i++)
            {
                counterDays++;
                int countHours = 0;
                double sumOfHoursForDay = 0;
                for (int j = 1; j <= Hours; j++)
                {
                    double sumOfOneHour = 0;
                    countHours++;
                    if (counterDays % 2 == 0 && countHours % 2 != 0)
                    {
                        sumOfOneHour = 2.50;
                    }
                    else if (counterDays % 2 != 0 && countHours % 2 == 0)
                    {
                        sumOfOneHour = 1.25;
                    }
                    else
                    {
                        sumOfOneHour = 1.00;
                    }
                    sumOfHoursForDay += sumOfOneHour;
                    
                }
                totalSumForTheDays += sumOfHoursForDay;
                Console.WriteLine($"Day: {counterDays} - {sumOfHoursForDay:f2} leva");
            }
            Console.WriteLine($"Total: {totalSumForTheDays:f2} leva");
        }
    }
}
