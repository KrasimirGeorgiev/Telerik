namespace _04.ExRugs
{
    using System;
    using System.Text;

    public class ExRugs
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int height = (2 * n) + 1;
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
                // topTriangle
                if (height > d + 2)
                {
                    int count = 1;
                    for (int i = 0; i < ((height - (d + 2)) / 2) - 1; i++)
                    {
                        count += 2;
                    }

                    for (int i = 0; i < (height - (d + 2)) / 2; i++)
                    {
                        string currentLine = string.Empty;
                        int dotsLenght = 0;
                        currentLine = width > count ? new string('.', count) : new string('.', width);
                        dotsLenght = currentLine.Length;
                        currentLine = width > dotsLenght ? "\\" + currentLine + "/" : currentLine;
                        if (currentLine.Length == dotsLenght)
                        {
                            result.AppendLine(currentLine);
                            count -= 2;
                            continue;
                        }

                        if (width - currentLine.Length <= d * 2)
                        {
                            currentLine = new string('#', (width - currentLine.Length) / 2) + currentLine + new string('#', (width - currentLine.Length) / 2);
                            result.AppendLine(currentLine);
                            count -= 2;
                            continue;
                        }

                        currentLine = "\\" + new string('#', d) + currentLine + new string('#', d) + "/";

                        if (width > currentLine.Length)
                        {
                            currentLine = new string('.', (width - currentLine.Length) / 2) + currentLine + new string('.', (width - currentLine.Length) / 2);
                        }

                        result.AppendLine(currentLine);
                        count -= 2;
                    }
                }
                
                // upperX
                if (height - d > 0)
                {
                    if ((width - 1) / 2 > d)
                    {
                        result.Append(new string('.', (width - (3 + (2 * d))) / 2));
                        result.Append("\\");
                        result.Append(new string('#', d));
                        result.Append("X");
                        result.Append(new string('#', d));
                        result.Append("/");
                        result.AppendLine(new string('.', (width - (3 + (2 * d))) / 2));
                    }
                    else
                    {
                        result.Append(new string('#', (width - 1) / 2));
                        result.Append("X");
                        result.AppendLine(new string('#', (width - 1) / 2));
                    }
                }

                // upperUnderX
                for (int i = (d - 1) / 2; i > 0; i--)
                {
                    if ((width - (d + 2 + (i * 2))) / 2 > 0)
                    {
                        result.Append(new string('.', (width - (d + 2 + (i * 2))) / 2));
                    }

                    if ((i * 2) + d < width)
                    {
                        result.Append(new string('\\', 1)); 
                    }

                    if ((i * 2) + d > width)
                    {
                        result.Append(new string('#', width)); 
                    }
                    else
                    {
                        result.Append(new string('#', (i * 2) + d));
                    }

                    if ((i * 2) + d < width)
                    {
                        result.Append(new string('/', 1));
                    }

                    if ((width - (d + 2 + (i * 2))) / 2 > 0)
                    {
                        result.Append(new string('.', (width - (d + 2 + (i * 2))) / 2));
                    }

                    result.AppendLine();
                }

                // middle
                string middle = string.Empty;

                middle += new string('.', (width - (2 + d)) / 2);
                middle += new string('X', 1);
                middle += new string('#', d);
                middle += new string('X', 1);
                middle += new string('.', (width - (2 + d)) / 2);

                result.AppendLine(middle);

                // downUnderX
                for (int i = 1; i <= (d - 1) / 2; i++)
                {
                    if ((width - (d + 2 + (i * 2))) / 2 > 0)
                    {
                        result.Append(new string('.', (width - (d + 2 + (i * 2))) / 2));
                    }

                    if ((i * 2) + d < width)
                    {
                        result.Append(new string('/', 1));
                    }

                    if ((i * 2) + d > width)
                    {
                        result.Append(new string('#', width));
                    }
                    else
                    {
                        result.Append(new string('#', (i * 2) + d));
                    }

                    if ((i * 2) + d < width)
                    {
                        result.Append(new string('\\', 1));
                    }

                    if ((width - (d + 2 + (i * 2))) / 2 > 0)
                    {
                        result.Append(new string('.', (width - (d + 2 + (i * 2))) / 2));
                    }

                    result.AppendLine();
                }

                // downX
                if (height - d > 0)
                {
                    if ((width - 1) / 2 > d)
                    {
                        result.Append(new string('.', (width - (3 + (2 * d))) / 2));
                        result.Append("/");
                        result.Append(new string('#', d));
                        result.Append("X");
                        result.Append(new string('#', d));
                        result.Append("\\");
                        result.AppendLine(new string('.', (width - (3 + (2 * d))) / 2));
                    }
                    else
                    {
                        result.Append(new string('#', (width - 1) / 2));
                        result.Append("X");
                        result.AppendLine(new string('#', (width - 1) / 2));
                    }
                }

                // topTriangle
                if (height > d + 2)
                {
                    int count = 1;
                    for (int i = 0; i < (height - (d + 2)) / 2; i++)
                    {
                        string currentLine = string.Empty;
                        int dotsLenght = 0;
                        currentLine = width > count ? new string('.', count) : new string('.', width);
                        dotsLenght = currentLine.Length;
                        currentLine = width > dotsLenght ? "/" + currentLine + "\\" : currentLine;
                        if (currentLine.Length == dotsLenght)
                        {
                            result.AppendLine(currentLine);
                            count += 2;
                            continue;
                        }

                        if (width - currentLine.Length <= d * 2)
                        {
                            currentLine = new string('#', (width - currentLine.Length) / 2) + currentLine + new string('#', (width - currentLine.Length) / 2);
                            result.AppendLine(currentLine);
                            count += 2;
                            continue;
                        }

                        currentLine = "/" + new string('#', d) + currentLine + new string('#', d) + "\\";

                        if (width > currentLine.Length)
                        {
                            currentLine = new string('.', (width - currentLine.Length) / 2) + currentLine + new string('.', (width - currentLine.Length) / 2);
                        }

                        result.AppendLine(currentLine);
                        count += 2;
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}

// Telerik Academy Exam 1 @ 3 February 2015 Evening
// http://bgcoder.com/Contests/Practice/Index/205#3