namespace _05.FindBits
{
    using System;

    public class FindBits
    {
        public static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            string key = Convert.ToString(s, 2);
            key = FormatBinaryNumberBits(5, key);
            int n = int.Parse(Console.ReadLine());
            ulong finalCount = 0;
            for (int i = 0; i < n; i++)
            {
                ulong currentNumber = ulong.Parse(Console.ReadLine());
                string currentNumberToBinary = Convert.ToString((long)currentNumber, 2);
                currentNumberToBinary = FormatBinaryNumberBits(29, currentNumberToBinary);
                finalCount += CountStringInBinaryNumber(key, currentNumberToBinary);
            }

            Console.WriteLine(finalCount);
        }

        private static string FormatBinaryNumberBits(int bits, string str)
        {
            string result = string.Empty;
            if (str.Length == bits)
            {
                result = str;
            }
            else if (str.Length < bits)
            {
                result = str.PadLeft(bits, '0');
            }
            else
            {
                result = str.Substring(str.Length - bits);
            }

            return result;
        }

        private static ulong CountStringInBinaryNumber(string key, string str)
        {
            ulong count = 0;
            int possition = 0;
            while (possition != -1)
            {
                possition = str.IndexOf(key, possition);
                if (possition != -1)
                {
                    count++;
                }
                else
                {
                    break;
                }

                if (possition + 1 < str.Length)
                {
                    possition++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}

// Telerik Academy Exam 1 @ 3 February 2015 Evening
// http://bgcoder.com/Contests/Practice/Index/205#4