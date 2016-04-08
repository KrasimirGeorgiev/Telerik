namespace _12.DecimalToBinary
{
    using System;
    using System.Collections.Generic;

    public class DecimalToBinary
    {
        public static void Main()
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            string result = ConvertDecimalToBinary(decimalNumber);
            Console.WriteLine(result);
        }

        private static string ConvertDecimalToBinary(long number)
        {
            if (number == 0)
            {
                return "0";
            }

            Stack<long> reverseResult = new Stack<long>();
            long decimalNumber = number;

            while (decimalNumber > 0)
            {
                reverseResult.Push(decimalNumber % 2);
                decimalNumber /= 2;
            }

            string result = string.Join(string.Empty, reverseResult);
            return result;
        }
    }
}

// Using loops write a program that converts an integer number to its binary representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.