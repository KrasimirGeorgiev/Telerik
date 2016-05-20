namespace _02.BunnyFactory
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class BunnyFactory
    {
        public static void Main()
        {
            List<int> cagesWithBunnies = new List<int>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                cagesWithBunnies.Add(int.Parse(input));
                input = Console.ReadLine();
            }

            int genCount = 1;
            while (true)
            {
                if (cagesWithBunnies.Count < genCount)
                {
                    break;
                }

                BigInteger s = 0;
                for (int i = 0; i < genCount; i++)
                {
                    s += cagesWithBunnies[i];
                }

                if (cagesWithBunnies.Count - genCount < s)
                {
                    break;
                }

                BigInteger sum = 0;
                BigInteger product = 1;
                for (int i = genCount; i < genCount + s; i++)
                {
                    sum += cagesWithBunnies[i];
                    product *= cagesWithBunnies[i];
                }

                string result = sum.ToString() + product.ToString();
                for (int i = (int)(genCount + s); i < cagesWithBunnies.Count; i++)
                {
                    result += cagesWithBunnies[i];
                }

                cagesWithBunnies.Clear();
                foreach (char number in result)
                {
                    int currentNumber = number - '0';
                    if (currentNumber != 1 && currentNumber != 0)
                    {
                        cagesWithBunnies.Add(currentNumber);
                    }
                }

                genCount++;
            }

            Console.WriteLine(string.Join(" ", cagesWithBunnies));
        }
    }
}

// C# Part 2 - 2013/2014 @ 22 Jan 2014 - Evening
// http://bgcoder.com/Contests/Practice/Index/142#1