namespace _01.KaspichanNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public class KaspichanNumbers
    {
        public static void Main()
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            Stack<int> result = new Stack<int>();
            string strResult = string.Empty;
            DecimalTo256(input, result);
            foreach (int number in result)
            {
                if (number / 26 > 0)
                {
                    strResult += ((char)('a' + ((number / 26) - 1))).ToString();
                }

                strResult += ((char)('A' + (number % 26))).ToString();
            }

            Console.WriteLine(strResult);
        }

        private static void DecimalTo256(BigInteger number, Stack<int> resultNumbers)
        {
            if (number == 0)
            {
                resultNumbers.Push(0);
            }

            while (number > 0)
            {
                resultNumbers.Push((int)(number % 256));
                number /= 256;
            }
        }
    }
}

// C# Part 2 - 2012/2013 @ 4 Feb 2013 - Morning
// http://bgcoder.com/Contests/Practice/Index/52#0