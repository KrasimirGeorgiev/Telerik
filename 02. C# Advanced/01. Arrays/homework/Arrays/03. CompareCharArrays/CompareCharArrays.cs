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

        private static char CompareCharArraysLexicographically(char[] firstArr, char[] secondArr) // Can have a problem with Uppercase and Lowercase letters
        {
            if (firstArr.Length < secondArr.Length)
            {
                return '<';
            }
            else if (secondArr.Length < firstArr.Length)
            {
                return '>';
            }
            else
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    char firstArrCurrentChar = firstArr[i];
                    char secondArrCurrentChar = firstArr[i];
                    if (char.IsLetter(firstArrCurrentChar))
                    {
                        firstArrCurrentChar = char.ToLower(firstArrCurrentChar);
                    }

                    if (char.IsLetter(secondArrCurrentChar))
                    {
                        secondArrCurrentChar = char.ToLower(secondArrCurrentChar);
                    }

                    if (firstArrCurrentChar > secondArrCurrentChar)
                    {
                        return '>';
                    }
                    else if (secondArrCurrentChar > firstArrCurrentChar)
                    {
                        return '<';
                    }
                }

                return '=';
            }
        }
    }
}

// Write a program that compares two char arrays lexicographically (letter by letter).