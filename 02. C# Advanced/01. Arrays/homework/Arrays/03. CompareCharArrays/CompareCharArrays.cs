namespace _03.CompareCharArrays
{
    using System;

    public class CompareCharArrays
    {
        public static void Main()
        {
            char[] firstArr = Console.ReadLine().ToCharArray();
            char[] secondArr = Console.ReadLine().ToCharArray();
            Console.WriteLine(CompareCharArraysLexicographically(firstArr, secondArr));
        }

        private static string CompareCharArraysLexicographically(char[] firstArr, char[] secondArr) // Can have a problem with Uppercase and Lowercase letters
        {
            string result = "=";
            int n = Math.Min(firstArr.Length, secondArr.Length);
            for (int i = 0; i < n; i++)
            {
                if (firstArr[i] > secondArr[i])
                {
                    result = ">";
                    break;
                }
                else if (firstArr[i] < secondArr[i])
                {
                    result = "<";
                    break;
                }
            }

            if (result == "=")
            {
                if (firstArr.Length > secondArr.Length)
                {
                    result = ">";
                }

                if (firstArr.Length < secondArr.Length)
                {
                    result = "<";
                }
            }

            return result;
        }
    }
}

// Write a program that compares two char arrays lexicographically (letter by letter).