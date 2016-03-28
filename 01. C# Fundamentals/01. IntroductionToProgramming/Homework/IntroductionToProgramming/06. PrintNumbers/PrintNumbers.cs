namespace _06.PrintNumbers
{
    using System;

    public class PrintNumbers
    {
        public static void Main()
        {
            for (int i = 1; i <= 9; i += 4)
            {
                Console.WriteLine(Convert.ToString(i, 2)); // Converts decimal to binary
            }
        }
    }
}

// You program should print the numbers 1, 101 and 1001 on three separate lines.