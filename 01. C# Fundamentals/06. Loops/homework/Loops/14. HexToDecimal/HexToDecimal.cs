namespace _14.HexToDecimal
{
    using System;

    public class HexToDecimal
    {
        public static void Main()
        {
            string hexNumber = Console.ReadLine();
            long result = ConvertHexToDecimal(hexNumber);
            Console.WriteLine(result);
        }

        private static long ConvertHexToDecimal(string number)
        {
            string hexNumber = number;
            long result = 0;
            for (int i = 0, hexNumberLength = hexNumber.Length; i < hexNumberLength; i++)
            {
                if (char.IsDigit(hexNumber[hexNumberLength - (i + 1)]))
                {
                    result += (hexNumber[hexNumberLength - (i + 1)] - '0') * NumberOnPowerOf(16, i);
                }
                else
                {
                    result += ((hexNumber[hexNumberLength - (i + 1)] - 'A') + 10) * NumberOnPowerOf(16, i);
                }
            }

            return result;
        }

        private static long NumberOnPowerOf(int number, int powerOf)
        {
            long result = 1L;
            for (int i = 0; i < powerOf; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}

// Using loops write a program that converts a hexadecimal integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.