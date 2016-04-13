namespace _11.ThirdBit
{
    using System;

    public class ThirdBit
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine((n / 8) % 2);
            //// Input Output
            //// 15    1
            //// 1024  0
        }
    }
}

// Using bitwise operators, write a program that uses an expression to find the value of the bit at index 3 of an unsigned integer read from the console.
// The bits are counted from right to left, starting from bit 0.
// The result of the expression should be either 1 or 0. Print it on the console.
