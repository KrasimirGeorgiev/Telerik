namespace _01.MultiverseCommunication
{
    using System;
    using System.Collections.Generic;

    public class MultiverseCommunication
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> numbersToDecimalValues = new Stack<int>();
            for (int i = 0; i < input.Length - 2; i += 3)
            {
                string substring = char.ToLower(input[i]).ToString() + char.ToLower(input[i + 1]).ToString() + char.ToLower(input[i + 2]).ToString();
                switch (substring)
                {
                    case "chu": numbersToDecimalValues.Push(0);
                        break;
                    case "tel": numbersToDecimalValues.Push(1);
                        break;
                    case "oft": numbersToDecimalValues.Push(2);
                        break;
                    case "iva": numbersToDecimalValues.Push(3);
                        break;
                    case "emy": numbersToDecimalValues.Push(4);
                        break;
                    case "vnb": numbersToDecimalValues.Push(5);
                        break;
                    case "poq": numbersToDecimalValues.Push(6);
                        break;
                    case "eri": numbersToDecimalValues.Push(7);
                        break;
                    case "cad": numbersToDecimalValues.Push(8);
                        break;
                    case "k-a": numbersToDecimalValues.Push(9);
                        break;
                    case "iia": numbersToDecimalValues.Push(10);
                        break;
                    case "ylo": numbersToDecimalValues.Push(11);
                        break;
                    case "pla": numbersToDecimalValues.Push(12);
                        break;

                    default: throw new ArgumentOutOfRangeException("The switch got value that is not valid");
                }
            }

            Console.WriteLine(NumberToDecimal(13, numbersToDecimalValues));
        }

        private static long NumberToDecimal(int inputNumeralSystem, Stack<int> stack)
        {
            long result = 0;
            int count = 0;
            foreach (int number in stack)
            {
                result += number * NumberOnPowerOf(count, inputNumeralSystem); 
                count++;
            }

            return result;
        }

        private static long NumberOnPowerOf(int powerOf, int number)
        {
            long result = 1;
            for (int i = 0; i < powerOf; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}

// Exam C# Part 2 - 2013/2014 @ 14 Sept 2013 - Morning
// http://bgcoder.com/Contests/Practice/Index/94#0