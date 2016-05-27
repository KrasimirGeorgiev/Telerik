namespace _03.Patterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public class XPatterns
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[,] matrix = new long[n, n];
            bool thereIsPattern = false;
            List<BigInteger> results = new List<BigInteger>();
            BigInteger sum = (BigInteger)0;
            for (int row = 0; row < n; row++)
            {
                string[] currentInput = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = long.Parse(currentInput[col]);
                }
            }

            for (int row = 0; row < n - 2; row++)
            {
                for (int col = 0; col < n - 4; col++)
                {
                    long a = matrix[row, col];
                    long b = matrix[row, col + 1];
                    long c = matrix[row, col + 2]; 
                    long d = matrix[row + 1, col + 2];
                    long e = matrix[row + 2, col + 2];
                    long f = matrix[row + 2, col + 3];
                    long g = matrix[row + 2, col + 4];
                    if (a + 1 != b || b + 1 != c || c + 1 != d || d + 1 != e || e + 1 != f || f + 1 != g)
                    {
                        continue;
                    }

                    sum += a;
                    sum += b;
                    sum += c;
                    sum += d;
                    sum += e;
                    sum += f;
                    sum += g;
                    thereIsPattern = true;
                    results.Add(sum);
                    sum = (BigInteger)0;
                }
            }

            if (!thereIsPattern)
            {
                for (int i = 0; i < n; i++)
                {
                    sum += matrix[i, i];
                }

                Console.WriteLine("NO {0}", sum);
            }
            else
            {
                Console.WriteLine("YES {0}", results.Max());
            }

            //// Console.WriteLine(PrintMatrix(matrix, n, n));
        }

        private static string PrintMatrix(long[,] matrix, int rowLength, int colLength)
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

// C# Part 2 - 2013/2014 @ 22 Jan 2014 - Evening
// http://bgcoder.com/Contests/Practice/Index/142#2