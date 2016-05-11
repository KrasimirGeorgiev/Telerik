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
            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            for (int i = n - 1; i >= n - k; i--)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);
        }
    }
}

// Write a program that reads two integer numbers N and K and an array of N elements from the console. Find the maximal sum of K elements in the array.