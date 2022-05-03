using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int seconNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isFound = false;
            int firstNumberCounter = 0;
            int secondNumberCounter = 0;

            for (int i = startNumber; i <= seconNumber; i++)
            {
                
                for (int j = startNumber; j <= seconNumber; j++)
                {
                    
                    counter++;
                    if (magicNumber == (i + j))
                    {
                        firstNumberCounter = i;
                        secondNumberCounter = j;

                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine($"Combination N:{counter} ({firstNumberCounter} + {secondNumberCounter} = {magicNumber})");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
