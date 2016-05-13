namespace _14.QuickSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class QuickSort
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            QuicksortAlg(a, 0, n - 1);
            Console.WriteLine(string.Join(", ", a));
        }

        private static void QuicksortAlg(int[] numbers, int left, int right)
        {
            int i = left, j = right;
            int pivot = numbers[(left + right) / 2];

            while (i <= j)
            {
                while (numbers[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (numbers[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    int swapNumbers = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = swapNumbers;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuicksortAlg(numbers, left, j);
            }

            if (i < right)
            {
                QuicksortAlg(numbers, i, right);
            }
        }
    }
}

// Write a program that sorts an array of integers using the Quick sort algorithm.