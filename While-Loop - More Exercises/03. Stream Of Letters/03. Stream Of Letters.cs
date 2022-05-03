using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string wholeText = "";
            string text = "";
            int counterC = 0;
            int counterO = 0;
            int counterN = 0;
            string comand = "";

            // три букви – "c", "o" и "n".
            string secretMassege = Console.ReadLine();

            while (secretMassege != "End")
            {
                char symbol = char.Parse(secretMassege);
                
                if ((symbol >= 'a' && symbol <= 'z') || (symbol >= 'A' && symbol <= 'Z'))
                {
                    if (symbol == 'c' || symbol == 'o' || symbol == 'n')
                    {
                        if (symbol == 'c')
                        {
                            counterC++;
                            if (counterC > 1)
                            {
                                text += symbol;
                            }
                            else
                            {
                                comand += symbol;
                            }
                        }
                        if (symbol == 'o')
                        {
                            counterO++;
                            if (counterO > 1)
                            {
                                text += symbol;
                            }
                            else
                            {
                                comand += symbol;
                            }
                        }
                        if (symbol == 'n')
                        {
                            counterN++;
                            if (counterN > 1)
                            {
                                text += symbol;
                            }
                            else
                            {
                                comand += symbol;
                            }
                        }
                    }
                    else
                    {
                        text += symbol;
                    }
                    if (comand == "con" || comand == "cno" || comand == "ocn" || comand == "onc"
                        || comand == "nco" || comand == "noc")
                    {
                        counterC = 0;
                        counterN = 0;
                        counterO = 0;
                        wholeText += text + " ";
                        text = "";
                        comand = "";
                    }
                }
                secretMassege = Console.ReadLine();

            }

            Console.WriteLine(wholeText);
            
        }
    }
}
