using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int stars = 1;
            if (num % 2 == 0)
            {
                stars = 2;
            }

            for (int i = 0; i < ((num + 1) / 2); i++)
            {
                Console.Write(new string('-' , (num - stars) / 2));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', (num - stars) / 2));
                Console.WriteLine();
                stars += 2;
            }
            for (int i = 0; i < (num / 2); i++)
            {
                Console.Write("|");
                Console.Write(new string ('*', num - 2));
                Console.WriteLine("|");
            }
        }
    }
}
