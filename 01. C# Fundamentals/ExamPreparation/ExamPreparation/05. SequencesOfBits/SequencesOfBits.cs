namespace _05.SequencesOfBits
{
    using System;

    public class SequencesOfBits
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                ulong currentNumber = ulong.Parse(Console.ReadLine());
                string currentNumberToBinary = Convert.ToString((long)currentNumber, 2);
                result += GetLast30Bits(currentNumberToBinary);
            }

            Console.WriteLine(CountSymbolSequenceInString('1', result));
            Console.WriteLine(CountSymbolSequenceInString('0', result));
        }

        private static string GetLast30Bits(string str)
        {
            string result = string.Empty;
            if (str.Length < 30)
            {
                result = str.PadLeft(30, '0');
            }
            else if (str.Length == 30)
            {
                result = str;
            }
            else
            {
                result = str.Substring(str.Length - 30, 30);
            }

            return result;
        }

        private static long CountSymbolSequenceInString(char ch, string str)
        {
            long maxCount = 0;
            long currentCount = 0;
            foreach (char symbol in str)
            {
                if (symbol == ch)
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 0;
                }

                maxCount = maxCount < currentCount ? currentCount : maxCount;
            }

            return maxCount;
        }
    }
}

// Telerik Academy Exam 1 @ 2 February 2015 Evening
// http://bgcoder.com/Contests/Practice/Index/203#4