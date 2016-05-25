namespace _02.IncreasingAbsoluteDifferences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IncreasingAbsoluteDifferences
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<long> currentList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
                List<long> absoluteDiffList = FindAbsoluteDifferenceSeq(currentList).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
                bool isLegit = true;
                for (int j = 1; j < absoluteDiffList.Count; j++)
                {
                    long firstNumber = absoluteDiffList[j - 1];
                    long secondNumber = absoluteDiffList[j];
                    if (firstNumber > secondNumber || Math.Abs(firstNumber - secondNumber) > 1)
                    {
                        isLegit = false;
                        break;
                    }
                }

                Console.WriteLine(isLegit ? "True" : "False");
            }
        }

        private static string FindAbsoluteDifferenceSeq(List<long> list)
        {
            string result = string.Empty;
            for (int i = 1; i < list.Count; i++)
            {
                long firstNumber = list[i - 1];
                long secondNumber = list[i];
                result += Math.Abs(firstNumber - secondNumber).ToString();
                if (i != list.Count - 1)
                {
                    result += " ";
                }
            }

            return result;
        }
    }
}

// C# Part 2 - 2015/2016 @ 6 March 2015 - Evening
// http://bgcoder.com/Contests/Practice/Index/223#1