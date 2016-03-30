namespace _08.PrimeCheck
{
    using System;

    public class PrimeCheck
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber <= 1)
            {
                Console.WriteLine("false");
            }
            else
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(inputNumber); i++)
                {
                    if (inputNumber % i == 0)
                    {
                        Console.WriteLine("false");
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("true");
                }
            }

            //// Input Output
            //// 1     false
            //// 2     true
            //// 23    true
            //// - 3   false
            //// 0     false
        }
    }
}

// Write a program that reads an integer N(which will always be less than 100 or equal) and uses an expression to check if given N is prime
// (i.e.it is divisible without remainder only to itself and 1).
// Note: You should check if the number is positive