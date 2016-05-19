namespace _06.TriangleSurfaceByTwoSidesAndAngle
{
    using System;

    public class TriangleSurface
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double betta = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", FindTriangleSurfaceFromTwoSidesAndAngle(a, b, betta));
        }

        private static double FindTriangleSurfaceFromTwoSidesAndAngle(double a, double b, double angle)
        {
            return (a * b * Math.Sin(angle * (Math.PI / 180.0))) / 2;
        }
    }
}

// Write program that calculates the surface of a triangle by given two sides and an angle between them.
// Print the surface of the rectangle with two digits of precision
// Personal notes:
// Most calculators use Degrees, whereas most programming languages are set up to use radians.
// You should convert the value from degrees to radians Math.Sin/Cos(angleInDegrees * (Math.PI / 180.0));