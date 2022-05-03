using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = (Console.ReadLine());

            int sumPrime = 0;
            int sumNonPrime = 0;

            while (n != "stop")
            {
                int num = int.Parse(n);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    
                }
                else
                {
                    bool isNonPrime = false;

                    // find if number is prime
                    for (int i = 2; i < num; i++)
                    {

                        if (num % i == 0 && num != 2)
                        {
                            isNonPrime = true;
                            break;
                        }
                    }
                    if (isNonPrime)
                    {
                        sumNonPrime += num;
                    }
                    else
                    {
                        sumPrime += num;
                    }
                }
                n = (Console.ReadLine());
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
