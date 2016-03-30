namespace _11.ThirdBit
{
    using System;

    public class ThirdBit
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            var bit = (inputNumber & (1 << 2)) != 0;
            Console.WriteLine("{0}", Convert.ToInt32(bit));
            //// Input Output
            //// 15    1
            //// 1024  0
        }
    }
}

// Using bitwise operators, write a program that uses an expression to find the value of the bit at index 3 of an unsigned integer read from the console.
// The bits are counted from right to left, starting from bit 0.
// The result of the expression should be either 1 or 0. Print it on the console.
