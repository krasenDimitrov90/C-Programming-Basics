using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            // 80 ot 100 tochki postignat rezultat

            int ageLily = int.Parse(Console.ReadLine());
            double priceWashing = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            //за всеки четен рожден ден получава пари които се увеличават с 10лв всеки път
            //за всеки четен рожден ден и се отнема по 1 лв
            //за всеки нечетен рожден ден получава играчки 

            int countToy = 0;//брой играчи
            int birthdayMoney = 0;//пари за рождените дни
            int raise = 0;

            for (int i = 1; i <= ageLily; i++)
            {
                if (i % 2 == 0)
                {
                    raise = raise + 10;
                    birthdayMoney = birthdayMoney + raise - 1 ;
                }
                else
                {
                    countToy++;
                }
            }

            int moneyFromToy = countToy * priceToy;
            double totalMoney = 1.0 * moneyFromToy + birthdayMoney;

            if (totalMoney >= priceWashing)
            {
                Console.WriteLine($"Yes! {totalMoney - priceWashing:f2}");
            }
            else
            {
                double diff = priceWashing - totalMoney;
                Console.WriteLine($"No! {diff:f2}");
            }



            
        }
    }
}
