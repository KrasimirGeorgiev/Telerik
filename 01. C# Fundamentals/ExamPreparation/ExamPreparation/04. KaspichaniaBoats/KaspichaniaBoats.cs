namespace _04.KaspichaniaBoats
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class KaspichaniaBoats
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 2 + 1;
            int height = 6 + ((n - 3) / 2) * 3;
            StringBuilder result = new StringBuilder();
            //// first line
            result.Append(new string('.', n));
            result.Append(new string('*', 1));
            result.AppendLine(new string('.', n));

            //// top
            for (int i = 0; i < n - 1; i++)
            {
                result.Append(new string('.', n - (1 + i)));
                result.Append(new string('*', 1));
                result.Append(new string('.', i));
                result.Append(new string('*', 1));
                result.Append(new string('.', i));
                result.Append(new string('*', 1));
                result.AppendLine(new string('.', n - (1 + i)));
            }

            //// middle
            result.AppendLine(new string('*', width));

            //// bottom
            for (int i = 1; i <= height - (n + 2); i++)
            {
                result.Append(new string('.', i));
                result.Append(new string('*', 1));
                result.Append(new string('.', (width - (3 + 2 * i)) / 2));
                result.Append(new string('*', 1));
                result.Append(new string('.', (width - (3 + 2 * i)) / 2));
                result.Append(new string('*', 1));
                result.AppendLine(new string('.', i));
            }

            //// last line
            result.Append(new string('.', (width - n) / 2));
            result.Append(new string('*', n));
            result.AppendLine(new string('.', (width - n) / 2));
            Console.WriteLine(result.ToString());
        }
    }
}

// Telerik Academy Exam 1 @ 6 December 2013 Evening
// http://bgcoder.com/Contests/Practice/Index/107#3
