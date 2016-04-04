namespace _09.SumOfNNumbers
{
    using System;

    public class SumOfNNumbers
    {
        public static void Main()
        {
            double sum = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}

// Write a program that enters a number N and after that enters more N numbers and calculates and prints their sum.