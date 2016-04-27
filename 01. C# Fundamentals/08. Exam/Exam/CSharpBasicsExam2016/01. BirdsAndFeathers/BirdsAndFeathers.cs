using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BirdsAndFeathers
{
    public class BirdsAndFeathers
    {
        public static void Main()
        {
            ulong b = ulong.Parse(Console.ReadLine());
            ulong f = ulong.Parse(Console.ReadLine());
            if (b != 0)
            {
                double average = (double)f / (double)b;
                average = b % 2 == 0 ? average * (double)123123123123 : average / (double)317;

                Console.WriteLine("{0:F4}", average);
            }
            else
            {
                Console.WriteLine("0.0000");
            }
        }
    }
}

// The tricky part here was that if you use decimal half the tests won't pass