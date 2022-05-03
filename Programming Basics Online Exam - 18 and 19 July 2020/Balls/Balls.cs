using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int ballsCount = int.Parse(Console.ReadLine());

            double points = 0;

            int redCounter = 0;
            int orangeCounter = 0;
            int yellowCounter = 0;
            int whiteCounter = 0;
            int blackCounter = 0;
            int otherCounter = 0;

            for (int i = 0; i < ballsCount; i++)
            {
                string color = Console.ReadLine();

                if (color == "red")
                {
                    redCounter++;
                    points += 5;
                }
                else if (color == "orange")
                {
                    orangeCounter++;
                    points += 10;
                }
                else if (color == "yellow")
                {
                    yellowCounter++;
                    points += 15;
                }
                else if (color == "white")
                {
                    whiteCounter++;
                    points += 20;
                }
                else if (color == "black")
                {
                    blackCounter++;
                    points = Math.Floor(points / 2);
                }
                else
                {
                    otherCounter++;
                    
                }
            }

            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redCounter}");
            Console.WriteLine($"Orange balls: {orangeCounter}");
            Console.WriteLine($"Yellow balls: {yellowCounter}");
            Console.WriteLine($"White balls: {whiteCounter}");
            Console.WriteLine($"Other colors picked: {otherCounter}");
            Console.WriteLine($"Divides from black balls: {blackCounter}");
        }
    }
}
