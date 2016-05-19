namespace _05.TriangleSurfaceByThreeSides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TriangleSurfaceByThreeSides
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", FindTrianglesAreaByThreeSides(a, b, c));
        }

        private static double FindTrianglesAreaByThreeSides(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return result;
        }
    }
}

// Write program that calculates the surface of a triangle by given its three sides.
// Print the surface of the rectangle with two digits of precision