using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class Test
    {
        public static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToCatNumeral(input));
        }

        private static string DecimalToCatNumeral(long number)
        {
            Stack<string> reverseResult = new Stack<string>();
            long inputNumber = number;
            string result = "";

            while (inputNumber != 0)
            {
                long remainingNumber = inputNumber % 23;
                string remNumToCatNum = ((char)(remainingNumber + 'a')).ToString();
                inputNumber /= 23;
                reverseResult.Push(remNumToCatNum);
            }

            while (reverseResult.Count > 0)
            {
                string currentLetter = reverseResult.Pop();
                result += currentLetter;
            }

            return result;
        }
    }
}
