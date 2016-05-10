namespace _04.MaximalSequence
{
    using System;

    public class MaximalSequence
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(FindLengthOfMaximalSequenceInArr(arr));
        }

        private static int FindLengthOfMaximalSequenceInArr(int[] arr)
        {
            if (arr.Length < 1)
            {
                return -1;
            }

            int maxElement = arr[0];
            int maxCount = 1;
            int currentElement = arr[0];
            int currentCount = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                if (currentNumber == currentElement)
                {
                    currentCount++;
                }

                if (currentNumber != currentElement || i == arr.Length - 1)
                {
                    if (maxCount < currentCount)
                    {
                        maxCount = currentCount;
                        maxElement = currentElement;
                    }

                    currentElement = currentNumber;
                    currentCount = 1;
                }
            }

            return maxCount;
        }
    }
}

// Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.