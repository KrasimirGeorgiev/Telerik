namespace _02.MagicWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MagicWords
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }

            // reorder a list
            for (int i = 0; i < n; i++)
            {
                string word = list[i];
                int index = list[i].Length % (n + 1);
                list.Insert(index, word);
                if (index < i)
                {
                    list.RemoveAt(i + 1);
                }
                else
                {
                    list.RemoveAt(i);
                }
            }

            int maxLength = list.Max(x => x.Length);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < maxLength; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    string currentWord = list[j];
                    if (currentWord.Length > i)
                    {
                        result.Append(currentWord[i].ToString());
                    }
                }
            }

            result.AppendLine();
            Console.WriteLine(result.ToString());
        }
    }
}

// C# Part 2 - 2013/2014 @ 14 Sept 2013 - Morning
// http://bgcoder.com/Contests/Practice/Index/94#1