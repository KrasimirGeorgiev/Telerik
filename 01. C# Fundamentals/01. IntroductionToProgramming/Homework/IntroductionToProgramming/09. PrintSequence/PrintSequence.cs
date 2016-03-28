namespace _09.PrintSequence
{
    using System;

    public class PrintSequence
    {
        public static void Main()
        {
            for (int i = 2; i < 12; i++)
            {
                int currentMemeber = i % 2 == 0 ? i : -i;
                Console.WriteLine(currentMemeber);
            }
        }
    }
}

// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7... each on a separate line