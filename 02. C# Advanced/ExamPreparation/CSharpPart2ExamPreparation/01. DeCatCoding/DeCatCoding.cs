namespace _01.DeCatCoding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DeCatCoding
    {
        public static void Main()
        {
            string[] encodedMessage = Console.ReadLine().Split().ToArray();
            StringBuilder result = new StringBuilder();
            foreach (string word in encodedMessage)
            {
                result.Append(TransformFromDecimal(26, TransformToDecimal(21, word)));
                result.Append(" ");
            }

            result.Length = result.Length - 1;
            Console.WriteLine(result.ToString());
        }

        private static ulong TransformToDecimal(int whatSystem, string str)
        {
            // number * (system ^ possition)
            ulong result = 0;
            int count = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                char currentSymbol = str[i];
                if (char.IsLetter(currentSymbol))
                {
                    result += (ulong)(char.ToLower(currentSymbol) - 'a') * NumberOnPowerOf(whatSystem, count);
                }

                count++;
            }

            return result;
        }

        private static string TransformFromDecimal(int whatSystem, ulong number)
        {
            Stack<char> result = new Stack<char>();
            while (number != 0)
            {
                result.Push((char)('a' + (number % (ulong)whatSystem)));
                number /= (uint)whatSystem;
            }

            return string.Join(string.Empty, result);
        }

        private static ulong NumberOnPowerOf(int number, int powerOf)
        {
            ulong result = 1;
            for (int i = 0; i < powerOf; i++)
            {
                result *= (ulong)number;
            }

            return result;
        }
    }
}

// The incoming message is in encoded with 21 numeral system (a-u), decode it to 26 numberal (a-z) 