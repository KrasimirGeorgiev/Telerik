namespace _05.NumbersComparer
{
    using System;

    public class NumbersComparer
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double maxNumber = Math.Max(a, b);

            Console.WriteLine(maxNumber);

            //// Input  Output
            //// 5
            //// 6      6
            //// 10
            //// 5      10
            //// 0
            //// 0      0
            //// - 5
            //// - 2    - 2
            //// 1.5
            //// 1.6    1.6
        }
    }
}

// Write a program that gets two numbers from the console and prints the greater of them.
// Try implementing it without using if-statements