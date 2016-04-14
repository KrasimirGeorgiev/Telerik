namespace _02.NightmareOnCodeStreet
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NightmareOnCodeStreet
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int inputLength = input.Length;
            int count = 0;
            BigInteger result = 0;
            for (int i = 1; i < inputLength; i+=2)
            {
                char currentSymbol = input[i];
                if (char.IsDigit(currentSymbol))
                {
                    count++;
                    result += currentSymbol - '0';
                }
            }

            Console.WriteLine("{0} {1}", count, result);
        }
    }
}

// Telerik Academy Exam 1 @ 6 December 2013 Evening
// http://bgcoder.com/Contests/Practice/Index/107#1