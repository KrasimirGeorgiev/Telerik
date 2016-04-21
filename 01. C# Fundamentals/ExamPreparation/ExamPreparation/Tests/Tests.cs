namespace Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tests
    {
        public static void Main()
        {
            string str = "(6%5-1)*(6-5)*5";
            string result = "";
            int oppeningIndex = 0;
            int closingIndex = 0;
            while (oppeningIndex != -1)
            {
                int oppeningBraketIndex = str.IndexOf('(', oppeningIndex);
                int closingBraketIndex = str.IndexOf(')', closingIndex);
                if (oppeningBraketIndex == -1)
                {
                    break;
                }
                string substr = str.Substring(oppeningBraketIndex + 1, closingBraketIndex - (oppeningBraketIndex + 1));
                if (oppeningBraketIndex - 1 >= 0)
                {
                    string inputLeftStr = str.Substring(0, oppeningBraketIndex - 1);
                }
                if (closingBraketIndex + 1 < str.Length)
                {
                    string inputRightStr = str.Substring(closingIndex + 1, str.Length - (closingBraketIndex + 1));
                }

                oppeningIndex = closingBraketIndex;
            }

            Console.WriteLine(result);
        }
    }
}
