using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlMinutes = int.Parse(Console.ReadLine());
            int controlSeconds = int.Parse(Console.ReadLine());
            double holeLenght = double.Parse(Console.ReadLine());
            int seconds100Meters = int.Parse(Console.ReadLine());

            int controlTimeInSeconds = controlMinutes * 60 + controlSeconds;
            double slowdownInSeconds = (holeLenght / 120)*2.5;

            double totalTime = (holeLenght / 100) * seconds100Meters;
            if (holeLenght >= 120)
            {
                totalTime -= slowdownInSeconds; 
            }
            if (totalTime <= controlTimeInSeconds)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {totalTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {totalTime - controlTimeInSeconds:f3} second slower.");
            }
        }
    }
}
