namespace _03.Circle
{
    using System;

    public class Circle
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r; // Math.Pow(r, 2) is slower than r * r
            Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
            
            //// input output
            //// 2     12.57 12.57
            //// 3.5   21.99 38.48
        }
    }
}

// Write a program that reads from the console the radius r of a circle and prints its perimeter and area, 
// rounded and formatted with 2 digits after the decimal point.