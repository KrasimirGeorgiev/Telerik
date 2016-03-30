namespace _12.NthBit
{
    using System;

    public class NthBit
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            var bit = (n & (1 << p)) != 0;
            Console.WriteLine("{0}", Convert.ToInt32(bit));
            
            //// Input  Binary representation  Output
            //// 5
            //// 2      00000000 00000101      1
            //// 0
            //// 9      00000000 00000000      0
            //// 15
            //// 1      00000000 00001111      1
            //// 5343   
            //// 7      00010100 11011111      1
            //// 62241
            //// 11     11110011 00100001      0
        }
    }
}

// Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit.