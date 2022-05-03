using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            string fNum = first.ToString();
            string sNum = second.ToString();

            int f1 = Int32.Parse($"{fNum[0]}");
            int f2 = Int32.Parse($"{fNum[1]}");
            int f3 = Int32.Parse($"{fNum[2]}");
            int f4 = Int32.Parse($"{fNum[3]}");

            int s1 = Int32.Parse($"{sNum[0]}");
            int s2 = Int32.Parse($"{sNum[1]}");
            int s3 = Int32.Parse($"{sNum[2]}");
            int s4 = Int32.Parse($"{sNum[3]}");




            for (int i = f1; i <= s1; i++)
            {
                for (int j = f2; j <= s2; j++)
                {
                    for (int k = f3; k <= s3; k++)
                    {
                        for (int l = f4; l <= s4; l++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }


            //int name = 12345;
            
            //string nameToString = name.ToString();
            //int lenght = nameToString.Length;

            //Console.WriteLine(lenght);

            //int a = Int32.Parse($"{nameToString[2]}");
            //Console.WriteLine(a + 5);

        }
    }
}
