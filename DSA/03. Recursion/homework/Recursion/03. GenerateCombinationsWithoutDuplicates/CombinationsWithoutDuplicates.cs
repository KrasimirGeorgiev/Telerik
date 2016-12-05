namespace _03.GenerateCombinationsWithoutDuplicates
{
    using System;
    using System.Text;

    public class CombinationsWithoutDuplicates
    {
        public static void Main()
        {
            var sb = new StringBuilder();
            var arr = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(GenerateCombinations(0, 0, arr.Length, 2, string.Empty, sb, arr));
        }

        private static StringBuilder GenerateCombinations(int index, int counter, int n, int k, string str, StringBuilder sb, int[] arr)
        {
            if (counter == k)
            {
                return sb.AppendLine(str);
            }

            for (int i = index; i < n; i++)
            {
                sb = GenerateCombinations(i + 1, counter + 1, n, k, str + " " + arr[i], sb, arr);
            }

            return sb;
        }
    }
}

// Modify the previous program to skip duplicates:
// n=4, k=2 → (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)