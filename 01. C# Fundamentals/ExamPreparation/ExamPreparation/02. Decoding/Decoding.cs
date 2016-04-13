namespace _02.Decoding
{
    using System;

    public class Decoding
    {
        public static void Main()
        {
            int salt = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int strLength = str.Length;

            for (int i = 0; i < strLength; i++)
            {
                char currentChar = str[i];
                decimal result = 0;
                if (currentChar == '@')
                {
                    break;
                }

                if (char.IsLetter(currentChar))
                {
                    result = (currentChar * salt) + 1000M;
                }
                else if (char.IsDigit(currentChar))
                {
                    result = currentChar + salt + 500M;
                }
                else
                {
                    result = currentChar - (decimal)salt;
                }

                if (i % 2 == 0)
                {
                    result /= 100;
                    Console.WriteLine("{0:F2}", result);
                }
                else
                {
                    result *= 100;
                    Console.WriteLine(result);
                }
            }
        }
    }
}

// Telerik Academy Exam 1 @ 3 February 2015 Morning
// http://bgcoder.com/Contests/Practice/Index/204#1