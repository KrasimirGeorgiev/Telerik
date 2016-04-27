using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.NumberOfPages
{
    public class NumberOfPages
    {
        public static void Main()
        {
            int inputD = int.Parse(Console.ReadLine());
            Console.WriteLine(FindFactorial(inputD));
        }

        private static int FindFactorial(int n)
        {
            int result = 1;
            int number = 1;

            for (int i = 2; i <= 1000000; i++)
            {
                result += i.ToString().Length;
                if (result == n)
                {
                    number = i;
                    break;
                }
            }

            return number;
        }
    }
}

// Yes baby, going for the jugular!