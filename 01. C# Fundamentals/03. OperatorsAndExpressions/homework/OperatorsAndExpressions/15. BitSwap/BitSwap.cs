namespace _15.BitSwap
{
    using System;
    using System.Numerics;
   

    public class BitSwap
    {
        public static void Main()
        {
            BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());
            long p = long.Parse(Console.ReadLine());
            long q = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString((long)inputNumber, 2);
            binaryNumber = binaryNumber.Length < 32 ? new string('0', 32 - binaryNumber.Length) + binaryNumber : binaryNumber; // Adding zeros if the number's length in binary is less than 32 digits
            char[] arrOfBinaryNumber = binaryNumber.ToCharArray();
            ulong result = Convert.ToUInt64(ExchangeBitsInArr(arrOfBinaryNumber, p, q, k), 2);

            Console.WriteLine(result);
            
            //// Input           Output
            //// 1140867093
            //// 3
            //// 24
            //// 3               1107312677

            //// 4294901775
            //// 24
            //// 3
            //// 3               4194238527

            //// 2369124121
            //// 2
            //// 22
            //// 10              1907751121
        }

        private static string ExchangeBitsInArr(char[] arr, long p, long q, long k)
        {
            int arrLength = arr.Length;
            char thirdBit = arr[arrLength - (p + 1)];
            char fourthBit = arr[arrLength - (p + 2)];
            char fifthBit = arr[arrLength - ((p + k - 1) + 1)];

            char bit24 = arr[arrLength - (q + 1)];
            char bit25 = arr[arrLength - (q + 2)];
            char bit26 = arr[arrLength - ((q + k - 1) + 1)];

            arr[arrLength - (p + 1)] = bit24;
             arr[arrLength - (p + 2)] = bit25;
            arr[arrLength - ((p + k - 1) + 1)] = bit26;

            arr[arrLength - (q + 1)] = thirdBit;
            arr[arrLength - (q + 2)] = fourthBit;
            arr[arrLength - ((q + k - 1) + 1)] = fifthBit;

            string result = string.Join(string.Empty, arr);
            return result;
        }
    }
}

// Write a program that reads 4 numbers n, p, q and k and than swaps bits { p, p+1, …, p+k-1}
// with bits { q, q+1, …, q+k-1} of n.Print the resulting integer on the console.