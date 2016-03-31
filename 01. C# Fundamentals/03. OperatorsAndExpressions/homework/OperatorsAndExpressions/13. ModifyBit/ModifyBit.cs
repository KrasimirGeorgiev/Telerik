namespace _13.ModifyBit
{
    using System;
    using System.Linq;

    public class ModifyBit
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string numberInBinary = Convert.ToString(number, 2);
            numberInBinary = numberInBinary.Length < 16 ? new string('0', 16 - numberInBinary.Length) + numberInBinary : numberInBinary;
            int position = int.Parse(Console.ReadLine());
            int bitValue = int.Parse(Console.ReadLine());
            numberInBinary = string.Join(string.Empty, numberInBinary.Reverse());
            numberInBinary = numberInBinary.Remove(position, 1);
            numberInBinary = numberInBinary.Insert(position, bitValue.ToString());
            numberInBinary = string.Join(string.Empty, numberInBinary.Reverse());
            int result = Convert.ToInt32(numberInBinary, 2);

            Console.WriteLine(result);

            //// Sample tests
            //// Input Binary representation Modified value      Output
            //// 5
            //// 2
            //// 0     00000000 00000101     00000000 00000001   1

            //// 0
            //// 9
            //// 1     00000000 00000000     00000010 00000000   512

            //// 15
            //// 1
            //// 1     00000000 00001111     00000000 00001111   15

            //// 5343
            //// 7
            //// 0     00010100 11011111     00010100 01011111   5215

            //// 62241
            //// 11
            //// 0     11110011 00100001     11110011 00100001   62241
        }
    }
}

// We are given an integer number N(read from the console), a bit value v(read from the console as well) 
// (v = 0 or 1) and a position P(read from the console). Write a sequence of operators(a few lines of C# code) 
// that modifies N to hold the value v at the position P from the binary representation of N while preserving all other bits in N. 
// Print the resulting number on the console.