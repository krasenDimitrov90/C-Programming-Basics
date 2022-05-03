using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabCaount = int.Parse(Console.ReadLine());//брой отворени табове в браузъра
            int selary = int.Parse(Console.ReadLine());

            //•	"Facebook"-> 150 лв.
            //•	"Instagram"-> 100 лв.
            //•	"Reddit"-> 50 лв.

            string site = "";// име на сайта
            int counter = 0;
            for (int i = 1; i <= tabCaount && selary > 0; i++)
            {

                counter++;
                site = Console.ReadLine();
                if (site == "Facebook")
                {
                    selary -= 150;
                }
                else if (site == "Instagram")
                {
                    selary -= 100;
                }
                else if (site == "Reddit")
                {
                    selary -= 50;
                }
            }     
            if (selary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(selary);
            }

        }
    }
}
