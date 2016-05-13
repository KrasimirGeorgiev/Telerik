namespace _15.PrimeNumbers
{
    using System;

    public class PrimeNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n + 1];
            int count = 2;
            for (int i = 2; i < n + 1; i++)
            {
                arr[i] = count;
                count++;
            }

            EratosthenesAlgorithmForPrimeNumbers(arr);
            for (int i = arr.Length - 1; i >= 2; i--)
            {
                if (arr[i] != -1)
                {
                    Console.WriteLine(arr[i]);
                    break;
                }
            }
        }

        private static void EratosthenesAlgorithmForPrimeNumbers(int[] numbers)
        {
            for (int i = 2; i < Math.Sqrt(numbers.Length); i++)
            {
                if (numbers[i] != -1)
                {
                    for (int j = NumberOnPowerOf(i, 2); j < numbers.Length; j += i)
                    {
                        numbers[j] = -1;
                    }
                }
            }
        }

        private static int NumberOnPowerOf(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}

// Write a program that finds all prime numbers in the range [1 ... N]. 
// Use the Sieve of Eratosthenes algorithm. The program should print the biggest prime number which is <= N.
// Personal notes:
// Pseudo code (of Sieve of Eratosthenes algorithm)
// Input: an integer n > 1
// Let A be an array of Boolean values, indexed by integers 2 to n,
// initially all set to true.
//  
// for i = 2, 3, 4, ..., not exceeding √n:
//   if A[i] is true:
//     for j = i^2, i^2+i, i^2+2i, i^2+3i, ..., not exceeding n :
//       A[j] := false
//  
// Output: all i such that A[i] is true.