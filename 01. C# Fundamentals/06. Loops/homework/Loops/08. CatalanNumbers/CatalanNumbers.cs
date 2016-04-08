namespace _08.CatalanNumbers
{
    using System;
    using System.Numerics;

    public class CatalanNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger twiseNFactorial = Factorial(2 * number);
            BigInteger numberFactorial = Factorial(number);
            BigInteger numberPlusOneFactorial = Factorial(number + 1);
            BigInteger result = twiseNFactorial / (numberPlusOneFactorial * numberFactorial);

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

// In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
// (2n)! / (n + 1)! * n!
// Write a program to calculate the Nth Catalan number by given N
