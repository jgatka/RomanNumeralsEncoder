using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabicToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            int ArabicNumeral = 0;
            while (ArabicNumeral < 1)
            {
                Console.WriteLine("Enter an integer > 0");
                ArabicNumeral = Convert.ToInt32(Console.ReadLine());
                if (ArabicNumeral > 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid selection!");
                }
            }
            string Answer = Solution(ArabicNumeral);
            Console.WriteLine("Arabic Numeral: {0}", ArabicNumeral);
            Console.WriteLine("Expressed as Roman Numeral: {0}", Answer);
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }        

            public static string Solution(int n)
            {
            int NumBeforeConvert = n;
            int WorkingTotal = n;
            string RomanString = "";

            while (WorkingTotal > 0)
            {
                while (WorkingTotal >= 1000)
                {
                    RomanString += "M";
                    WorkingTotal -= 1000;
                }
                while (WorkingTotal >= 500 && WorkingTotal < 1000)
                {
                    if (WorkingTotal >= 900)
                    {
                        RomanString += "CM";
                        WorkingTotal -= 900;
                    }
                    else if (WorkingTotal >= 800 && WorkingTotal < 900)
                    {
                        RomanString += "DCCC";
                        WorkingTotal -= 800;
                    }
                    else if (WorkingTotal >= 700 && WorkingTotal < 800)
                    {
                        RomanString += "DCC";
                        WorkingTotal -= 700;
                    }
                    else if (WorkingTotal >= 600 && WorkingTotal < 700)
                    {
                        RomanString += "DC";
                        WorkingTotal -= 600;
                    }
                    else
                    {
                        RomanString += "D";
                        WorkingTotal -= 500;
                    }
                }
                while (WorkingTotal >= 100 && WorkingTotal < 500)
                {
                    if (WorkingTotal >= 400)
                    {
                        RomanString += "CD";
                        WorkingTotal -= 400;
                    }
                    else if (WorkingTotal >= 300 && WorkingTotal < 400)
                    {
                        RomanString += "CCC";
                        WorkingTotal -= 300;
                    }
                    else if (WorkingTotal >= 200 && WorkingTotal < 300)
                    {
                        RomanString += "CC";
                        WorkingTotal -= 200;
                    }
                    else
                    {
                        RomanString += "C";
                        WorkingTotal -= 100;
                    }
                }
                while (WorkingTotal >= 50 && WorkingTotal < 100)
                {
                    if (WorkingTotal >= 90 && WorkingTotal < 100)
                    {
                        RomanString += "XC";
                        WorkingTotal -= 90;
                    }
                    else if (WorkingTotal >= 80 && WorkingTotal < 90)
                    {
                        RomanString += "LXXX";
                        WorkingTotal -= 80;
                    }
                    else if (WorkingTotal >= 70 && WorkingTotal < 80)
                    {
                        RomanString += "LXX";
                        WorkingTotal -= 70;
                    }
                    else if (WorkingTotal >= 60 && WorkingTotal < 70)
                    {
                        RomanString += "LX";
                        WorkingTotal -= 60;
                    }
                    else
                    {
                        RomanString += "L";
                        WorkingTotal -= 50;
                    }
                }
                while (WorkingTotal >= 10 && WorkingTotal < 50)
                {
                    if (WorkingTotal >= 40 && WorkingTotal < 50)
                    {
                        RomanString += "XL";
                        WorkingTotal -= 40;
                    }
                    else if (WorkingTotal >= 30 && WorkingTotal < 40)
                    {
                        RomanString += "XXX";
                        WorkingTotal -= 30;
                    }
                    else if (WorkingTotal >= 20 && WorkingTotal < 30)
                    {
                        RomanString += "XX";
                        WorkingTotal -= 20;
                    }
                    else
                    {
                        RomanString += "X";
                        WorkingTotal -= 10;
                    }
                    
                }
                while (WorkingTotal >= 5 && WorkingTotal < 10)
                {
                    if (WorkingTotal == 9)
                    {
                        RomanString += "IX";
                        WorkingTotal -= 9;
                    }
                    else if (WorkingTotal == 8)
                    {
                        RomanString += "VIII";
                        WorkingTotal -= 8;
                    }
                    else if (WorkingTotal == 7)
                    {
                        RomanString += "VII";
                        WorkingTotal -= 7;
                    }
                    else if (WorkingTotal == 6)
                    {
                        RomanString += "VI";
                        WorkingTotal -= 6;
                    }
                    else
                    {
                        RomanString += "V";
                        WorkingTotal -= 5;
                    }
                }
                while (WorkingTotal >= 1 && WorkingTotal < 5)
                {
                    if (WorkingTotal == 4)
                    {
                        RomanString += "IV";
                        WorkingTotal -= 4;
                    }
                    else if (WorkingTotal == 3)
                    {
                        RomanString += "III";
                        WorkingTotal -= 3;
                    }
                    else if (WorkingTotal == 2)
                    {
                        RomanString += "II";
                        WorkingTotal -= 2;
                    }
                    else
                    {
                        RomanString += "I";
                        WorkingTotal -= 1;
                    }
                }
            }
            return RomanString;
        }
    }
}
