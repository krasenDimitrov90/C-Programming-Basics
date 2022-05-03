using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string contribution = (Console.ReadLine());
            double balance = 0;
            

            while (contribution != "NoMoreMoney")
            {
                double contributionAsNumber = double.Parse(contribution);
                
                
                if (contributionAsNumber <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {contributionAsNumber:f2}");
                balance += contributionAsNumber;
                contribution = (Console.ReadLine());


            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
