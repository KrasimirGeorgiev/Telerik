using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Batman
{
    public class Batman
    {
        public static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            string result = CallBatman(s, c);
            
            Console.WriteLine(result);
        }

        private static string CallBatman(int s, char c)
        {
            StringBuilder result = new StringBuilder();
            // wings
            int upperAndBottomCount = (s - 1) / 2;
            for (int i = 0; i < upperAndBottomCount - 1; i++)
            {
                result.Append(new string(' ', i));
                result.Append(new string(c, s - i));
                result.Append(new string(' ', s));
                result.AppendLine(new string(c, s - i));
            }

            // head
            result.Append(new string(' ', upperAndBottomCount - 1));
            result.Append(new string(c, s - (upperAndBottomCount - 1)));
            result.Append(new string(' ', (s - 3) / 2));
            result.Append(new string(c, 1));
            result.Append(new string(' ', 1));
            result.Append(new string(c, 1));
            result.Append(new string(' ', (s - 3) / 2));
            result.AppendLine(new string(c, s - (upperAndBottomCount - 1)));

            // body
            for (int i = 0; i < upperAndBottomCount - 1; i++)
            {
                result.Append(new string(' ', upperAndBottomCount));
                result.AppendLine(new string(c, s + (2 * (s - (upperAndBottomCount)))));
            }

            // tail
            int tailCount = s - 2;
            for (int i = 0; i < upperAndBottomCount; i++)
            {
                result.Append(new string(' ', (3 * s - tailCount) / 2));
                result.AppendLine(new string(c, tailCount));
                tailCount -= 2;
            }

            result.Length = result.Length - 1;
            return result.ToString();
        }
    }
}
