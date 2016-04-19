namespace _04.Cube3d
{
    using System;
    using System.Text;

    public class Cube3d
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();

            result.AppendLine(new string(':', n));
            for (int i = 0; i < n - 2; i++)
            {
                result.Append(":");
                result.Append(new string(' ', n - 2));
                result.Append(":");
                result.Append(new string('|', i));
                result.AppendLine(":");
            }

            result.Append(new string(':', n));
            result.Append(new string('|', n - 2));
            result.AppendLine(":");
            for (int i = 0; i < n - 2; i++)
            {
                result.Append(new string(' ', i + 1));
                result.Append(":");
                result.Append(new string('-', n - 2));
                result.Append(":");
                result.Append(new string('|', (n - 3) - i));
                result.AppendLine(":");
            }

            result.Append(new string(' ', n - 1));
            result.AppendLine(new string(':', n));
            Console.WriteLine(result.ToString());
        }
    }
}

// Telerik Academy Exam 1 @ 2 February 2015 Evening
// http://bgcoder.com/Contests/Practice/Index/203#3