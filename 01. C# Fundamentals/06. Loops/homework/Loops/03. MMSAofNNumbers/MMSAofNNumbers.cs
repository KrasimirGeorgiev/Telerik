namespace _03.MMSAofNNumbers
{
    using System;

    public class MMSAofNNumbers
    {
        public static void Main()
        {
            decimal numbersCount = decimal.Parse(Console.ReadLine());
            decimal min = decimal.MaxValue;
            decimal max = decimal.MinValue;
            decimal sum = 0L;
            decimal average = 0M;

            for (int i = 0; i < numbersCount; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());
                min = min > currentNumber ? currentNumber : min;
                max = max < currentNumber ? currentNumber : max;
                sum += currentNumber;
            }

            average = (decimal)sum / (decimal)numbersCount;

            Console.WriteLine("min={0:F2}\nmax={1:F2}\nsum={2:F2}\navg={3:F2}", min, max, sum, average);
        }
    }
}

// Write a program that reads from the console a sequence of N integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers(displayed with 2 digits after the decimal point).
// The input starts by the number N(alone in a line) followed by N lines, each holding an integer number.
// The output is like in the examples below.