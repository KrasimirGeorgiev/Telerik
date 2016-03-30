namespace _06.FourDigits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FourDigits
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int firstDigit = (inputNumber / 1000) % 10;
            int secondDigit = (inputNumber / 100) % 10;
            int thirdDigit = (inputNumber / 10) % 10;
            int fourthDigit = inputNumber % 10;
            int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;
            int reverseDigits = int.Parse(string.Join(string.Empty, inputNumber.ToString().Reverse()));
            int lastDigitFirst = int.Parse(fourthDigit.ToString() + firstDigit + secondDigit.ToString() + thirdDigit);
            int secondAndThirdigitsSwapped = int.Parse(firstDigit + thirdDigit.ToString() + secondDigit + fourthDigit.ToString());

            Console.WriteLine(sumOfDigits);
            Console.WriteLine(reverseDigits);
            Console.WriteLine(lastDigitFirst);
            Console.WriteLine(secondAndThirdigitsSwapped);
            
            //// Input Output
            //// 2011    4
            ////         1102
            ////         1201
            ////         2101
             
            //// 3333    12
            ////         3333
            ////         3333
            ////         3333
            
            //// 9876    30
            ////         6789
            ////         6987
            ////         9786
            
            //// 1230    6
            ////         321
            ////         123
            ////         1320
        }
    }
}

// Write a program that takes as input a four-digit number in format abcd(e.g. 2011) and performs the following:
// 
// Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
// Prints on the console the number in reversed order: dcba (in our example 1102) and prints the reversed number.
// Puts the last digit in the first position: dabc(in our example 1201) and prints the result.
// Exchanges the second and the third digits: acbd (in our example 2101) and prints the result.