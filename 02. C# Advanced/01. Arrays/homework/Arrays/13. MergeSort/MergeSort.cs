namespace _13.MergeSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSort
    {
        public static int[] A;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] workingArr = new int[n];
            A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            TopDownMergeSort(workingArr, n);
            Console.WriteLine(string.Join(", ", A));
        }

        private static void TopDownMergeSort(int[] b, int n)
        {
            TopDownSplitMerge(0, n, b);
        }

        private static void TopDownSplitMerge(int start, int end, int[] b)
        {
            if (end - start < 2)
            {
                return;
            }

            int middle = (end + start) / 2;
            TopDownSplitMerge(start, middle, b);
            TopDownSplitMerge(middle, end, b);
            TopDownMerge(start, middle, end, b);
            CopyArray(b, start, end);
        }

        private static void TopDownMerge(int start, int middle, int end, int[] b)
        {
            int i = start;
            int j = middle;
            for (int k = start; k < end; k++)
            {
                if (i < middle && (j >= end || A[i] <= A[j]))
                {
                    b[k] = A[i];
                    i++;
                }
                else
                {
                    b[k] = A[j];
                    j++;
                }
            }
        }

        private static void CopyArray(int[] b, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                A[i] = b[i];
            }
        }
    }
}

// Write a program that sorts an array of integers using the Merge sort algorithm.