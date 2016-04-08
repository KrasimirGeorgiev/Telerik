namespace _16.Trailing0inN
{
    using System;
    using System.Numerics;

    public class Trailing0inN
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int result = CountZerosInFactOf(number);
            Console.WriteLine(result);
        }

        private static int CountZerosInFactOf(int n)
        {
            int result = 0;
            int start = 1;
            while (n >= start)
            {
                start *= 5;
                result += (int)n / start;
            }

            return result;
        }
    }
}

// Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
// Your program should work well for very big numbers, e.g.N = 100000.
