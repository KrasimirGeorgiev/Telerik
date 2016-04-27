namespace _01.ABandC
{
    using System;

    public class ABandC
    {
        public static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            decimal smallest = Math.Min(Math.Min(a, b), c);
            decimal biggest = Math.Max(Math.Max(a, b), c);
            decimal arithmeticMean = (a + b + c) / 3;

            Console.WriteLine(biggest);
            Console.WriteLine(smallest);
            Console.WriteLine("{0:F3}", arithmeticMean);
        }
    }
}

// Telerik Academy Exam 1 @ 3 February 2015 Evening
// http://bgcoder.com/Contests/Practice/Index/205#0