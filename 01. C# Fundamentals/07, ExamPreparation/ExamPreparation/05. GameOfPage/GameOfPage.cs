namespace _05.GameOfPage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GameOfPage
    {
        public static void Main()
        {
            char[,] matrix = new char[16, 16];
            decimal cookieCost = 1.79M;
            int cookiesCount = 0;
            for (int i = 0; i < 16; i++)
            {
                string inputLine = Console.ReadLine();
                int count = 0;
                foreach (char symbol in inputLine)
                {
                    matrix[i, count] = symbol;
                    count++;
                }
            }

            string command = Console.ReadLine();
            while (command != "paypal")
            {
                if (command == "what is")
                {
                    int row = int.Parse(Console.ReadLine());
                    int col = int.Parse(Console.ReadLine());
                    string whatIs = "";
                    
                }
                else if (command == "pay")
                {
                    int row = int.Parse(Console.ReadLine());
                    int col = int.Parse(Console.ReadLine());
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(ReturnMatrixToString(matrix));
        }

        private static string WhatIs(char[,] matrix, int row, int col)
        {
            string result = "";
            char currentBit = matrix[row, col];
            if (currentBit != '1')
            {
                result = "broken cookie";
            }
            else
            {
                if (row >= 15 || col >= 15 || row <= 0 || col <= 0)
                {
                    result = "broken cookie";
                }
                else
                {
                    if (matrix[row - 1, col] != '1')
                    {
                        result = "broken cookie";

                    }
                    else if (matrix[row - 1, col + 1] != '1')
                    {
                        result = "broken cookie";
                    }
                    else if (matrix[row, col + 1] != '1')
                    {
                        result = "broken cookie";
                    }
                    else if (matrix[row + 1, col + 1] != '1')
                    {
                        result = "broken cookie";
                    }
                    else if (matrix[row + 1, col] != '1')
                    {
                        result = "broken cookie";
                    }
                    else if (matrix[row + 1, col - 1] != '1')
                    {
                        result = "broken cookie";
                    }
                    else if (matrix[row, col - 1] != '1')
                    {
                        result = "broken cookie";
                    }
                    else if (matrix[row - 1, col - 1] != '1')
                    {
                        result = "broken cookie";
                    }
                    else
                    {
                        result = "cokie";
                    }
                }
            }

            return result;
        }

        private static string ReturnMatrixToString(char[,] matrix)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    result.Append(matrix[i, j]);
                }

                result.AppendLine();
            }

            result.Length = result.Length - 1;
            return result.ToString();
        }
    }
}
