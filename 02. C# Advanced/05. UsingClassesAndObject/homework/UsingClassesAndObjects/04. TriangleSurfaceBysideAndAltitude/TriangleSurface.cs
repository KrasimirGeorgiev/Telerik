namespace _04.TriangleSurfaceBysideAndAltitude
{
    using System;

    public class TriangleSurface
    {
        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", FindTriangleSurface(side, h));
        }

        private static double FindTriangleSurface(double side, double h)
        {
            return (side * h) / 2;
        }
    }
}

// Write program that calculates the surface of a triangle by given a side and an altitude to it.
// Print the surface of the rectangle with two digits of precision