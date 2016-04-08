namespace _13.DecimalToHex
{
    using System;
    using System.Collections.Generic;

    public class DecimalToHex
    {
        public static void Main()
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            string result = ConvertDecimalToHex(decimalNumber);
            Console.WriteLine(result);
        }

        private static string ConvertDecimalToHex(long number)
        {
            Stack<char> result = new Stack<char>();
            long decimalNumber = number;
            while (decimalNumber > 0)
            {
                long currentHexNumber = decimalNumber % 16;
                decimalNumber /= 16;
                if (currentHexNumber > 9)
                {
                    result.Push(Convert.ToChar((currentHexNumber - 10) + 'A'));
                }
                else
                {
                    result.Push(Convert.ToChar(currentHexNumber.ToString()));
                }
            }

            string resultStr = string.Join(string.Empty, result);
            return resultStr;
        }
    }
}

// Using loops write a program that converts an integer number to its hexadecimal representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.