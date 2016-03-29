namespace _09.ExchangeVariableValues
{
    using System;

    public class ExchangeVariableValues
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("a = {0} \nb = {1}", a, b);

            int swap = a;
            a = b;
            b = swap;

            //// Much more interesting way:
            //// a ^= b;
            //// b ^= a;
            //// a ^= b;

            Console.WriteLine("After the swap");
            Console.WriteLine("a = {0} \nb = {1}", a, b);
        }
    }
}

// Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
// Print the variable values before and after the exchange.
