using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hair_Salon
{
    class Program
    {
        static void Main(string[] args)
        {
            int desireIncome = int.Parse(Console.ReadLine());
            int procedurePrice = 0;
            
            int incomeToTheMoment = 0;
            string procedure = Console.ReadLine();

            while (procedure != "closed")
            {
                if (procedure == "haircut")
                {
                    string haircut = Console.ReadLine();
                    switch (haircut)
                    {
                        case "mens":
                            procedurePrice = 15;
                            break;
                        case "ladies":
                            procedurePrice = 20;
                            break;
                        case "kids":
                            procedurePrice = 10;
                            break;
                    }
                }
                else if (procedure == "color")
                {
                    string colorType = Console.ReadLine();
                    switch (colorType)
                    {
                        case "touch up":
                            procedurePrice = 20;
                            break;
                        case "full color":
                            procedurePrice = 30;
                            break;
                    }
                }
                
                
                incomeToTheMoment += procedurePrice;
                if (incomeToTheMoment >= desireIncome)
                {
                    break;
                }

                procedure = Console.ReadLine();
            }
            if (incomeToTheMoment >= desireIncome)
            {
                Console.WriteLine("You have reached your target for the day!") ;
            }
            else
            {
                Console.WriteLine($"Target not reached! You need {desireIncome - incomeToTheMoment}lv. more.");
            }
            Console.WriteLine($"Earned money: {incomeToTheMoment}lv.");
        }
    }
}
