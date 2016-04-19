namespace _03.ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class ConsoleApplication1
    {
        public static void Main()
        {
            List<string> numbers = new List<string>();
            while (true)
            {
                string currentString = Console.ReadLine();
                if (currentString == "END")
                {
                    break;
                }

                numbers.Add(currentString);
            }

            if (numbers.Count <= 10)
            {
                BigInteger result = 1;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i % 2 != 0)
                    {
                        result *= ProductOfDigits(numbers[i]);
                    }
                }

                Console.WriteLine(result);
            }
            else
            {
                BigInteger result1 = 1;
                BigInteger result2 = 1;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i % 2 != 0 && i <= 9)
                    {
                        result1 *= ProductOfDigits(numbers[i]);
                    }
                    else if (i % 2 != 0 && i > 9)
                    {
                        result2 *= ProductOfDigits(numbers[i]);
                    }
                }

                Console.WriteLine(result1);
                Console.WriteLine(result2);
            }
        }

        private static BigInteger ProductOfDigits(string str)
        {
            BigInteger product = 1;
            foreach (char symbol in str)
            {
                int currentNumber = symbol - '0';
                if (currentNumber != 0)
                {
                    product *= currentNumber;
                }
            }

            return product;
        }
    }
}

// Telerik Academy Exam 1 @ 3 February 2015 Morning
// http://bgcoder.com/Contests/Practice/Index/204#2