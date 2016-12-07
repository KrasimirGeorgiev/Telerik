namespace _04.GeneratePermutations
{
    using System;

    public class GeneratePermutations
    {
        private static int[] arr = new int[] { 1, 2, 3 };

        public static void Main()
        {
            GeneratePermutationsUsingHeap(3, arr);
        }

        private static void GeneratePermutationsUsingHeap(int n, int[] arr)
        {
            if (n == 1)
            {
                Console.WriteLine(string.Join(", ", arr));
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    GeneratePermutationsUsingHeap(n - 1, arr);
                    if (n % 2 == 0)
                    {
                        int temp = arr[i];
                        arr[i] = arr[n - 1];
                        arr[n - 1] = temp;
                    }
                    else
                    {
                        int temp = arr[0];
                        arr[0] = arr[n - 1];
                        arr[n - 1] = temp;
                    }
                }

                GeneratePermutationsUsingHeap(n - 1, arr);
            }
        }
    }
}

// Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for given integer number n.Example:
// n= 3 → { 1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}