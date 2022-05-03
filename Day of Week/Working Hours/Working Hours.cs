using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            

            switch (day)
            {
                // Verify if the day is working day
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    //Verify if the hour is in range of working time
                    if (hour >= 10 && hour <=18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                    // If the day and the hour aren't in working range , the shop is closed
                default:
                    Console.WriteLine("closed");
                    break;
                       
            }

            
        }
    }
}
