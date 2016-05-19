namespace _08.SumIntegers
{
    using System;
    using System.Linq;

    public class SumIntegers
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(FindSum(input));
        }

        private static long FindSum(string input)
        {
            long result = 0;
            int[] numbers = input.Split().Select(x => int.Parse(x)).ToArray();
            foreach (int number in numbers)
            {
                result += number;
            }

            return result;
        }
    }
}

// You are given a sequence of positive integer values written into a string, separated by spaces. 
// Write a function that reads these values from given string and calculates their sum. 
// Write a program that reads a string of positive integers separated by spaces and prints their sum.