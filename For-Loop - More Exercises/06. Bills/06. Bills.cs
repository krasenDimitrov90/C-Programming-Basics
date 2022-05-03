using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfMonths = int.Parse(Console.ReadLine());

            double waterBill = 20;
            double internetBill = 15;
            double otherBills = 0;

            double totalElectricityBill = 0;
            double totalWaterBill = 0;
            double totalInternetBill = 0;
            double totalOthersBill = 0;

            for (int i = 1; i <= countOfMonths; i++)
            {
                double electricityBill = double.Parse(Console.ReadLine());
                double sumElectricWaterInternet = 0;

                totalElectricityBill += electricityBill;
                totalWaterBill += waterBill;
                totalInternetBill += internetBill;
                sumElectricWaterInternet = electricityBill + waterBill + internetBill;
                totalOthersBill += sumElectricWaterInternet * 1.20;
            }
            double averageBills = (totalElectricityBill + totalWaterBill + totalInternetBill + totalOthersBill) / countOfMonths;

            Console.WriteLine($"Electricity: {totalElectricityBill:f2} lv");
            Console.WriteLine($"Water: {totalWaterBill:f2} lv");
            Console.WriteLine($"Internet: {totalInternetBill:f2} lv");
            Console.WriteLine($"Other: {totalOthersBill:f2} lv");
            Console.WriteLine($"Average: {averageBills:f2} lv");
        }
    }
}
