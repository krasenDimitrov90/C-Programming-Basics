using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int mounthsForDeposit = int.Parse(Console.ReadLine());
            double interestForYear = double.Parse(Console.ReadLine());

            double totalInterestForYear = deposit * (interestForYear / 100);
            double totalInterestForMonth = totalInterestForYear / 12;
            double totalInterest = mounthsForDeposit * totalInterestForMonth + deposit;
            Console.WriteLine(totalInterest);
        }
    }
}
