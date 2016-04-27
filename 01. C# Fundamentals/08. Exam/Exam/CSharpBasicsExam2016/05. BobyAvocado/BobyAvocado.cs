using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class Test
    {
        public static void Main()
        {
            string bobyHair = Convert.ToString(uint.Parse(Console.ReadLine()), 2);
            bobyHair = bobyHair.PadLeft(32, '0');
            uint maxNumber = 0;
            int maxCount = 0;

            int combsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < combsNumber; i++)
            {
                uint currentNumber = uint.Parse(Console.ReadLine());
                string currentComb = Convert.ToString(currentNumber, 2);
                int currentCount = 0;
                int min = Math.Min(bobyHair.Length, currentComb.Length);
                bool useful = true;

                for (int j = 0; j < min; j++)
                {
                    //char combBit = currentComb[currentComb.Length - (1 + j)];
                    //char bobyBit = bobyHair[bobyHair.Length - (j + 1)];
                    if (currentComb[currentComb.Length - (1 + j)] == bobyHair[bobyHair.Length - (j + 1)] && bobyHair[bobyHair.Length - (j + 1)] == '1')
                    {
                        useful = false;
                        break;
                    }
                    // else if (combBit == bobyBit && combBit == '0')
                    // {
                    //     return "no";
                    // }
                    else if (currentComb[currentComb.Length - (1 + j)] == '1' && bobyHair[bobyHair.Length - (j + 1)] == '0')
                    {
                        currentCount++;
                    }
                }

                if (useful && maxCount < currentCount)
                {
                    maxCount = currentCount;
                    maxNumber = currentNumber;
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
