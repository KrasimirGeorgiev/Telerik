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
            string str = Console.ReadLine();
            if (str[str.Length - 1] == '=')
            {
                str = str.Remove(str.Length - 1);
            }
            decimal result = SolveTheProblemInBrakets(ReplaceBraketsInString(str));
            Console.WriteLine("{0:F3}", result);
        }

        private static string ReplaceBraketsInString(string str)
        {
            string result = "";
            int oppeningIndex = str.IndexOf('(', 0);
            int closingIndex = str.IndexOf(')', 0);
            while (oppeningIndex != -1)
            {
                string subString = str.Substring(oppeningIndex + 1, closingIndex - (oppeningIndex + 1));
                decimal currentResult = SolveTheProblemInBrakets(subString);
                str = str.Replace("(" + subString + ")", currentResult.ToString());

                oppeningIndex = str.IndexOf('(', 0);
                closingIndex = str.IndexOf(')', 0);
            }
            

            return str;
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

            return result;
        }
    }
}

// Telerik Academy Exam 1 @ 6 December 2013 Evening
// http://bgcoder.com/Contests/Practice/Index/107#2