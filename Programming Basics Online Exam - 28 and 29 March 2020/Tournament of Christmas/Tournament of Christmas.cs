using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double totalprice = 0;

            int winDayCounter = 0;
            int loseDayCounter = 0;

            for (int i = 0; i < days; i++)
            {
                int winCounter = 0;
                int loseCounter = 0;
                string sportName = "";
                double price = 0;
                while (sportName != "Finish")
                {
                    double sportPrize = 0;
                    string status = "";// win or lose
                    sportName = Console.ReadLine();

                    if (sportName != "Finish")
                    {
                        status = Console.ReadLine();
                        if (status == "win")
                        {
                            winCounter++;
                            sportPrize = 20;
                        }
                        else if (status == "lose")
                        {
                            loseCounter++;

                        }
                        price += sportPrize;
                    }
                }
                totalprice += price;
                if (winCounter > loseCounter)
                {
                    winDayCounter++;
                    totalprice += price * 0.10;
                }
                else if (winCounter < loseCounter)
                {
                    loseDayCounter++;
                }
            }

            if (winDayCounter > loseDayCounter)
            {
                totalprice += totalprice * 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalprice:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalprice:f2}");
            }
        }
    }
}
