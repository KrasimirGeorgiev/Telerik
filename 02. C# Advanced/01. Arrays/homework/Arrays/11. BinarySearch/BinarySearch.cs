namespace _11.BinarySearch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BinarySearch
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int number = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            Console.WriteLine(BinarySearchIntArray(arr, number));
        }

         private static int BinarySearchIntArray(int[] arr, int number)
         {
            int min = 0;
            int max = arr.Length - 1;
            while (true)
            {
                if (min + 1 == max && arr[min] != number && arr[max] != number)
                {
                    break;
                }

                int currentIndex = (max + min) / 2;
                if (arr[currentIndex] == number)
                {
                    return currentIndex;
                }
                else if (arr[currentIndex] > number)
                {
                    max = currentIndex;
                }
                else if (arr[currentIndex] < number)
                {
                    min = currentIndex;
                }
            }

            return -1;
         }
    }
}

// Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.
// Personal notes:
// Binary search pseudocode
// 1. Let min = 0 and max = n - 1.
// 2. Compute guessguess as the average of maxmax and minmin, rounded down so that it is an integer.
// 3. If array[guess] array[guess] equals targettarget, then stop. You found it! Return guessguess.
// 4. If the guess was too low, that is, array[guess] < targetarray[guess]<target, then set min = guess + 1min=guess+1.
// 5. Otherwise, the guess was too high.Set max = guess - 1max= guess−1.
// Go back to step two.
