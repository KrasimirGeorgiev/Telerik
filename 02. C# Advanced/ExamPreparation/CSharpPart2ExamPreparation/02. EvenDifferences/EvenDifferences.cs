namespace _02.EvenDifferences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EvenDifferences
    {
        public static void Main()
        {
            List<long> inputNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            long sum = 0L;
            for (int i = 1; i < inputNumbers.Count; i++)
            {
                long currentAbsoluteNumber = Math.Max(inputNumbers[i - 1], inputNumbers[i]) - Math.Min(inputNumbers[i - 1], inputNumbers[i]);

                if (currentAbsoluteNumber % 2 == 0)
                {
                    sum += currentAbsoluteNumber;
                    i++;
                }
            }

            Console.WriteLine(sum);
        }
    }
}

// C# Part 2 - 2015/2016 @ 5 March 2015 - Evening
// http://bgcoder.com/Contests/Practice/Index/221#1