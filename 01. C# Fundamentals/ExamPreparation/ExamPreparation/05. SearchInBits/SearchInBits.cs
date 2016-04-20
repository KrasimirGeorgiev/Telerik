namespace _05.SearchInBits
{
    using System;

    public class SearchInBits
    {
        public static void Main()
        {
            ulong countOccurrences = 0;
            int s = int.Parse(Console.ReadLine());
            string key = Key(s);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                ulong currentNumber = ulong.Parse(Console.ReadLine());
                string currentNumberToBinary = Convert.ToString((long)currentNumber, 2);
                currentNumberToBinary = FormatBinaryNumber30Bits(currentNumberToBinary);
                countOccurrences += CountOccurrences(key, currentNumberToBinary);
            }

            Console.WriteLine(countOccurrences);
        }

        private static ulong CountOccurrences(string key, string binaryNumber)
        {
            ulong count = 0;
            int index = 0;
            while (index != -1)
            {
                index = binaryNumber.IndexOf(key, index);
                if (index != -1)
                {
                    count++;
                }
                else
                {
                    break;
                }

                if (index + 1 < binaryNumber.Length)
                {
                    index++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }

        private static string Key(int n)
        {
            string result = string.Empty;
            string numberToBinary = Convert.ToString(n, 2);
            if (numberToBinary.Length == 4)
            {
                result = numberToBinary;
            }
            else if (numberToBinary.Length < 4)
            {
                result = numberToBinary.PadLeft(4, '0');
            }
            else
            {
                result = numberToBinary.Substring(numberToBinary.Length - 4);
            }

            return result;
        }

        private static string FormatBinaryNumber30Bits(string binaryNumber)
        {
            string result = string.Empty;
            if (binaryNumber.Length == 30)
            {
                result = binaryNumber;
            }
            else if (binaryNumber.Length < 30)
            {
                result = binaryNumber.PadLeft(30, '0');
            }
            else
            {
                result = binaryNumber.Substring(binaryNumber.Length - 30);
            }

            return result;
        }
    }
}

// Telerik Academy Exam 1 @ 3 February 2015 Morning
// http://bgcoder.com/Contests/Practice/Index/204#4