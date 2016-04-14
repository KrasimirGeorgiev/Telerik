namespace _02.AngryFemaleGPS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AngryFemaleGPS
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            long evenSum = 0;
            long oddSum = 0;
            foreach (char symbol in number)
            {
                if (!char.IsDigit(symbol))
                {
                    continue;
                }
                int currentNumber = symbol - '0';
                if (currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }

            if (evenSum > oddSum)
            {
                Console.WriteLine("right {0}", evenSum);
            }
            else if (oddSum > evenSum)
            {
                Console.WriteLine("left {0}", oddSum);
            }
            else if (oddSum == evenSum)
            {
                Console.WriteLine("straight {0}", evenSum);
            }
        }
    }
}

// Telerik Academy Exam 1 @ 5 December 2013 Evening
// http://bgcoder.com/Contests/Practice/Index/105#1
// The catch here is that in the "valid long number" there are symbols that aren't digits