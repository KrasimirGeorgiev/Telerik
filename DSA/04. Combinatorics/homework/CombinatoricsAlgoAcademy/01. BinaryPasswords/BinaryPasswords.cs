namespace _01.BinaryPasswords
{
    using System;
    using System.Numerics;

    public class BinaryPasswords
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var stars = CountStars(input);
            PrintPermutations(stars);
        }

        private static short CountStars(string str)
        {
            byte counter = 0;
            foreach (char symbol in str)
            {
                if (symbol == '*')
                {
                    counter++;
                }
            }

            return counter;
        }

        private static void PrintPermutations(short count)
        {
            if (count <= 7)
            {
                short number = 1;
                for (short i = 0; i < count; i++)
                {
                    number *= 2;
                }

                Console.WriteLine(number);
            }
            else if (count <= 15)
            {
                ushort number = 1;
                for (short i = 0; i < count; i++)
                {
                    number *= 2;
                }

                Console.WriteLine(number);
            }
            else if (count <= 53)
            {
                ulong number = 1;
                for (short i = 0; i < count; i++)
                {
                    number *= 2;
                }

                Console.WriteLine(number);
            }
            else
            {
                BigInteger number = 1;
                for (short i = 0; i < count; i++)
                {
                    number *= 2;
                }

                Console.WriteLine(number);
            }
        }
    }
}
