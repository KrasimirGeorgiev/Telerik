namespace _03.BitShiftMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public class BitShiftMatrix
    {
        public static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            BigInteger sum = (BigInteger)0;
            BigInteger[,] matrix = new BigInteger[row, col];
            BigInteger[] moves = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();
            FillTheMatrix(matrix, row, col);
            int currentRow = row - 1;
            int currentCol = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                BigInteger code = moves[i];
                int coeff = Math.Max(row, col);
                int targetRow = (int)((decimal)code / (decimal)coeff);
                int targetCol = (int)(code % coeff);
                sum += matrix[currentRow, currentCol];
                matrix[currentRow, currentCol] = 0;
                if (currentCol != targetCol)
                {
                    while (currentCol < targetCol)
                    {
                        currentCol++;
                        sum += matrix[currentRow, currentCol];
                        matrix[currentRow, currentCol] = 0;
                    }

                    while (currentCol > targetCol)
                    {
                        currentCol--;
                        sum += matrix[currentRow, currentCol];
                        matrix[currentRow, currentCol] = 0;
                    }
                }

                if (currentRow != targetRow)
                {
                    while (currentRow < targetRow)
                    {
                        currentRow++;
                        sum += matrix[currentRow, currentCol];
                        matrix[currentRow, currentCol] = 0;
                    }

                    while (currentRow > targetRow)
                    {
                        currentRow--;
                        sum += matrix[currentRow, currentCol];
                        matrix[currentRow, currentCol] = 0;
                    }
                }
            }

            //// Console.WriteLine(PrintMatrix(matrix, row, col));
            Console.WriteLine(sum);
        }

        private static void FillTheMatrix(BigInteger[,] matrix, int row, int col)
        {
            BigInteger number = 1;
            int n = 0;
            //// LowerHalf
            for (int i = 0; i < col; i++)
            {
                while (true)
                {
                    int currentRow = row - (n + 1);
                    int currentCol = i - n;
                    if (currentCol < 0 || currentRow < 0)
                    {
                        break;
                    }

                    matrix[currentRow, currentCol] = number;
                    n++;
                }

                n = 0;
                number *= 2;
            }
            //// UpperHalf
            for (int i = row - 2; i >= 0; i--)
            {
                while (true)
                {
                    int currentRow = i - n;
                    int currentCol = col - (1 + n);
                    if (currentRow < 0 || currentCol < 0)
                    {
                        break;
                    }

                    matrix[currentRow, currentCol] = number;
                    n++;
                }

                n = 0;
                number *= 2;
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

// C# Part 2 - 2015/2016 @ 6 March 2015 - Evening
// http://bgcoder.com/Contests/Practice/Index/223#2