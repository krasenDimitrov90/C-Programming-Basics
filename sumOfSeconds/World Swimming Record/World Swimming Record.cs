using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeMeter = double.Parse(Console.ReadLine());

            
            double distance2 = distance / 15;
            double distance3 = Math.Floor(distance2);
            double newRecord = distance * timeMeter;

            if (distance3 >= 1)
            {
                newRecord = distance * timeMeter + (distance3 * 12.5);
            }
            

            if (newRecord < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {Math.Abs (newRecord):f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(newRecord - record):f2} seconds slower.");
            }

        }
    }
}
