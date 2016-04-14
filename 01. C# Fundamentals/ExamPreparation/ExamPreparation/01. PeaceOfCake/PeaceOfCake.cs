namespace _01.PeaceOfCake
{
    using System;

    public class PeaceOfCake
    {
        public static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());
            long nominator = (a * d) + (c * b);
            long denominator = b * d;
            decimal result = nominator / (decimal)denominator;
            if (result > 1)
            {
                Console.WriteLine((long)result);
            }
            else
            {
                Console.WriteLine("{0:F22}", result);
            }

            Console.WriteLine("{0}/{1}", nominator, denominator);
        }
    }
}

// Telerik Academy Exam 1 @ 5 December 2013 Evening
// http://bgcoder.com/Contests/Practice/Index/105#0