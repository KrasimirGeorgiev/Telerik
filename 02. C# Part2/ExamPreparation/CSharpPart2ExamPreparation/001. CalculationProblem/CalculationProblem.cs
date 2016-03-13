namespace _001.CalculationProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CalculationProblem
    {
        public static void Main()
        {
            string[] inputSplit = Console.ReadLine().Split().ToArray();
            long result = 0;
            for (int i = 0; i < inputSplit.Length; i++)
            {
                string currentCatNumber = inputSplit[i];
                result += CatNumeralToDecimal(currentCatNumber);
            }

            Console.WriteLine("{0} = {1}", DecimalToCatNumeral(result), result);
        }

        private static long CatNumeralToDecimal(string input)
        {
            long result = 0;
            char[] inputToCharArr = input.ToCharArray();
            long count = 0;
            for (long i = inputToCharArr.Length - 1; i >= 0; i--)
            {
                result += (inputToCharArr[i] - 'a') * NumberOnPowerOf(23, count);
                count++;
            }

            return result;
        }

        private static long NumberOnPowerOf(long number, long powerOf)
        {
            long result = 1;
            for (long i = 0; i < powerOf; i++)
            {
                result *= number;
            }

            return result;
        }

        private static string DecimalToCatNumeral(long number)
        {
            Stack<string> reverseResult = new Stack<string>();
            long inputNumber = number;
            string result = string.Empty;

            while (inputNumber != 0)
            {
                long remainingNumber = inputNumber % 23;
                string remNumToCatNum = ((char)(remainingNumber + 'a')).ToString();
                inputNumber /= 23;
                reverseResult.Push(remNumToCatNum);
            }

            while (reverseResult.Count > 0)
            {
                string currentLetter = reverseResult.Pop();
                result += currentLetter;
            }

            return result;
        }
    }
}

// Cats have secret numeral system - 23 based numeral system (a-w)
// You will receive a set on letter-numbers(strings)
// on one line separated with a single space ‘ ‘. Sum all of the letter-numbers and print out the resulting
// sum both in the 23-based system and decimal system