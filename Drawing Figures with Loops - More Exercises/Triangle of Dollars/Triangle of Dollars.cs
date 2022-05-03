using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            char a = '$';

            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                   Console.Write(a + " ");
                }
                Console.WriteLine();
            }

            
        }
    }
}
