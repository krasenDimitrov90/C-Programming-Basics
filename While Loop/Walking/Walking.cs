using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            // стъпки които трябва да измине за един ден = 10 000
            // когато ги постигне програмата спира

            string steps = Console.ReadLine();// въвежда стъпки от потребителя 
            int stepCounter = 0;// сума от стъпките които извървява

            while (steps != "Going home")
            {
                int stepAsNumber = int.Parse(steps);
                stepCounter += stepAsNumber;
                
                if (stepCounter >= 10000)
                {
                    break;
                }
                steps = Console.ReadLine();
            }
            if (steps == "Going home")
            {
                steps = Console.ReadLine();
                int stepAsNumber = int.Parse(steps);
                stepCounter += stepAsNumber;
            }
            if (stepCounter >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepCounter - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - stepCounter} more steps to reach goal.");
            }

        }
    }
}
