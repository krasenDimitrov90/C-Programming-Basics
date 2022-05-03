using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int max = Int32.MinValue;


            while (num != "Stop")
            {
                int increase = int.Parse(num);
                if (max < increase)
                {
                    max = increase;
                }

                num = Console.ReadLine();

            }
            Console.WriteLine(max);
        }
    }
}
