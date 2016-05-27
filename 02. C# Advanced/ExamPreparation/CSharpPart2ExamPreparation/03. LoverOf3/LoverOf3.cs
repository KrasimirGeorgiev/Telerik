namespace _03.LoverOf3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public class LoverOf3
    {
        public static void Main()
        {
            int[] rowColInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowLength = rowColInput[0];
            int colLength = rowColInput[1];
            int n = int.Parse(Console.ReadLine());
            ulong[,] matrix = new ulong[rowLength, colLength];
            FillTheMatrix(matrix, rowLength, colLength);
            int currentRow = rowLength - 1;
            int currentCol = 0;
            ulong sum = 0;
            for (int i = 0; i < n; i++)
            {
                string[] inputDirection = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string direction = inputDirection[0];
                int times = int.Parse(inputDirection[1]);
                switch (direction)
                {
                    case "RU":
                        for (int j = 0; j < times; j++)
                        {
                            if (currentCol <= colLength - 1 && currentRow >= 0)
                            {
                                sum += matrix[currentRow, currentCol];
                                matrix[currentRow, currentCol] = 0;
                                if (j < times - 1)
                                {
                                    currentRow--;
                                    currentCol++;
                                }
                            }
                            else
                            {
                                currentCol--;
                                currentRow++;
                                break;
                            }
                        }

                        break;
                    case "UR":
                        for (int j = 0; j < times; j++)
                        {
                            if (currentCol <= colLength - 1 && currentRow >= 0)
                            {
                                sum += matrix[currentRow, currentCol];
                                matrix[currentRow, currentCol] = 0;
                                if (j < times - 1)
                                {
                                    currentRow--;
                                    currentCol++;
                                }
                            }
                            else
                            {
                                currentCol--;
                                currentRow++;
                                break;
                            }
                        }

                        break;
                    case "LU":
                        for (int j = 0; j < times; j++)
                        {
                            if (currentCol >= 0 && currentRow >= 0)
                            {
                                sum += matrix[currentRow, currentCol];
                                matrix[currentRow, currentCol] = 0;
                                if (j < times - 1)
                                {
                                    currentRow--;
                                    currentCol--;
                                }
                            }
                            else
                            {
                                currentCol++;
                                currentRow++;
                                break;
                            }
                        }

                        break;
                    case "UL":
                        for (int j = 0; j < times; j++)
                        {
                            if (currentCol >= 0 && currentRow >= 0)
                            {
                                sum += matrix[currentRow, currentCol];
                                matrix[currentRow, currentCol] = 0;
                                if (j < times - 1)
                                {
                                    currentRow--;
                                    currentCol--;
                                }
                            }
                            else
                            {
                                currentCol++;
                                currentRow++;
                                break;
                            }
                        }

                        break;
                    case "DL":
                        for (int j = 0; j < times; j++)
                        {
                            if (currentCol >= 0 && currentRow <= rowLength - 1)
                            {
                                sum += matrix[currentRow, currentCol];
                                matrix[currentRow, currentCol] = 0;
                                if (j < times - 1)
                                {
                                    currentRow++;
                                    currentCol--;
                                }
                            }
                            else
                            {
                                currentCol++;
                                currentRow--;
                                break;
                            }
                        }

                        break;
                    case "LD":
                        for (int j = 0; j < times; j++)
                        {
                            if (currentCol >= 0 && currentRow <= rowLength - 1)
                            {
                                sum += matrix[currentRow, currentCol];
                                matrix[currentRow, currentCol] = 0;
                                if (j < times - 1)
                                {
                                    currentRow++;
                                    currentCol--;
                                }
                            }
                            else
                            {
                                currentCol++;
                                currentRow--;
                                break;
                            }
                        }

                        break;
                    case "DR":
                        for (int j = 0; j < times; j++)
                        {
                            if (currentCol <= colLength - 1 && currentRow <= rowLength - 1)
                            {
                                sum += matrix[currentRow, currentCol];
                                matrix[currentRow, currentCol] = 0;
                                if (j < times - 1)
                                {
                                    currentRow++;
                                    currentCol++;
                                }
                            }
                            else
                            {
                                currentCol--;
                                currentRow--;
                                break;
                            }
                        }

                        break;
                    case "RD":
                        for (int j = 0; j < times; j++)
                        {
                            if (currentCol <= colLength - 1 && currentRow <= rowLength - 1)
                            {
                                sum += matrix[currentRow, currentCol];
                                matrix[currentRow, currentCol] = 0;
                                if (j < times - 1)
                                {
                                    currentRow++;
                                    currentCol++;
                                }
                            }
                            else
                            {
                                currentCol--;
                                currentRow--;
                                break;
                            }
                        }

                        break;
                }
            }

            //// Console.WriteLine(PrintMatrix(matrix, rowLength, colLength));
            Console.WriteLine(sum);
        }

        private static void FillTheMatrix(ulong[,] matrix, int rowLength, int colLength)
        {
            ulong number = 0;
            int n = 0;
            //// DownLeft
            for (int i = 0; i < colLength; i++)
            {
                while (i - n >= 0 && rowLength - (1 + n) >= 0)
                {
                    matrix[rowLength - (1 + n), i - n] = number;
                    n++;
                }

                n = 0;
                number += 3;
            }

            //// UpRight
            for (int i = rowLength - 2; i >= 0; i--)
            {
                while (i - n >= 0 && colLength - (1 + n) >= 0)
                {
                    matrix[i - n, colLength - (1 + n)] = number;
                    n++;
                }

                n = 0;
                number += 3;
            }
        }

        private static string PrintMatrix(BigInteger[,] matrix, int rowLength, int colLength)
        {
            StringBuilder result = new StringBuilder();
            for (int row = 0; row < rowLength; row++)
            {
                for (int col = 0; col < colLength; col++)
                {
                    result.Append(matrix[row, col]);
                    result.Append(" ");
                }

                result.Length = result.Length - 1;
                result.AppendLine();
            }

            result.Length = result.Length - 1;

            return result.ToString();
        }
    }
}

// C# Part 2 - 2015/2016 @ 5 March 2015 - Evening
// http://bgcoder.com/Contests/Practice/Index/221#2