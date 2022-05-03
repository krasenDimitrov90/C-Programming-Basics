using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int intendedHeight = int.Parse(Console.ReadLine());

            int unsuccesCounter = 0;
            int jumpsCounter = 0;
            int startJumpHeiht = intendedHeight - 30;
            
            while (startJumpHeiht <= intendedHeight)
            {
                int jumpHeight = int.Parse(Console.ReadLine());
                jumpsCounter++;
                
                if (jumpHeight > startJumpHeiht)
                {
                    startJumpHeiht += 5;
                    unsuccesCounter = 0;
                    if (startJumpHeiht > intendedHeight)
                    {
                        Console.WriteLine($"Tihomir succeeded, he jumped over {intendedHeight}cm after {jumpsCounter} jumps.");
                        return;
                    }
                }
                else
                {
                    unsuccesCounter++;
                    if (unsuccesCounter == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {startJumpHeiht}cm after {jumpsCounter} jumps.");
                        return;
                    }
                }
            }
        }
    }
}
