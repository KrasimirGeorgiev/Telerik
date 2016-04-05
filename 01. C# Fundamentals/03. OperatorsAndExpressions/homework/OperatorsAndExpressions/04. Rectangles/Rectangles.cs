namespace _04.Rectangles
{
    using System;

    public class Rectangles
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * (width + height);
            double area = width * height;

            Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
            //// Input Output
            //// 3
            //// 4     14.00 12.00
            
            //// 2.5   
            //// 3     11.00 7.50
            
            //// 5     
            //// 5     20.00 25.00
        }
    }
}

// Write an expression that calculates rectangle’s perimeter and area by given width and height.
// The width and height should be read from the console.
// Output: Output a single line - the rectangle's perimeter and area, separated by a whitespace.
// Print the perimeter and area values with exactly 2-digits precision after the floating point