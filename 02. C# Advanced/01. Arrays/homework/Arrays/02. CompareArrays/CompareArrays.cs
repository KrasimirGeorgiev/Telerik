namespace _02.CompareArrays
{
    using System;

    public class CompareArrays
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = NumbersToArray(n);
            int[] secondArr = NumbersToArray(n);
            Console.WriteLine(CompareTwoArrays(n, firstArr, secondArr));
        }

        private static int[] NumbersToArray(int n)
        {
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        private static string CompareTwoArrays(int length, int[] firstArr, int[] secondArr)
        {
            string result = string.Empty;
            for (int i = 0; i < length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    return "Not equal";
                }
            }

            return "Equal";
        }
    }
}

/// Write a program that reads two integer arrays of size N from the console and compares them element by element.