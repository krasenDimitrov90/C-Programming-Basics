using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string Serie = Console.ReadLine();
            int episode = int.Parse(Console.ReadLine());
            int lunch = int.Parse(Console.ReadLine());

            double timeLeft = lunch*5.0/8;
            
            

            if (timeLeft >= episode)
            {
                Console.WriteLine($"You have enough time to watch {Serie} and left with {Math.Ceiling(timeLeft - episode)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {Serie}, you need {Math.Ceiling(episode - timeLeft)} more minutes.");
            }
            
            
            
            
        }
    }
}
