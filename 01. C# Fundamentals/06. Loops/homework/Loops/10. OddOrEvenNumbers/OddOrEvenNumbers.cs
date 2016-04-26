namespace _10.OddOrEvenNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOrEvenNumbers
    {
        public static void Main()
        {
            ulong numberOfElements = ulong.Parse(Console.ReadLine());
            ulong[] elements = Console.ReadLine().Split().Select(ulong.Parse).ToArray();
            List<ulong> oddElements = new List<ulong>();
            ulong oddProduct = 1;
            List<ulong> evenElements = new List<ulong>();
            ulong evenProduct = 1;
            for (int i = 1, elementsLength = elements.Length; i <= elementsLength; i++)
            {
                if (i % 2 != 0)
                {
                    oddElements.Add(elements[i - 1]);
                    oddProduct *= elements[i - 1];
                }
                else
                {
                    evenElements.Add(elements[i - 1]);
                    evenProduct *= elements[i - 1];
                }
            }

            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
            }
        }
    }
}

// You are given N integers(given in a single line, separated by a space).
// Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
// Elements are counted from 1 to N, so the first element is odd, the second is even, etc.
