namespace _05.Calculate
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Calculate
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal x = decimal.Parse(Console.ReadLine());
            decimal result = 1;
            for (int i = 1; i <= n; i++)
            {
                result += (decimal)Factorial(i) / NumberOnPowerOf(x, i);
            }

            Console.WriteLine("{0:F5}", result);
        }

        private static BigInteger Factorial(int n)
        {
            BigInteger result = 1;
            if (n == 1)
            {
                return result;
            }

            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        } 

        private static decimal NumberOnPowerOf(decimal number, int power)
        {
            decimal result = 1M;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}