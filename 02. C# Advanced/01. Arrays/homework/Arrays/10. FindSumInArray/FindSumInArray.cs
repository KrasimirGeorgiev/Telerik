namespace _10.FindSumInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindSumInArray
    {
        private static int numberSum;
        private static List<int> numbers;
        private static bool thereIsResult;

        public static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            numberSum = sum;
            numbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> subset = new List<int>();
            CalculateSubset(0, subset);
            if (!thereIsResult)
            {
                Console.WriteLine("No matching subsets.");
            }
        }
        
        private static void CalculateSubset(int startingIndex, List<int> numbersForSum)
        {
            if (numbersForSum.Count > 0 && numbersForSum.Sum() == numberSum)
            {
                Console.WriteLine(string.Join(", ", numbersForSum));
                thereIsResult = true;
            }

            for (int index = startingIndex; index < numbers.Count - 1; index++)
            {
                numbersForSum.Add(numbers[index]);
                CalculateSubset(index + 1, numbersForSum);
                numbersForSum.RemoveAt(numbersForSum.Count - 1);
            }
        }
    }
}

// Write a program that finds in given array of integers a sequence of given sum S (if present).