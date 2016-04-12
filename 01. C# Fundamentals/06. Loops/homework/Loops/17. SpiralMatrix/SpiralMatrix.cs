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
            bool swtch = true;

            while (swtch)
            {
                switch (direction)
                {
                    case 'r': Right(); break;
                    case 'd': Down(); break;
                    case 'l': Left(); break;
                    case 'u': Up(); break;
                    default: swtch = false; break;
                }
            }

            StringBuilder result = new StringBuilder(); 
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    result.Append(spiralMatrix[row, col]);
                    result.Append(" ");
                }

                result.Length = result.Length - 1;
                result.AppendLine();
            }

            result.Length = result.Length - 1;
            Console.WriteLine(result.ToString());
        }

        private static void Right()
        {
            int insideCounter = 0;
            for (int i = col; i < n - limitation; i++)
            {
                spiralMatrix[row, i] = count;
                count++;
                insideCounter++;
                if (i == (n - limitation) - 1)
                {
                    col = i;
                    if (row + 1 < n - limitation)
                    {
                        row++;
                    }
                    else
                    {
                        insideCounter = 0;
                    }
                }
            }

            direction = insideCounter == 0 ? 'e' : 'd';
        }

        private static void Down()
        {
            int insideCounter = 0;
            for (int i = row;  i < n - limitation; i++)
            {
                spiralMatrix[i, col] = count;
                count++;
                insideCounter++;
                if (i == (n - limitation) - 1)
                {
                    row = i;
                    if (col - 1 > limitation)
                    {
                        col--;
                    }
                    else
                    {
                        insideCounter = 0;
                    }
                }
            }

            direction = insideCounter == 0 ? 'e' : 'l';
        }

        private static void Left()
        {
            int insideCounter = 0;
            for (int i = col; i >= limitation; i--)
            {
                spiralMatrix[row, i] = count;
                count++;
                insideCounter++;
                if (i == (n - limitation) - 1)
                {
                    col = i;
                    if (row - 1 > limitation)
                    {
                        row--;
                    }
                    else
                    {
                        insideCounter = 0;
                    }
                }
            }

            direction = insideCounter == 0 ? 'e' : 'u';
        }

        private static void Up()
        {
            limitation++;
            int insideCounter = 0;
            for (int i = (n - limitation); i >= 0 + limitation; i--)
            {
                spiralMatrix[i, col] = count;
                count++;
                insideCounter++;
                if (i == (n - limitation))
                {
                    row = i;
                    if (col + 1 < n - (limitation + 1))
                    {
                        col++;
                    }
                    else
                    {
                        insideCounter = 0;
                    }
                }
            }

            direction = insideCounter == 0 ? 'e' : 'r';
        }
    }
}

// Write a program that reads from the console a positive integer number N(1 ≤ N ≤ 20) and prints a matrix holding the numbers from 1 to N * N in the 
// form of square spiral like in the examples below.