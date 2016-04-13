namespace _02.SymbolToNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SymbolToNumber
    {
        public static void Main()
        {
            int secret = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int strLength = str.Length;

            for (int i = 0; i < strLength - 1; i++)
            {
                char currentChar = str[i];
                decimal result = 0;

                if (char.IsLetter(currentChar))
                {
                    result = (currentChar * secret) + 1000M;
                }
                else if (char.IsDigit(currentChar))
                {
                    result = currentChar + (decimal)secret + 500M;
                }
                else
                {
                    result = currentChar - (decimal)secret;
                }

                if (i % 2 == 0)
                {
                    result /= 100;
                    Console.WriteLine("{0:F2}", result);
                }
                else
                {
                    result *= 100;
                    Console.WriteLine(result);
                }
            }
        }
    }
}

// Telerik Academy Exam 1 @ 3 February 2015 Evening
// http://bgcoder.com/Contests/Practice/Index/205#1