namespace _11.BinaryToDecimal
{
    using System;

    public class BinaryToDecimal
    {
        public static void Main()
        {
            string binaryNumber = Console.ReadLine();
            long numberToDecimal = ConvertBinaryToDecimal(binaryNumber);
            Console.WriteLine(numberToDecimal);
        }

        private static long ConvertBinaryToDecimal(string binaryNumber)
        {
            long result = 0;
            for (int i = 0, binaryNumberLength = binaryNumber.Length; i < binaryNumberLength; i++)
            {
                result += (binaryNumber[binaryNumberLength - (i + 1)] - '0') * NumberOnPowerOf(2, i);
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

// Using loops write a program that converts a binary integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.