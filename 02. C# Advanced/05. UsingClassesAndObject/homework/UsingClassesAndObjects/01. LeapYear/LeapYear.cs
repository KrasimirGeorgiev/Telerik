namespace _01.LeapYear
{
    using System;

    public class LeapYear
    {
        public static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            string result = DateTime.IsLeapYear(year) ? "Leap" : "Common";
            Console.WriteLine(result);
        }
    }
}

// Write a program that reads a year from the console and checks whether it is a leap one.