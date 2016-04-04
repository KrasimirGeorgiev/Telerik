namespace _10.FibonacciNumbers
{
    using System;
    using System.Collections.Generic;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine(0);
            }
            else if (n == 2)
            {
                Console.WriteLine("0, 1");
            }
            else
            {
                List<int> fibonacciOfN = new List<int>();
                fibonacciOfN.Add(0);
                fibonacciOfN.Add(1);
                for (int i = 2; i < n; i++)
                {
                    fibonacciOfN.Add(fibonacciOfN[i - 1] + fibonacciOfN[i - 2]);
                }

                Console.WriteLine(string.Join(", ", fibonacciOfN));
            }

            //// Input Output
            //// 1     0
            //// 3     0, 1, 1
            //// 10    0, 1, 1, 2, 3, 5, 8, 13, 21, 34
        }
    }
}

// Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence
// (at a single line, separated by comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….