namespace _03.Deviders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Deviders
    {
        public static void Main()
        {
            short n = short.Parse(Console.ReadLine());
            char[] elements = new char[n];

            AddElements(n, elements);

            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();

            var collection = GetPermutations(elements);
            foreach (var element in collection)
            {
                int elementToNum = int.Parse(element);
                int number = GetFactors1(elementToNum);
                if (dic.ContainsKey(number))
                {
                    dic[number].Add(elementToNum);
                }
                else
                {
                    dic.Add(number, new List<int>());
                    dic[number].Add(elementToNum);
                }
            }

            int minKey = dic.Keys.Min();
            if (dic[minKey].Count == 1)
            {
                Console.WriteLine(dic[minKey][0]);
            }
            else
            {
                Console.WriteLine(dic[minKey].Min());
            }
        }

        private static int GetFactors1(int x)
        {
            int max = (int)Math.Ceiling(Math.Sqrt(x));
            int counter = 0;
            for (int factor = 1; factor < max; factor++)
            {
                if (x % factor == 0)
                {
                    //yield return factor;
                    counter++;
                    if (factor != max)
                    {
                        counter++;//yield return x / factor;
                    }
                }
            }

            return counter;
        }

        private static void AddElements(short n, char[] arr)
        {
            for (short i = 0; i < n; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b)
            {
                return;
            }

            a ^= b;
            b ^= a;
            a ^= b;
        }

        private static List<string> GetPermutations(char[] arr)
        {
            int len = arr.Length - 1;
            List<string> permutations = new List<string>();
            GeneratePermutations(arr, 0, len, permutations);

            return permutations;
        }

        private static void GeneratePermutations(char[] arr, int k, int n, List<string> permutations)
        {
            if (k == n)
            {
                permutations.Add(string.Join("", arr));
                return;
            }

            for (int i = k; i <= n; i++)
            {
                Swap(ref arr[k], ref arr[i]);
                GeneratePermutations(arr, k + 1, n, permutations);
                Swap(ref arr[k], ref arr[i]);
            }
        }
    }
}
