namespace _14.PrintTheASCIITable
{
    using System;

    public class PrintTheASCIITable
    {
        public static void Main()
        {
            for (int i = 33; i <= 126; i++)
            {
                Console.Write((char)i);
            }

            Console.WriteLine();
        }
    }
}

// Find online more information about ASCII(American Standard Code for Information Interchange) and write a program that prints 
// the visible characters of the ASCII table on the console(characters from 33 to 126 including).
// Print them on a single line
