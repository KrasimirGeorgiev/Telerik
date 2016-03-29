namespace _08.IsoscelesTriangle
{
    using System;

    public class IsoscelesTriangle
    {
        public static void Main()
        {
            char symbol = '©';
            int width = 7;
            int height = 7;

            for (int i = 0; i < height; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine();
                    continue;
                }

                int symbolCount = 2;
                if (i == 0 || i == height - 1)
                {
                    symbolCount = i == 0 ? 1 : 4;
                }

                switch (symbolCount)
                {
                    case 1:
                        Console.WriteLine(new string(' ', 3) + symbol + new string(' ', 3));
                        break;
                    case 2:
                        Console.WriteLine(new string(' ', (width - (2 + (i - 1))) / 2) + symbol + new string(' ', i - 1) + 
                                          symbol + new string(' ', (width - (2 + (i - 1))) / 2));
                        break;
                    case 4:
                        Console.WriteLine(symbol + " " + symbol + " " + symbol + " " + symbol);
                        break;
                }
            }
        }
    }
}

// Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//    ©
// 
//   © ©
// 
//  ©   ©
// 
// © © © ©