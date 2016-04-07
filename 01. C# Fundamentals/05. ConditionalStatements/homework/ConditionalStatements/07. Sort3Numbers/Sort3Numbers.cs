namespace _07.Sort3Numbers
{
    using System;

    public class Sort3Numbers
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                Console.Write(firstNumber + " ");
                if (secondNumber >= thirdNumber)
                {
                    Console.Write(secondNumber + " " + thirdNumber);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(thirdNumber + " " + secondNumber);
                    Console.WriteLine();
                }
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                Console.Write(secondNumber + " ");
                if (firstNumber >= thirdNumber)
                {
                    Console.Write(firstNumber + " " + thirdNumber);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(thirdNumber + " " + firstNumber);
                    Console.WriteLine();
                }
            }
            else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber)
            {
                Console.Write(thirdNumber + " ");
                if (firstNumber >= secondNumber)
                {
                    Console.Write(firstNumber + " " + secondNumber);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(secondNumber + " " + firstNumber);
                    Console.WriteLine();
                }
            }

        }
    }
}

// Write a program that enters 3 real numbers and prints them sorted in descending order.
// Use nested if statements.
// Don’t use arrays and the built-in sorting functionality.