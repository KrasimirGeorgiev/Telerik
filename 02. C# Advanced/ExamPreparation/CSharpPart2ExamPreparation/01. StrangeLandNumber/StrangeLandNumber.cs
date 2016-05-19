namespace _01.StrangeLandNumber
{
    using System;
    using System.Collections.Generic;

    public class StrangeLandNumber
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> stringsToDecimal = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                string currentString = input[i].ToString();
                if (currentString == "f")
                {
                    stringsToDecimal.Push(0);
                }
                else if (currentString == "b")
                {
                    stringsToDecimal.Push(1);
                    i += 2;
                }
                else if (currentString == "o")
                {
                    stringsToDecimal.Push(2);
                    i += 4;
                }
                else if (currentString == "m")
                {
                    stringsToDecimal.Push(3);
                    i += 6;
                }
                else if (currentString == "l")
                {
                    stringsToDecimal.Push(4);
                    i += 5;
                }
                else if (currentString == "p")
                {
                    stringsToDecimal.Push(5);
                    i += 3;
                }
                else if (currentString == "h")
                {
                    stringsToDecimal.Push(6);
                    i += 1;
                }
            }

            Console.WriteLine(ConvertToDecimal(7, stringsToDecimal));
        }

        private static long ConvertToDecimal(int numeralSystem, Stack<int> numbers)
        {
            long result = 0;
            int count = 0;
            foreach (int number in numbers)
            {
                result += number * NumberOnPowerOf(numeralSystem, count);
                count++;
            }

            return result;
        }

        private static long NumberOnPowerOf(int number, int power)
        {
            long result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}

// C# Part 2 - 2013/2014 @ 24 Jan 2014 - Evening
// http://bgcoder.com/Contests/Practice/Index/143#0