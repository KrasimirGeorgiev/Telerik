namespace _02.TextToNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TextToNumber
    {
        public static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            long result = 0;

            foreach (char symbol in str)
            {
                if (symbol == '@')
                {
                    break;
                }

                if (char.IsDigit(symbol))
                {
                    result = result == 0 ? 1 : result;
                    result *= symbol - '0';
                }
                else if (char.IsLetter(symbol))
                {
                    result += char.ToLower(symbol) - 'a';
                }
                else
                {
                    result %= m;
                }
            }

            Console.WriteLine(result);
        }
    }
}
