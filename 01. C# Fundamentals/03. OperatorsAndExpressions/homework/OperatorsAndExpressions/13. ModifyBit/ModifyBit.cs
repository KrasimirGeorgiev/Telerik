namespace _13.ModifyBit
{
    using System;

    public class ModifyBit
    {
        public static void Main()
        {
            ulong numberN = ulong.Parse(Console.ReadLine());
            int positionP = int.Parse(Console.ReadLine());
            byte bitValueV = byte.Parse(Console.ReadLine());
            ulong mask = 1;
            ulong numberAndMask;

            if (bitValueV == 0)
            {
                numberAndMask = ~(mask << positionP) & numberN;
            }
            else
            {
                numberAndMask = numberN | mask << positionP;
            }

            Console.WriteLine(numberAndMask);

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