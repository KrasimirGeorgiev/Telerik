namespace _05.ThirdDigit
{
    using System;

    public class ThirdDigit
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber.ToString().Length < 3)
            {
                Console.WriteLine("false 0");
            }
            else
            {
                int thirdDigit = (inputNumber / 100) % 10;
                if (thirdDigit == 7)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false {0}", thirdDigit);
                }
            }

            // Input   Output
            // 5       false 0
            // 701     true
            // 9703    true
            // 877     false 8
            // 777877  false 8
            // 9999799 true
        }
    }
}

// Write a program that reads an integer N from the console and prints true if the third digit of the N is 7, 
// or "false THIRD_DIGIT", where you should print the third digits of N.
// 
// The counting is done from right to left, meaning 123456's third digit is 4.