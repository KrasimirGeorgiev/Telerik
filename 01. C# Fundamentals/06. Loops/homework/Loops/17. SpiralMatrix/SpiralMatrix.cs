namespace _17.SpiralMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SpiralMatrix
    {
        static int n = int.Parse(Console.ReadLine());
        static int[,] spiralMatrix = new int[n, n];
        static int count = 1;
        static int limitation = 0;
        static int row = 0;
        static int col = 0;
        static char direction = 'r';

        public static void Main()
        {
            

            while (true)
            {
                switch (direction)
                {
                    case 'r': break;
                    case 'd': break;
                    case 'l': break;
                    case 'u': break;
                }
            }
        }

        private static void Right()
        {
            for (int i = col; i < n - limitation; i++)
            {
                spiralMatrix[row, col] = count;
                count++;
                if (i == (n - limitation) - 1)
                {
                    col = i;
                }
            }

            direction = 'd';
        }

        private static void Down()
        {
            for (int i = row; i < n - limitation; i++)
            {
                spiralMatrix[row, col] = count;
                count++;
                if (i == (n - limitation) - 1)
                {
                    row = i;
                }
            }

            direction = 'l';
        }
    }
}

// Write a program that reads from the console a positive integer number N(1 ≤ N ≤ 20) and prints a matrix holding the numbers from 1 to N * N in the 
// form of square spiral like in the examples below.