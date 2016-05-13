namespace _13.MergeSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSort
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] workingArr = new int[n];
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            TopDownMergeSort(a, workingArr, n);
            Console.WriteLine(string.Join(", ", a));
        }

        private static void TopDownMergeSort(int[] a, int[] b, int n)
        {
            TopDownSplitMerge(a, 0, n, b);
        }

        private static void TopDownSplitMerge(int[] a, int start, int end, int[] b)
        {
            if (end - start < 2)
            {
                return;
            }

            int middle = (end + start) / 2;
            TopDownSplitMerge(a, start, middle, b);
            TopDownSplitMerge(a, middle, end, b);
            TopDownMerge(a, start, middle, end, b);
            CopyArray(a, b, start, end);
        }

        private static void TopDownMerge(int[] a, int start, int middle, int end, int[] b)
        {
            int i = start;
            int j = middle;
            for (int k = start; k < end; k++)
            {
                if (i < middle && (j >= end || a[i] <= a[j]))
                {
                    b[k] = a[i];
                    i++;
                }
                else
                {
                    b[k] = a[j];
                    j++;
                }
            }
        }

        private static void CopyArray(int[] a, int[] b, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                a[i] = b[i];
            }
        }
    }
}

// Write a program that sorts an array of integers using the Merge sort algorithm.