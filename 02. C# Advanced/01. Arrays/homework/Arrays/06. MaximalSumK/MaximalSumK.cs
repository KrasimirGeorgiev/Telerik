namespace _06.MaximalSumK
{
    using System;
    using System.Linq;

    public class MaximalSumK
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            decimal[] arr = new decimal[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(FindMaximalSumK(arr, k));
        }

        private static decimal FindMaximalSumK(decimal[] arr, int k)
        {
            decimal[] array = arr;
            decimal sum = 0M;
            for (int i = 0; i < k; i++)
            {
                decimal currentMax = array.Max();
                sum += currentMax;
                int index = Array.IndexOf(array, currentMax);
                array = array.Where((ent, idx) => idx != index).ToArray();
            }

            return sum;
        }
    }
}

// Write a program that reads two integer numbers N and K and an array of N elements from the console. Find the maximal sum of K elements in the array.