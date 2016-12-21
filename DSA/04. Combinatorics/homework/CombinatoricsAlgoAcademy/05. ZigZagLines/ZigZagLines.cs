namespace _05.ZigZagLines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ZigZagLines
    {
        static int result = 0;

        public static void Main()
        {
            int[] instructions = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            if (instructions[1] == 1)
            {
                Console.WriteLine(instructions[0]);
            }
            else
            {
                int[] elements = new int[instructions[0]];
                SetElements(elements);
                var arr = GetPermutations(elements, instructions[1]);
                Console.WriteLine(result);
            }
        }

        private static void SetElements(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                arr[i] = i;
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            if (a == b)
            {
                return;
            }

            a ^= b;
            b ^= a;
            a ^= b;
        }

        private static List<string> GetPermutations(int[] arr, int sets)
        {
            int len = arr.Length - 1;
            List<string> permutations = new List<string>();
            GeneratePermutations(arr, 0, 0, sets, len, permutations);

            return permutations;
        }

        private static void GeneratePermutations(int[] arr, int k, int count, int sets, int n, List<string> permutations)
        {
            if (count == sets)
            {
                result = PrintIfGood(arr, count, k) ? result + 1 : result;
                return;
            }

            for (int i = k; i <= n; i++)
            {
                Swap(ref arr[k], ref arr[i]);
                GeneratePermutations(arr, k + 1, count + 1, sets, n, permutations);
                Swap(ref arr[k], ref arr[i]);
            }
        }

        private static bool PrintIfGood(int[] arr, int count, int k)
        {
            int counter = 0;
            for (int i = (k - count) + 1; i < count; i++)
            {
                if (counter % 2 == 0)
                {
                    if (arr[i] > arr[i - 1])
                    {
                        return false;
                    }
                }
                if (counter % 2 != 0)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        return false;
                    }
                }

                counter++;
            }

            return true;
        }
    }
}
