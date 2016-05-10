namespace _05.MaximalIncreasingSequence
{
    using System;

    public class MaximalIncreasingSequence
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(FindLengthOfMaximalIncreasingSequence(arr));
        }

        private static int FindLengthOfMaximalIncreasingSequence(int[] arr)
        {
            if (arr.Length < 1)
            {
                return -1;
            }

            int maxCount = 1;
            int currentCount = 1;
            int currentElement = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                if (currentNumber > currentElement)
                {
                    currentCount++;
                }

                if (currentNumber <= currentElement || i == arr.Length - 1)
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }

                    currentElement = currentNumber;
                    currentCount = 1;
                }

                currentElement = currentNumber;
            }

            return maxCount;
        }
    }
}

// Write a program that finds the length of the maximal increasing sequence in an array of N integers.