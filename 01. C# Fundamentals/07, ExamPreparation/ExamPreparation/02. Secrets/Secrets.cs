﻿namespace _02.Secrets
{
    using System;
    using System.Numerics;

    public class Secrets
    {
        public static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            number = number < 0 ? number * (-1) : number;
            string n = number.ToString();
            BigInteger specialSum = 0;
            int count = 1;
            for (int i = n.Length - 1; i >= 0; i--)
            {
                int currentNumber = n[i] - '0';
                if (count % 2 == 0)
                {
                    specialSum += currentNumber * currentNumber * count;
                }
                else
                {
                    specialSum += currentNumber * count * count;
                }

                count++;
            }

            Console.WriteLine(specialSum);
            if (specialSum % 10 == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", n);
            }
            else
            {
                string result = string.Empty;
                BigInteger lengthOfSequence = specialSum % 10;
                BigInteger r = specialSum % 26;
                for (int i = 0; i < lengthOfSequence; i++)
                {
                    result += ((char)('A' + r)).ToString();
                    r = (r + 1) % 26;
                }

                Console.WriteLine(result);
            }
        }
    }
}

// Telerik Academy Exam 1 @ 24 June 2013 Evening
// http://bgcoder.com/Contests/Practice/Index/93#1
// The tricky part here is that in the tests there are negative numbers.