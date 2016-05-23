namespace _02.MovingLetters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MovingLetters
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();
            StringBuilder result = new StringBuilder();
            int inputMaxLenght = input.Max(x => x.Length);
            for (int i = 0; i < inputMaxLenght; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (i < input[j].Length)
                    {
                        result.Append(input[j][input[j].Length - (1 + i)].ToString());
                    }
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                char currentLetter = result[i];
                int index = (i + ((char.ToLower(currentLetter) - 'a') + 1)) % result.Length;
                result = result.Remove(i, 1);
                result = result.Insert(index, currentLetter.ToString());
            }

            Console.WriteLine(result.ToString());
        }
    }
}

// C# Part 2 - 2013/2014 @ 14 Sept 2013 - Evening
// http://bgcoder.com/Contests/Practice/Index/95#1