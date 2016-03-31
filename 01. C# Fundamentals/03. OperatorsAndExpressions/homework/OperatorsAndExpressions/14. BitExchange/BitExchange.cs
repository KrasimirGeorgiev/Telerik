namespace _14.BitExchange
{
    using System;

    public class BitExchange
    {
        public static void Main()
        {
            long inputNumber = long.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(inputNumber, 2);
            binaryNumber = binaryNumber.Length < 32 ? new string('0', 32 - binaryNumber.Length) + binaryNumber : binaryNumber; // Adding zeros if the number's length in binary is less than 32 digits
            char[] arrOfBinaryNumber = binaryNumber.ToCharArray();
            long result = Convert.ToInt64(ExchangeBitsInArr(arrOfBinaryNumber), 2);

            Console.WriteLine(result);

            //// Input       Output
            //// 1140867093  1107312677
            //// 255406592   137966136
            //// 4294901775  4194238527
            //// 5351        67114183
            //// 2369124121  2335569705
        }

        private static string ExchangeBitsInArr(char[] arr)
        {
            int arrLength = arr.Length;
            char thirdBit = arr[arrLength - 4];
            char fourthBit = arr[arrLength - 5]; 
            char fifthBit = arr[arrLength - 6]; 

            char bit24 = arr[arrLength - 25];
            char bit25 = arr[arrLength - 26];
            char bit26 = arr[arrLength - 27];

            arr[arrLength - 4] = bit24;
            arr[arrLength - 5] = bit25;
            arr[arrLength - 6] = bit26;

            arr[arrLength - 25] = thirdBit;
            arr[arrLength - 26] = fourthBit;
            arr[arrLength - 27] = fifthBit;

            string result = string.Join(string.Empty, arr);
            return result;
        }
    }
}

// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer(read from the console).