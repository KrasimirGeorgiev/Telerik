namespace _17.SubsetKWithSumS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SubsetKWithSumS
    {
        private static bool thereIsSum = false;

        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int numberOfElements = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            List<int> workingArr = new List<int>();
            FindSumInArrayWithPermutations(arr, workingArr, 0, sum, numberOfElements);
            
            if (!thereIsSum)
            {
                Console.WriteLine("No subset matches the criteria");
            }
        }

        private static void FindSumInArrayWithPermutations(int[] arr, List<int> workingArr, int startingIndex, int wantedSum, int numberOfElements)
        {
            if (workingArr.Count == numberOfElements && workingArr.Sum() == wantedSum)
            {
                thereIsSum = true;
                Console.WriteLine(string.Join(", ", workingArr));
            }

            for (int i = startingIndex; i < arr.Length; i++)
            {
                workingArr.Add(arr[i]);
                FindSumInArrayWithPermutations(arr, workingArr, startingIndex + 1, wantedSum, numberOfElements);
                workingArr.RemoveAt(workingArr.Count - 1);
                if (thereIsSum)
                {
                    return;
                }
            }
        }
    }
}

// Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
// Find in the array a subset of K elements that have sum S or indicate about its absence.