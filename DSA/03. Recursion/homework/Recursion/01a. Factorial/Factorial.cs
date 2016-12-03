namespace _01a.Factorial
{
    using System;

    public class Factorial
    {
        public static void Main()
        {
            int n = 20; // 432902008176640000
            long factorial = CalculateFactorial(n);
            Console.WriteLine(factorial);
        }

        private static long CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * CalculateFactorial(n - 1);
        }
    }
}
