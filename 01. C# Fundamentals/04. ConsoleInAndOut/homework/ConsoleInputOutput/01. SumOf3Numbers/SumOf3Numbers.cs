namespace _01.SumOf3Numbers
{
    using System;

    public class SumOf3Numbers
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            double sum = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine(sum);

            //// Input   Output
            //// 1
            //// 2
            //// 3       6
            
            //// - 2
            //// 0
            //// 3       1
            
            //// 5.5
            //// 4.5
            //// 20.1    30.1
        }
    }
}

// Write a program that reads 3 real numbers from the console and prints their sum.