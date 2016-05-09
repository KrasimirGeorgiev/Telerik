namespace _01.AllocateArray
{
    using System;

    public class AllocateArray
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = i * 5;
            }

            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}

// Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 and the prints the obtained array on the console.