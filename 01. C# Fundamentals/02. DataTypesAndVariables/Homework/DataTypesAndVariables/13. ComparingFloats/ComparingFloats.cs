namespace _13.ComparingFloats
{
    using System;

    public class ComparingFloats
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double comparingfloatNumbers = Math.Abs(Math.Max(firstNumber, secondNumber) - Math.Min(firstNumber, secondNumber));
            string areEqual = "";
            double precision = 0.000001;

            areEqual = comparingfloatNumbers < precision ? "true" : "false";

            Console.WriteLine(areEqual);

            //// Sample tests
            //// 5.3 and 6.01 answer should be false
            //// 5.00000001 and 5.00000003 answer should be true
            //// 5.00000005 and 5.00000001 answer should be true
            //// -0.0000007 and 0.00000007   answer should be true
            //// -4.999999 and -4.999998 answer should be false
            //// 4.999999 and 4.999998 answer should be false
        }
    }
}

// Description
// Write a program that safely compares two floating-point numbers(double) with precision eps = 0.000001.
// Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
// Input
// On the first line you will receive the first floating-point number
// On the second line you will receive the second floating-point number
// Output
// Print true if the numbers are equal or false if they are not
