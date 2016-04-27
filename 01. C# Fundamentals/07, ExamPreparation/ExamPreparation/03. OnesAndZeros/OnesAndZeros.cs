namespace _03.OnesAndZeros
{
    using System;
    using System.Numerics;
    using System.Text;

    public class OnesAndZeros
    {
        public static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            number = number < 0 ? number * (-1) : number;
            string numberInBinary = Convert.ToString((long)number, 2);
            if (numberInBinary.Length > 16)
            {
                numberInBinary = numberInBinary.Substring(0, 16);
            }
            else if (numberInBinary.Length < 16)
            {
                numberInBinary = numberInBinary.PadLeft(16, '0');
            }

            string[] oneAsStr =
            {
                ".#.",
                "##.",
                ".#.",
                ".#.",
                "###"
            };

            string[] zeroAsStr = 
            {
                "###",
                "#.#",
                "#.#",
                "#.#",
                "###"
            };
            
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                foreach (char symbol in numberInBinary)
                {
                    if (symbol == '1')
                    {
                        result.Append(oneAsStr[i]);
                    }
                    else
                    {
                        result.Append(zeroAsStr[i]);
                    }

                    result.Append(".");
                }

                result.Length = result.Length - 1;
                result.AppendLine();
            }

            result.Length = result.Length - 1;

            Console.WriteLine(result);
        }
    }
}
