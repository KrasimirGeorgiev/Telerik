namespace _05.BiggestOf3
{
    using System;

    public class BiggestOf3
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            double maxNumber = Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber);
            Console.WriteLine(maxNumber);
        }
    }
}

// Write a program that finds the biggest of three numbers that are read from the console.