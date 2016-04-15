namespace _01.Printing
{
    using System;

    public class Printing
    {
        public static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal s = decimal.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());
            decimal result = (((decimal)n * s) / 500M) * p;

            Console.WriteLine("{0:F2}", result);
        }
    }
}

// Telerik Academy Exam 1 @ 2 February 2015 Morning
// http://bgcoder.com/Contests/Practice/Index/202#0