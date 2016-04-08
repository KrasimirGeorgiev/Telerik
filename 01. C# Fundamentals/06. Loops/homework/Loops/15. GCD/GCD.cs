namespace _15.GCD
{
    using System;
    using System.Linq;

    public class GCD
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = numbers[0];
            int b = numbers[1];
            int result = GreatestCommonDenominator(a, b);

            Console.WriteLine(result);
        }

        private static int GreatestCommonDenominator(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            if (a == 0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }
}

// Write a program that calculates the greatest common divisor(GCD) of given two integers A and B.
// Use the Euclidean algorithm(find it in Internet).