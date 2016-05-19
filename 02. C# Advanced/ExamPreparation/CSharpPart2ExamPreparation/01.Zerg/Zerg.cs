namespace _01.Zerg
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Zerg
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> lettersToNumbers = new Stack<int>();
            for (int i = 0; i < input.Length - 3; i += 4)
            {
                string currentWord = input[i].ToString() + input[i + 1].ToString() + input[i + 2].ToString() + input[i + 3];
                switch (currentWord)
                {
                    case "Rawr": lettersToNumbers.Push(0);
                        break;
                    case "Rrrr": lettersToNumbers.Push(1);
                        break;
                    case "Hsst": lettersToNumbers.Push(2);
                        break;
                    case "Ssst": lettersToNumbers.Push(3);
                        break;
                    case "Grrr": lettersToNumbers.Push(4);
                        break;
                    case "Rarr": lettersToNumbers.Push(5);
                        break;
                    case "Mrrr": lettersToNumbers.Push(6);
                        break;
                    case "Psst": lettersToNumbers.Push(7);
                        break;
                    case "Uaah": lettersToNumbers.Push(8);
                        break;
                    case "Uaha": lettersToNumbers.Push(9);
                        break;
                    case "Zzzz": lettersToNumbers.Push(10);
                        break;
                    case "Bauu": lettersToNumbers.Push(11);
                        break;
                    case "Djav": lettersToNumbers.Push(12);
                        break;
                    case "Myau": lettersToNumbers.Push(13);
                        break;
                    case "Gruh": lettersToNumbers.Push(14);
                        break;

                    default: throw new ArgumentOutOfRangeException("The switch got value that isn't valid!");
                }
            }

            Console.WriteLine(ConvertToDecimal(15, lettersToNumbers));
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

// C# Part 2 - 2013/2014 @ 14 Sept 2013 - Evening
// http://bgcoder.com/Contests/Practice/Index/95#0