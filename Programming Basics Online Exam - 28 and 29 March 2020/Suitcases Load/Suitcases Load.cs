using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkCapacity = double.Parse(Console.ReadLine());

            string command = "";
            int counter = 0;

            while (command != "End" && trunkCapacity >= 0)
            {
                command = Console.ReadLine();
                if (command != "End")
                {
                    counter++;
                    double suitcase = double.Parse(command);
                    
                    if (counter % 3 == 0)
                    {
                        suitcase = suitcase + suitcase * 0.10;
                    }
                    trunkCapacity -= suitcase;
                }
                
            }
            if (trunkCapacity >= 0)
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
                Console.WriteLine($"Statistic: {counter} suitcases loaded.");
            }
            else
            {
                Console.WriteLine("No more space!");
                Console.WriteLine($"Statistic: {counter - 1} suitcases loaded.");
            }

            
        }
    }
}
