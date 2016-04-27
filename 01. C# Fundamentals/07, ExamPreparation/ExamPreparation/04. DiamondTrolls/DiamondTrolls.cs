namespace _04.DiamondTrolls
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DiamondTrolls
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 2 + 1;
            int height = 6 + ((n - 3) / 2) * 3;
            StringBuilder result = new StringBuilder();

            //// top line
            result.Append(new string('.', (width - n ) / 2));
            result.Append(new string('*', n));
            result.AppendLine(new string('.', (width - n) / 2));

            //// top
            for (int i = height - (n + 2); i >= 1 ; i--)
            {
                result.Append(new string('.', i));
                result.Append(new string('*', 1));
                result.Append(new string('.', n - (1 + i)));
                result.Append(new string('*', 1));
                result.Append(new string('.', n - (1 + i)));
                result.Append(new string('*', 1));
                result.AppendLine(new string('.', i));
            }

            //// mid line
            result.AppendLine(new string('*', width));

            //// bottom
            for (int i = n - 2; i >= 0; i--)
            {
                result.Append(new string('.', n - (1 + i)));
                result.Append(new string('*', 1));
                result.Append(new string('.', i));
                result.Append(new string('*', 1));
                result.Append(new string('.', i));
                result.Append(new string('*', 1));
                result.AppendLine(new string('.', n - (1 + i)));
            }

            //// last line
            result.Append(new string('.', n));
            result.Append(new string('*', 1));
            result.AppendLine(new string('.', n));

            Console.WriteLine(result);
        }
    }
}

// Telerik Academy Exam 1 @ 6 December 2013 Morning
// http://bgcoder.com/Contests/Practice/Index/106#3