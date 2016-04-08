namespace _01.NumbersfromOneToN
{
    using System;
    using System.Text;

    public class NumbersfromOneToN
    {
        public static void Main()
        {
            int inputN = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= inputN; i++)
            {
                result.Append(i);
                result.Append(" ");
            }

            result.Length = result.Length - 1;
            Console.WriteLine(result.ToString());
        }
    }
}

// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to N inclusive, on a single line, 
// separated by a whitespace.
