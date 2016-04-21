namespace _03.Enigmanation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Enigmanation
    {
        public static void Main()
        {
            string str = string.Join("", Console.ReadLine().Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            string substr = ReplaceBraketsInString(str);
            Console.WriteLine(substr);
            decimal someNumber = SolveTheProblemInBrakets(substr);
            Console.WriteLine(someNumber);
        }

        private static string ReplaceBraketsInString(string str)
        {
            string result = "";
            int oppeningIndex = 0;
            int closingIndex = 0;
            while (oppeningIndex != -1)
            {
                int oppeningBraketIndex = str.IndexOf('(', oppeningIndex);
                int closingBraketIndex = str.IndexOf(')', closingIndex);
                string substr = str.Substring(oppeningBraketIndex + 1, closingBraketIndex - (oppeningBraketIndex + 1));

            }

            return result;
        }
        private static decimal SolveTheProblemInBrakets(string str)
        {
            List<string> strings = new List<string>();
            decimal result = 0M;
            string currentString = "";
            for (int i = 0; i < str.Length; i++)
            {
                char currentSymbol = str[i];
                if (char.IsDigit(currentSymbol))
                {
                    currentString += currentSymbol.ToString();
                }
                else
                {
                    strings.Add(currentString);
                    currentString = "";
                    strings.Add(currentSymbol.ToString());
                }

                if (i == str.Length - 1)
                {
                    strings.Add(currentString);
                }
            }

            result = int.Parse(strings[0]);
            for (int i = 1; i < strings.Count; i += 2)
            {
                if (strings[i] == "+")
                {
                    result += (decimal)(int.Parse(strings[i + 1]));
                }
                else if (strings[i] == "-")
                {
                    result -= (decimal)(int.Parse(strings[i + 1]));
                }
                else if (strings[i] == "*")
                {
                    result *= (decimal)(int.Parse(strings[i + 1]));
                }
                else if (strings[i] == "%")
                {
                    result %= (decimal)(int.Parse(strings[i + 1]));
                }
            }

            Console.WriteLine(string.Join("", strings));
            return result;
        }
    }
}

// Telerik Academy Exam 1 @ 6 December 2013 Evening
// http://bgcoder.com/Contests/Practice/Index/107#2