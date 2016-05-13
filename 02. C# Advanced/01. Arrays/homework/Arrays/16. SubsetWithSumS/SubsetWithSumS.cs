namespace _16.SubsetWithSumS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SubsetWithSumS
    {
        private static bool thereIsSum = false;

        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());
            List<int> workingArr = new List<int>();
            FindSumInArrayWithPermutations(arr, workingArr, 0, sum);
            if (thereIsSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        private static void FindSumInArrayWithPermutations(int[] arr, List<int> workingArr, int startingIndex, int wantedSum)
        {
            if (workingArr.Count > 0 && workingArr.Sum() == wantedSum)
            {
                thereIsSum = true;
                //// Console.WriteLine(string.Join(", ", workingArr));
            }

            for (int i = startingIndex; i < arr.Length; i++)
            {
                workingArr.Add(arr[i]);
                FindSumInArrayWithPermutations(arr, workingArr, startingIndex + 1, wantedSum);
                workingArr.RemoveAt(workingArr.Count - 1);
                if (thereIsSum)
                {
                    return;
                }
            }
        }
    }
}

// We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S.