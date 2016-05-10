namespace _07.SelectionSort
{
    using System;

    public class SelectionSort
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal[] arr = new decimal[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(Environment.NewLine, SortArrWithSelectionSort(arr)));
        }

        private static decimal[] SortArrWithSelectionSort(decimal[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                decimal firstElement = arr[i];
                decimal min = firstElement;
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    decimal secondElement = arr[j];
                    if (secondElement < min)
                    {
                        min = secondElement;
                        minIndex = j;
                    }

                    if (j == arr.Length - 1 && min != firstElement)
                    {
                        decimal swapElement = arr[i];
                        arr[i] = arr[minIndex];
                        arr[minIndex] = swapElement;
                    }
                }
            }

            return arr;
        }
    }
}

// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the Selection sort algorithm: 
// Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
// PersonalNotes: Selection sort finds the smallest element and puts it in the beggining, then from the rest(without the minimum element that was just found) finds
//  the smallest again and puts it second etc... (example https://www.youtube.com/watch?v=f8hXR_Hvybo)