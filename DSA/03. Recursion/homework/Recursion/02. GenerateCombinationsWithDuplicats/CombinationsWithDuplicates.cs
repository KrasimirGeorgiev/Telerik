namespace _02.GenerateCombinationsWithDuplicats
{
    using System;
    using System.Text;

    public class CombinationsWithDuplicates
    {
        public static void Main()
        {
            var sb = new StringBuilder();
            var arr = new int[] { 1, 2, 3 };
            Console.WriteLine(GenerateCombinations(0, arr.Length, 2, string.Empty, sb, arr));
        }

        private static StringBuilder GenerateCombinations(int counter, int n, int k, string str, StringBuilder sb, int[] arr)
        {
            if (counter == k)
            {
                return sb.AppendLine(str);
            }

            for (int i = 0; i < n; i++)
            {
                sb = GenerateCombinations(counter + 1, n, k, str + " " + arr[i], sb, arr);
            }

            return sb;
        }
    }
}

// Write a recursive program for generating and printing all the combinations with duplicatesof k elements from n-element set.
// Example:
// n = 3, k= 2 → (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)