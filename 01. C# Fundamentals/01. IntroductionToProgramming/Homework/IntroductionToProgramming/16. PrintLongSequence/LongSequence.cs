namespace _16.PrintLongSequence
{
    using System;

    public class LongSequence
    {
        public static void Main()
        {
            for (int i = 2; i < 1002; i++)
            {
                int currentMemeber = i % 2 == 0 ? i : -i;
                Console.WriteLine(currentMemeber);
            }
        }
    }
}

// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
