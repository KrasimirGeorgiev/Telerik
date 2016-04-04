namespace _06.QuadraticEquation
{
    using System;

    public class QuadraticEquation
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = (b * b) - (4 * a * c);
            if (d == 0)
            {
                Console.WriteLine(-b / (2 * a));
            }
            else if (d > 0)
            {
                Console.WriteLine("{0:F2}", (-b + Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("{0:F2}", (-b - Math.Sqrt(d)) / (2 * a));
            }
            else
            {
                Console.WriteLine("no real roots");
            }

            //// Sample tests
            //// Input   Output
            //// 2
            //// 5
            //// - 3     0.50
            ////         - 3.00

            //// - 1
            //// 3
            //// 0       0.00
            ////         3.00

            //// - 0.5
            //// 4
            //// - 8     4.00

            //// 5
            //// 2
            //// 8       no real roots
        }
    }
}

// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it(prints its real roots).