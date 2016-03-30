namespace _10.PointCircleRectangle
{
    using System;

    public class PointCircleRectangle
    {
        public static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            string inOrOutsideCircle = string.Empty;
            inOrOutsideCircle = Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) <= 1.5 * 1.5 ? "inside" : "outside"; // x and y must satisfy (x - center_x)^2 + (y - center_y)^2 <= radius^2
            string inOrOutsideRectangle = string.Empty;
            inOrOutsideRectangle = (-1 <= x && x <= 5) && (-1 <= y && y <= 1) ? "inside" : "outside";
            Console.WriteLine("{0} circle {1} rectangle", inOrOutsideCircle, inOrOutsideRectangle); 

            //// Input Output
            //// 2.5
            //// 2     outside circle outside rectangle

            //// 0
            //// 1     inside circle inside rectangle

            //// 2.5
            //// 1     inside circle inside rectangle

            //// 1
            //// 2     inside circle outside rectangle
        }
    }
}

// Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point(x, y) 
// if it is within the circle K({ 1, 1}, 1.5) and out of the rectangle R(top= 1, left= -1, width= 6, height= 2).
