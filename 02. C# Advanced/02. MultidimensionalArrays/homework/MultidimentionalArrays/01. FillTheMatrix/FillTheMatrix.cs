namespace _01.FillTheMatrix
{
    using System;
    using System.Text;

    public class FillTheMatrix
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char type = char.Parse(Console.ReadLine());
            switch (type)
            {
                case 'a': Console.Write(MatrixAsString(MatrixTypeA(n)));
                    break;
                case 'b': Console.Write(MatrixAsString(MatrixTypeB(n)));
                    break;
                case 'c': Console.Write(MatrixAsString(MatrixTypeC(n)));
                    break;
                case 'd': Console.Write(MatrixAsString(MatrixTypeD(n)));
                    break;

                default:
                    throw new ArgumentOutOfRangeException("In the main switch was entered invalide type for matrix");
                    break;
            }
        }

        private static int[,] MatrixTypeA(int n)
        {
            int[,] result = new int[n, n];
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[j, i] = count;
                    count++;
                }
            }

            return result;
        }

        private static int[,] MatrixTypeB(int n)
        {
            int[,] result = new int[n, n];
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        result[j, i] = count;
                        count++;
                    }
                }
                else
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        result[j, i] = count;
                        count++;
                    }
                }
            }

            return result;
        }

        private static int[,] MatrixTypeC(int n)
        {
            int[,] result = new int[n, n];
            int count = 1;
            //// bottomLeft half
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j >= n)
                    {
                        break;
                    }

                    result[i + j, j] = count;
                    count++;
                }
            }

            //// upperRight half
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j + i >= n)
                    {
                        break;
                    }

                    result[j, i + j] = count;
                    count++;
                }
            }

            return result;
        }

        private static int[,] MatrixTypeD(int n)
        {
            int[,] result = new int[n, n];
            int count = 1;
            int row = -1;
            int col = 0;
            int countSteps = 0;
            int endCountSteps = PowerOf(n, 2);
            char direction = 'd';
            while (countSteps < endCountSteps)
            {
                switch (direction)
                {
                    case 'd':
                        direction = 'r';
                        for (int i = row + 1; i < n; i++)
                        {
                            if (result[i, col] != 0)
                            {
                                break;
                            }

                            result[i, col] = count;
                            row = i;
                            count++;
                            countSteps++;
                        }

                        break;
                    case 'r':
                        direction = 'u';
                        for (int i = col + 1; i < n; i++)
                        {
                            if (result[row, i] != 0)
                            {
                                break;
                            }

                            result[row, i] = count;
                            col = i;
                            count++;
                            countSteps++;
                        }

                        break;
                    case 'u':
                        direction = 'l';
                        for (int i = row - 1; i >= 0; i--)
                        {
                            if (result[i, col] != 0)
                            {
                                break;
                            }

                            result[i, col] = count;
                            row = i;
                            count++;
                            countSteps++;
                        }

                        break;
                    case 'l':
                        direction = 'd';
                        for (int i = col - 1; i >= 0; i--)
                        {
                            if (result[row, i] != 0)
                            {
                                break;
                            }

                            result[row, i] = count;
                            col = i;
                            count++;
                            countSteps++;
                        }

                        break;
                    default:
                        throw new ArgumentOutOfRangeException("The switch in the MatrixTypeD has recieved a value that is not a allowed");
                }
            }

            return result;
        }

        private static string MatrixAsString(int[,] arr)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    result.Append(arr[i, j]);
                    result.Append(" ");
                }

                result.Length = result.Length - 1;
                result.AppendLine();
            }

            result.Length = result.Length - 1;
            return result.ToString();
        }

        private static int PowerOf(int n, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= n;
            }

            return result;
        }
    }
}

// Write a program that fills and prints a matrix of size (n, n) as shown below.
// input    output    
// 4        1   5   9   13
// a        2   6   10  14
//          3   7   11  15
//          4   8   12  16
//          
// 4        1   8   9   16
// 5        2   7   10  15
//          3   6   11  14
//          4   5   12  13
//          
// 4        7   11  14  16
// c        4   8   12  15
//          2   5   9   13
//          1   3   6   10
//          
// 4        1   12  11  10
// d        2   13  16  9
//          3   14  15  8
//          4   5   6   7