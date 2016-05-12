namespace _02.MaximumSum
{
    using System;
    using System.Linq;

    public class MaximumSum
    {
        public static void Main()
        {
            int[] rowsCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowsCols[0];
            int cols = rowsCols[1];
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                int[] inputRowOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = inputRowOfNumbers[j];
                }
            }

            Console.WriteLine(CheckMatrixForMaxSumOfSquareThree(matrix));
        }

        private static int CheckMatrixForMaxSumOfSquareThree(int[,] matrix)
        {
            int resultSum = int.MinValue;
            int currentSum = 0;
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    currentSum += matrix[i, j];
                    currentSum += matrix[i, j + 1];
                    currentSum += matrix[i, j + 2];
                    currentSum += matrix[i + 1, j];
                    currentSum += matrix[i + 1, j + 1];
                    currentSum += matrix[i + 1, j + 2];
                    currentSum += matrix[i + 2, j];
                    currentSum += matrix[i + 2, j + 1];
                    currentSum += matrix[i + 2, j + 2];

                    resultSum = resultSum < currentSum ? currentSum : resultSum;
                    currentSum = 0;
                }
            }

            return resultSum;
        }
    }
}

// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. Print that sum.