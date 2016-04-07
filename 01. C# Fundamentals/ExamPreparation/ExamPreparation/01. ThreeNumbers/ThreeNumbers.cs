namespace _01.ThreeNumbers
{
    using System;

    public class ThreeNumbers
    {
        public static void Main()
        {
            decimal numberA = decimal.Parse(Console.ReadLine());
            decimal numberB = decimal.Parse(Console.ReadLine());
            decimal numberC = decimal.Parse(Console.ReadLine());
            decimal max = Math.Max(Math.Max(numberA, numberB), numberC);
            decimal min = Math.Min(Math.Min(numberA, numberB), numberC);
            decimal arithmeticMean = (numberA + numberB + numberC) / 3;

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("{0:F2}", arithmeticMean);
        }
    }
}

// Telerik Academy Exam 1 @ 3 February 2015 Morning
// http://bgcoder.com/Contests/Practice/Index/204#0