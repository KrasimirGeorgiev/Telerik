namespace _1.TRES4Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class TRES4Numbers
    {
        public static void Main()
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            Stack<int> decimalToNineNumeral = new Stack<int>();
            if (input == 0)
            {
                Console.WriteLine("LON+");
            }
            else
            {
            DecimalToNNumeral(input, 9, decimalToNineNumeral);
            string result = string.Empty;
                foreach (int number in decimalToNineNumeral)
                {
                    switch (number)
                    {
                        case 0:
                            result += "LON+";
                            break;
                        case 1:
                            result += "VK-";
                            break;
                        case 2:
                            result += "*ACAD";
                            break;
                        case 3:
                            result += "^MIM";
                            break;
                        case 4:
                            result += "ERIK|";
                            break;
                        case 5:
                            result += "SEY&";
                            break;
                        case 6:
                            result += "EMY>>";
                            break;
                        case 7:
                            result += "/TEL";
                            break;
                        case 8:
                            result += "<<DON";
                            break;

                        default: throw new ArgumentOutOfRangeException("The switch received a value that is not allowed");
                    }
                }

                Console.WriteLine(result);
            }   
        }

        private static Stack<int> DecimalToNNumeral(BigInteger decimalNumber, int numberalSystem, Stack<int> result)
        {
            while (decimalNumber > 0)
            {
                result.Push((int)(decimalNumber % numberalSystem));
                decimalNumber /= numberalSystem;
            }

            return result;
        }
    }
}

// C# Part 2 - 2013/2014 @ 22 Jan 2014 - Evening
// http://bgcoder.com/Contests/Practice/Index/142#0
// Personal notes: had a problem with the 0 (because the while checks if the numbers is > 0, so the number never enters);