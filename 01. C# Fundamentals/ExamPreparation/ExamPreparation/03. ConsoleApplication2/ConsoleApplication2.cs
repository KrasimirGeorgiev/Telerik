namespace _03.ConsoleApplication2
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading;
    using System.Globalization;

    public class ConsoleApplication2
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            decimal[] numbers = new decimal[10000];
            BigInteger digitsProduct = 1;
            BigInteger totalProducts = 1;
            BigInteger digitsProduct2 = 1;
            BigInteger totalProducts2 = 1;
            int numbersCount = 0;
            decimal inputNumber = 0;
            bool isNumber = true;

            do
            {
                isNumber = decimal.TryParse(Console.ReadLine(), out inputNumber);
                numbers[numbersCount] = inputNumber;
                numbersCount++;
            } while (isNumber);

            for (int i = 0; i < numbersCount; i++)
            {
                if (i < 10)
                {
                    if (i % 2 == 0)
                    {
                        if (numbers[i] == 0)
                        {
                            continue;
                        }

                        string number = numbers[i].ToString();

                        for (int j = 0; j < number.Length; j++)
                        {
                            if (char.IsDigit(number[j]))
                            {
                                if (number[j] - '0' == 0)
                                {
                                    continue;
                                }

                                digitsProduct *= number[j] - '0';
                            }
                        }
                    }

                    totalProducts *= digitsProduct;
                    digitsProduct = 1;
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        if (numbers[i] == 0)
                        {
                            continue;
                        }

                        string number = numbers[i].ToString();

                        for (int j = 0; j < number.Length; j++)
                        {
                            if (char.IsDigit(number[j]))
                            {
                                if (number[j] - '0' == 0)
                                {
                                    continue;
                                }

                                digitsProduct2 *= number[j] - '0';
                            }
                        }
                    }

                    totalProducts2 *= digitsProduct2;
                    digitsProduct2 = 1;
                }
            }

            if (numbersCount <= 10)
            {
                Console.WriteLine(totalProducts);
            }
            else
            {
                Console.WriteLine(totalProducts);
                Console.WriteLine(totalProducts2);
            }
        }
    }
}
