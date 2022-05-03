using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondtLetter = char.Parse(Console.ReadLine());
            char wrongLetter = char.Parse(Console.ReadLine());

            int counter = 0;

            for (char i = firstLetter; i <= secondtLetter; i++)
            {
                if (i == wrongLetter)
                {
                    continue;
                }
                for (char j = firstLetter; j <= secondtLetter; j++)
                {
                    if (j == wrongLetter)
                    {
                        continue;
                        
                    }
                    for (char k = firstLetter; k <= secondtLetter; k++)
                    {
                        if (k == wrongLetter)
                        {
                            continue;
                            
                        }
                        Console.Write($"{i}{j}{k} ");
                        counter++;
                    }
                }

            }
            Console.WriteLine(counter);
        }
    }
}
