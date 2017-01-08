using System;
using System.Numerics;

namespace _01.PerimeterOfSquaresInARectangle
{
    public class PerimeterOfSquaresInARectangle
    {
        public static void Main()
        {
            BigInteger n = 5; //input
            BigInteger a = 1, b = 1, c = a + b, r = a + b + c;
            for (int i = 0; i < n - 2; i++)
            {
                a = b; b = c; c = a + b; r += c;
            }

            Console.WriteLine(4 * r);
        }
    }
}
