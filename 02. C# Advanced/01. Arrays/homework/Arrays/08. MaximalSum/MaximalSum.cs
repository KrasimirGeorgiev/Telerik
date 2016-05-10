namespace _08.MaximalSum
{
    using System;

    public class MaximalSum
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal[] arr = new decimal[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(MaximalSumOfConsecutiveElements(arr));
        }

        private static decimal MaximalSumOfConsecutiveElements(decimal[] arr)
        {
            decimal maxSum = decimal.MinValue;
            int startingIndex = 0;
            int endIndex = 0;
            decimal currentMaxSum = 0M;
            int currentStartingIndex = 0;
            int currentEndIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                currentStartingIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    currentMaxSum += arr[j];
                    currentEndIndex = j;
                    if (maxSum < currentMaxSum)
                    {
                        maxSum = currentMaxSum;
                        startingIndex = currentStartingIndex;
                        endIndex = currentEndIndex;
                    }
                }

                currentMaxSum = 0;
            }

            return maxSum;
        }
    }
}

// Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.