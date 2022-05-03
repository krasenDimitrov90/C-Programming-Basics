using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            // Coins from 0.01 , 0.02 , 0.05 , 0.10 , 0.20 , 0.50 , 1 , 2 

            double change = double.Parse(Console.ReadLine());// the change that the machine have to give back
            change = Math.Floor(change * 100);

            int counter = 0;
            while (change != 0)
            {
                counter++;
                if (change - 200 >= 0)
                {
                    change -= 200;
                    
                }
                else if (change - 100 >= 0)
                {
                    change -= 100;
                    
                }
                else if (change - 50 >= 0)
                {
                    change -= 50;
                    
                }
                else if (change - 20 >= 0)
                {
                    change -= 20;
                    
                }
                else if (change - 10 >= 0)
                {
                    change -= 10;
                    
                }
                else if (change - 5 >= 0)
                {
                    change -= 5;
                    
                }
                else if (change - 2 >= 0)
                {
                    change -= 2;
                    
                }
                else if (change - 1 >= 0)
                {
                    change -= 1;
                    
                }
            }
            Console.WriteLine(counter);

        }
    }
}
