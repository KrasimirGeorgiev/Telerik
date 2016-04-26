namespace _06.CalculateAgain
{
    using System;
    using System.Numerics;

    public class CalculateAgain
    {
        public static void Main()
        {
            BigInteger numberA = Factorial(int.Parse(Console.ReadLine()));
            BigInteger numberB = Factorial(int.Parse(Console.ReadLine()));
            BigInteger result = numberA / numberB;

            Console.WriteLine("{0}", result);
        }

        private static BigInteger Factorial(int n)
        {
            BigInteger result = (BigInteger)1;
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
