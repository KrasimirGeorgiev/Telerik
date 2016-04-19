namespace _03.Maslan
{
    using System;
    using System.Numerics;

    public class Maslan
    {
        public static void Main()
        {
            string n = Console.ReadLine();
            string number = n;
            int countTransformations = 0;

            while (true)
            {
                BigInteger product = 1;
                number = number.Substring(0, number.Length - 1);
                while (number.Length > 0)
                {
                    BigInteger currentNumber = 0;
                    currentNumber = SumOfOddDigits(number);
                    if (currentNumber != 0)
                    {
                        product *= currentNumber;
                    }

                    number = number.Substring(0, number.Length - 1);
                }

                number = product.ToString();
                countTransformations++;
                if (number.Length == 1)
                {
                    Console.WriteLine(countTransformations);
                    Console.WriteLine(number);
                    break;
                }

                if (countTransformations == 10)
                {
                    Console.WriteLine(number);
                    break;
                }
            }
        }

        private static BigInteger SumOfOddDigits(string str)
        {
            BigInteger result = 0;
            int count = 0;
            foreach (char symbol in str)
            {
                if (count % 2 != 0)
                {
                    result += symbol - '0';
                }

                count++;
            }

            return result;
        }
    }
}
