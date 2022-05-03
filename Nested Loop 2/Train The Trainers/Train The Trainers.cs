using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judgeCount = int.Parse(Console.ReadLine());

            string presentationName = Console.ReadLine();
            double finalGrade = 0;
            int counter = 0;

            while (presentationName != "Finish")
            {
                double sumOfGrades = 0;
                for (int i = 0; i < judgeCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades += grade;
                }
                counter++;
                finalGrade += (sumOfGrades / judgeCount);
                Console.WriteLine($"{presentationName} - {sumOfGrades / judgeCount:f2}.");
                presentationName = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {finalGrade /= counter:f2}.");
        }
    }
}
