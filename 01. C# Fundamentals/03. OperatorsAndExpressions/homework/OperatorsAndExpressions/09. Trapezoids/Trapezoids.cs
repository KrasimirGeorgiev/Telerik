namespace _09.Trapezoids
{
    using System;

    public class Trapezoids
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = h * ((a + b) / 2);

            Console.WriteLine("{0:F7}", area);
            //// Input Output
            //// 5
            //// 7
            //// 12    72.0000000
            
            //// 2
            //// 1
            //// 33    49.5000000
            
            //// 8.5
            //// 4.3
            //// 2.7   17.2800000
            
            //// 100
            //// 200
            //// 300   45000.0000000
            
            //// 0.222
            //// 0.333
            //// 0.555 0.1540125
        }
    }
}

// Write an expression that calculates trapezoid's area by given sides a and b and height h. 
// The three values should be read from the console in the order shown below. 
// All three value will be floating-point numbers.
// Output the area with exactly 7-digit precision after the floating point.