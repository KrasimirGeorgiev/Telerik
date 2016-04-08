namespace _09.MatrixOfNumbers
{
    using System;
    using System.Text;

    public class MatrixOfNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n + (i - 1); j++)
                {
                    result.Append(j);
                    result.Append(" ");
                }

                result.Length = result.Length - 1;
                result.AppendLine();
            }

            result.Length = result.Length - 1;
            Console.WriteLine(result.ToString());
        }
    }
}

// Write a program that reads from the console a positive integer number N and prints a matrix like in the examples below. Use two nested loops
// Challenge: achieve the same effect without nested loops