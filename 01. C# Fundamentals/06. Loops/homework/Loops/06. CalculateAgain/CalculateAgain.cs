namespace _06.CalculateAgain
{
    using System;

    public class CalculateAgain
    {
        public static void Main()
        {
            long numberA = Factorial(int.Parse(Console.ReadLine()));
            long numberB = Factorial(int.Parse(Console.ReadLine()));
            decimal result = (decimal)numberA / numberB;

            Console.WriteLine("{0}", result);
        }

        private static long Factorial(int n)
        {
            long result = 1;
            if (n == 0 || n == 1)
            {
                return result;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }

                return result;
            }
        }
    }
}

// Write a program that calculates N! / K! for given N and K.
// Use only one loop.
