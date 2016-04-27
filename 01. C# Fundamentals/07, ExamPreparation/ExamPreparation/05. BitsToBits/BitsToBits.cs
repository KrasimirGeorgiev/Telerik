namespace _05.BitsToBits
{
    using System;

    public class BitsToBits
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                ulong currentNumber = ulong.Parse(Console.ReadLine());
                string currentNumberToBinary = Convert.ToString((long)currentNumber, 2);
                int numberToBinaryLength = currentNumberToBinary.Length;
                if (numberToBinaryLength == 30)
                {
                    result += currentNumberToBinary;
                }
                else if (numberToBinaryLength > 30)
                {
                    result += currentNumberToBinary.Substring(numberToBinaryLength - 31);
                }
                else
                {
                    result += currentNumberToBinary.PadLeft(30, '0');
                }
            }

            Console.WriteLine(FindLongestCharSequenceInString(result, '0'));
            Console.WriteLine(FindLongestCharSequenceInString(result, '1'));
        }

        private static ulong FindLongestCharSequenceInString(string str, char symbolForSearch)
        {
            ulong maxCount = 0;
            ulong currentCount = 0;
            foreach (char symbol in str)
            {
                if (symbol == symbolForSearch)
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

// Telerik Academy Exam 1 @ 2 February 2015 Morning
// http://bgcoder.com/Contests/Practice/Index/202#4