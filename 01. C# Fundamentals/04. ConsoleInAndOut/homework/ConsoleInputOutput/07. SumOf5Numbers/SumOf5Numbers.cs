namespace _07.SumOf5Numbers
{
    using System;

    public class SumOf5Numbers
    {
        public static void Main()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);

            //// Input   Output
            //// 1
            //// 2
            //// 3
            //// 4
            //// 5       15
            
            //// - 1
            //// 2
            //// - 3
            //// 4
            //// 10      12
            
            //// 0
            //// 0
            //// 0
            //// 0
            //// 0       0
        }
    }
}

// Write a program that reads 5 integer numbers from the console and prints their sum.