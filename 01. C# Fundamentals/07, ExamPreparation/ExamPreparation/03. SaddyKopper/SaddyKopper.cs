namespace _03.SaddyKopper
{
    using System;
    using System.Numerics;

    public class SaddyKopper
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            int transformationCounter = 0;
            while (true)
            {
                BigInteger products = 1;
                
                while (number.Length != 0)
                {
                    int sum = 0;
                    number = number.Remove(number.Length - 1);
                    if (number.Length == 0)
                    {
                        break;
                    }

                    int counter = 0;
                    foreach (char symbol in number)
                    {
                        if (counter % 2 == 0)
                        {
                            sum += symbol - '0';
                        }

                        counter++;
                    }

                    products *= sum;
                }

                number = products.ToString();
                transformationCounter++;

                if (number.ToString().Length == 1)
                {
                    Console.WriteLine(transformationCounter);
                    Console.WriteLine(number);
                    break;
                }
                else if (transformationCounter == 10)
                {
                    Console.WriteLine(number);
                    break;
                }
            }
        }
    }
}

// Telerik Academy Exam 1 @ 2 February 2015 Morning
// http://bgcoder.com/Contests/Practice/Index/202#2
// The trick here was to use string everywhere it could be used instead of BigInteger. That way i was able to lower the time from 0.156s to 0.031s
