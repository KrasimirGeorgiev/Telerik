namespace _07.Calculate3
{
    using System;
    using System.Numerics;

    public class Calculate3
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger numberA = Factorial(n);
            BigInteger numberB = Factorial(k);
            BigInteger numberAMinusBFactorial = Factorial(n - k);
            BigInteger result = numberA / (numberB * numberAMinusBFactorial);

            Console.WriteLine("{0}", result);
        }

        private static BigInteger Factorial(int n)
        {
            BigInteger result = 1;
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

// In combinatorics, the number of ways to choose N different members out of a group of N different elements(also known as the number of combinations) is 
// calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
// Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.
// Try to use only two loops.