namespace _02.BonusScore
{
    using System;

    public class BonusScore
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            if (1 <= input && input <= 3)
            {
                input *= 10;
                Console.WriteLine(input);
            }
            else if (4 <= input && input <= 6)
            {
                input *= 100;
                Console.WriteLine(input);
            }
            else if (7 <= input && input <= 9)
            {
                input *= 1000;
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}

// Write a program that applies bonus score to given score in the range[1…9] by the following rules:
// If the score is between 1 and 3, the program multiplies it by 10.
// If the score is between 4 and 6, the program multiplies it by 100.
// If the score is between 7 and 9, the program multiplies it by 1000.
// If the score is less than 0 or more than 9, the program prints "invalid score".