using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            //Събиране(+), Изваждане(-), Умножение(*), Деление(/) и Модулно деление(%).
            if (N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
                return;
            }

            double sum = 0;
            if (operation == '+' || operation == '-' || operation == '*')
            {
                if (operation == '+')
                {
                    sum = N1 + N2;
                    
                }
                else if (operation == '-')
                {
                    sum = N1 - N2;
                }
                else
                {
                    sum = N1 * N2;
                }
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {sum} - odd");
                }
            }
            else if (operation == '/')
            {
                sum = 1.00 * N1 / N2;
                Console.WriteLine($"{N1} / {N2} = {sum:f2}");
            }
            else if (operation == '%')
            {
                sum = N1 % N2;
                Console.WriteLine($"{N1} % {N2} = {sum}");
            }
            
        }
    }
}
