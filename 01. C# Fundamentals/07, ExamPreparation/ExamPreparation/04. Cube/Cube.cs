namespace _04.Cube
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cube
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            result.Append(new string(' ', n - 1));
            result.AppendLine(new string(':', n));
            for (int i = 0; i < n - 2; i++)
            {
                result.Append(new string(' ', n - (2 + i)));
                result.Append(":");
                result.Append(new string('/', n - 2));
                result.Append(":");
                result.Append(new string('X', i));
                result.AppendLine(":");
            }

            result.Append(new string(':', n));
            result.Append(new string('X', n - 2));
            result.AppendLine(":");
            for (int i = n - 3; i >= 0; i--)
            {
                result.Append(":");
                result.Append(new string(' ', n - 2));
                result.Append(":");
                result.Append(new string('X', i));
                result.AppendLine(":");
            }

            result.AppendLine(new string(':', n));

            Console.WriteLine(result.ToString());
        }
    }
}
