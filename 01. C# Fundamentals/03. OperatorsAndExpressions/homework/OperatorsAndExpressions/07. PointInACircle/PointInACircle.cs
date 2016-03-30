namespace _07.PointInACircle
{
    using System;

    public class PointInACircle
    {
        public static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = 2;
            if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) <= r * r) // x and y must satisfy (x - center_x)^2 + (y - center_y)^2 <= radius^2
            {
                Console.WriteLine("yes ({0:F2}, {1:F2})", Math.Abs(x - 0), Math.Abs(y - 0));
            }
            else
            {
                Console.WriteLine("no ({0:F2}, {1:F2})", Math.Abs(x - 0), Math.Abs(y - 0));
            }

            //// Input Output
            //// 0
            //// 1     true
            
            //// - 2
            //// 0     true
            
            //// - 1
            //// 2     false
            
            //// 1.5
            //// - 1   true
            
            //// - 1.5
            //// - 1.5 false
            
            //// 100
            //// - 30  false
            
            //// 0
            //// 0     true
            
            //// 0.2
            //// - 0.8  true
            
            //// 0.9
            //// - 1.93 false
            
            //// 1
            //// 1.655  true
        }
    }
}

// Write a program that reads the coordinates of a point x and y and using an expression checks if given point(x, y) 
// is inside a circle K({ 0, 0}, 2) - the center has coordinates(0, 0) and the circle has radius 2. 
// The program should then print "yes DISTANCE" if the point is inside the circle or "no DISTANCE" if the point is outside the circle.
// In place of DISTANCE print the distance from the beginning of the coordinate system - (0, 0) - to the given point. 