namespace _02.MoonGravity
{
    using System;

    public class MoonGravity
    {
        public static void Main()
        {
            double weightOnMoon = double.Parse(Console.ReadLine());
            double weightOnEarth = 0.17 * weightOnMoon;

            Console.WriteLine("{0:F3}", weightOnEarth);
            //// Input Output
            //// 86    14.620
            //// 74.6  12.682
            //// 53.7  9.129
        }
    }
}

// The gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) on the Earth.
// The weight W should be read from the console.
// The output should be with exactly 3-digit precision
//
// For changing the current culture
// Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");