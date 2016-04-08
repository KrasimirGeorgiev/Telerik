namespace _02.NotDivisibleNumbers
{
    using System;
    using System.Text;

    public class NotDivisibleNumbers
    {
        public static void Main()
        {
            int inputN = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= inputN; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }

                result.Append(i);
                result.Append(" ");
            }

            result.Length = result.Length - 1;
            Console.WriteLine(result.ToString());
        }
    }
}

// Write a program that reads from the console a positive integer N and prints all the numbers from 1 to N not divisible by 3 or 7, on a single line, 
// separated by a space.