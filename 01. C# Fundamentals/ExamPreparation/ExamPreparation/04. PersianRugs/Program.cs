namespace _04.PersianRugs
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int width = (2 * n) + 1;
            int height = width;
            int firstLineSmallUpTriangle = n - (d + 2);
            int secondLineSmallUpTriangle = n - (d + 1);

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('#', i));
                Console.Write(new string('\\', 1));
                if (firstLineSmallUpTriangle - 1 == i || secondLineSmallUpTriangle - 1 == i)
                {
                    if (firstLineSmallUpTriangle - 1 == i)
                    {
                        Console.Write(new string(' ', ((width - (2 + (2 * i))) - 5) / 2));
                        Console.Write("\\.../");
                        Console.Write(new string(' ', ((width - (2 + (2 * i))) - 5) / 2));
                    }
                    else if (secondLineSmallUpTriangle - 1 == i)
                    {
                        Console.Write(new string(' ', ((width - (2 + (2 * i))) - 3) / 2));
                        Console.Write("\\./");
                        Console.Write(new string(' ', ((width - (2 + (2 * i))) - 3) / 2));
                    }
                }
                else
                {
                    Console.Write(new string(' ', width - (2 + (2 * i))));
                }

                Console.Write(new string('/', 1));
                Console.WriteLine(new string('#', i));
            }

            Console.Write(new string('#', n));
            Console.Write(new string('X', 1));
            Console.WriteLine(new string('#', n));

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(new string('#', i));
                Console.Write(new string('/', 1));
                if (firstLineSmallUpTriangle - 1 == i || secondLineSmallUpTriangle - 1 == i)
                {
                    if (firstLineSmallUpTriangle - 1 == i)
                    {
                        Console.Write(new string(' ', ((width - (2 + (2 * i))) - 5) / 2));
                        Console.Write("/...\\");
                        Console.Write(new string(' ', ((width - (2 + (2 * i))) - 5) / 2));
                    }
                    else if (secondLineSmallUpTriangle - 1 == i)
                    {
                        Console.Write(new string(' ', ((width - (2 + (2 * i))) - 3) / 2));
                        Console.Write("/.\\");
                        Console.Write(new string(' ', ((width - (2 + (2 * i))) - 3) / 2));
                    }
                }
                else
                {
                    Console.Write(new string(' ', width - (2 + (2 * i))));
                }

                Console.Write(new string('\\', 1));
                Console.WriteLine(new string('#', i));
            }
        }
    }
}
