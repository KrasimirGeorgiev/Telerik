namespace _01.OddOrEven
{
    using System;

    public class OddOrEven
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            string oddOrEven = string.Empty;
            oddOrEven = inputNumber % 2 == 0 ? "even" : "odd";

            Console.WriteLine("{0} {1}", inputNumber, oddOrEven);
        }
    }
}

// Write a program that reads an integer from the console, uses an expression to check if given integer is odd or even, and prints 
// "even NUMBER" or "odd NUMBER", where you should print the input number's value instead of NUMBER.