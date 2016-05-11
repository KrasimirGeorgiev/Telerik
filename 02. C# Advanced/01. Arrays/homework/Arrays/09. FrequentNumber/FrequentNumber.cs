namespace _09.FrequentNumber
{
    using System;
    using System.Linq;

    public class FrequentNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal[] arr = new decimal[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(FindMostFrequentNumber(arr));
        }

        private static decimal FindMostFrequentNumber(decimal[] arr)
        {
            //// arr = arr.OrderBy(x => x);
            int maxCount = 0;
            decimal maxNumber = 0M;
            int currentCount = 0;
            decimal currentMaxNumber = 0M;
            while (arr.Length > 0)
            {
                currentMaxNumber = arr[0];
                foreach (decimal number in arr)
                {
                    if (currentMaxNumber == number)
                    {
                        currentCount++;
                    }
                }

                if (maxCount < currentCount)
                {
                    maxCount = currentCount;
                    maxNumber = currentMaxNumber;
                }

                currentCount = 0;
                arr = arr.Where((val, idx) => val != currentMaxNumber).ToArray();
            }

            return maxNumber;
        }
    }
}

// Write a program that finds the most frequent number in an array of N elements.