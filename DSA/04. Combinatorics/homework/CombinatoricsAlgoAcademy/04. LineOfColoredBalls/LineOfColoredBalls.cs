namespace _04.LineOfColoredBalls
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class LineOfColoredBalls
    {
        public static void Main()
        {
            Dictionary<int, int> ballsAndCount = new Dictionary<int, int>();
            string input = Console.ReadLine();
            foreach (int symbol in input)
            {
                if (ballsAndCount.ContainsKey(symbol))
                {
                    ballsAndCount[symbol]++; 
                }
                else
                {
                    ballsAndCount.Add(symbol, 1);
                }
            }

            BigInteger top = Factorial(input.Length);
            BigInteger bottom = 1;
            foreach (char key in ballsAndCount.Keys)
            {
                bottom *= Factorial(ballsAndCount[key]);
            }

            Console.WriteLine(top / bottom);
        }

        private static BigInteger Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return (BigInteger)n * Factorial(n - 1);
        }
    }
}
