using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            char a = number[2];
            char b = number[1];
            char c = number[0];

            int n1 = (int)Char.GetNumericValue(a);
            int n2 = (int)Char.GetNumericValue(b);
            int n3 = (int)Char.GetNumericValue(c);

            for (int i = 1; i <= n1; i++)
            {
                for (int j = 1; j <= n2; j++)
                {
                    for (int k = 1; k <= n3; k++)
                    {
                        int sum = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {sum};");
                    }
                }
            }

            
        }
    }
}
