namespace _07.QuotesInStrings
{
    using System;

    public class QuotesInStrings
    {
        public static void Main()
        {
            string firstWayForEscaping = "The \"use\" of quotations causes difficulties."; // use '\' to escape symbols
            string secondWayForEscaping = @"The ""use"" of quotations causes difficulties."; // use '@' before the string and escape a symbol by using it twice

            Console.WriteLine(firstWayForEscaping);
            //// Console.WriteLine(secondWayForEscaping);
        }
    }
}

// Write a program that outputs The "use" of quotations causes difficulties.