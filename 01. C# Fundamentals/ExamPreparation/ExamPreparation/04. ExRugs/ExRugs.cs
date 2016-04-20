namespace _04.ExRugs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExRugs
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int height = 2 * n + 1;
            int width = height;
            StringBuilder result = new StringBuilder();

            if (d >= width)
            {
                for (int i = 0; i < width; i++)
                {
                    result.AppendLine(new string('#', width));
                }
            }
            else
            {
                // first top
                //for (int i = 0; i < (width - (d + 2)) / 2; i++)
                //{
                //    result.Append(new string('\\', 1));
                //    result.Append(new string('#', 1));
                //    result.Append(new string('\\', 1));
                //    result.Append(new string('.', 1));
                //    result.Append(new string('/', 1));
                //    result.Append(new string('#', 1));
                //    result.Append(new string('/', 1));
                //}
                // upperX

                // upperUnderX
                for (int i = (d - 1) / 2; i > 0; i--)
                {
                    result.Append(new string('.', (width - (d + 2 + (i * 2))) / 2));
                    result.Append(new string('\\', 1)); // This could be a problem
                    result.Append(new string('#', i * 2 + d));
                    result.Append(new string('/', 1)); // and this
                    result.AppendLine(new string('.', (width - (d + 2 + (i * 2))) / 2));
                }

                // middle
                string middle = "";

                middle += new string('.', (width - (2 + d)) / 2);
                middle += new string('X', 1);
                middle += new string('#', d);
                middle += new string('X', 1);
                middle += new string('.', (width - (2 + d)) / 2);

                result.AppendLine(middle);

                
            }

            Console.WriteLine(result.ToString());
        }
    }
}
