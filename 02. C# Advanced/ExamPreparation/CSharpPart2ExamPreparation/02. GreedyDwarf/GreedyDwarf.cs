namespace _02.GreedyDwarf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GreedyDwarf
    {
        public static void Main()
        {
            int[] valley = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int valleyLength = valley.Length;
            int n = int.Parse(Console.ReadLine());
            int maxSum = int.MinValue;
            int currentSum = valley[0];
            HashSet<int> indexes = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int[] currentPattern = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentPatternLength = currentPattern.Length;
                int currentValleyIndex = 0;
                int currentPatternIndex = 0;
                indexes.Add(0);
                while (true)
                {
                    if (currentValleyIndex + currentPattern[currentPatternIndex] < 0 || currentValleyIndex + currentPattern[currentPatternIndex] >= valleyLength || indexes.Contains(currentValleyIndex + currentPattern[currentPatternIndex]))
                    {
                        break;
                    }

                    currentValleyIndex = currentValleyIndex + currentPattern[currentPatternIndex];
                    indexes.Add(currentValleyIndex);
                    currentSum += valley[currentValleyIndex];
                    currentPatternIndex = (currentPatternIndex + 1) % currentPatternLength;
                }

                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                }

                currentSum = valley[0];
                indexes.Clear();
            }

            Console.WriteLine(maxSum);
        }
    }
}

// C# Part 2 - 2012/2013 @ 4 Feb 2013 - Morning
// http://bgcoder.com/Contests/Practice/Index/52#1