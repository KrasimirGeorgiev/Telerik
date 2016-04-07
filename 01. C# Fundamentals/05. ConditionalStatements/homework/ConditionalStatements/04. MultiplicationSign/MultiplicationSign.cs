namespace _04.MultiplicationSign
{
    using System;

    public class MultiplicationSign
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine()); 
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int countMinuses = 0;
                string result = "";
                if (firstNumber < 0)
                {
                    countMinuses++;
                }

                if (secondNumber < 0)
                {
                    countMinuses++;
                }

                if (thirdNumber < 0)
                {
                    countMinuses++;
                }

                result = countMinuses % 2 == 0 ? "+" : "-";
                Console.WriteLine(result);
            }
        }
    }
}

// Write a program that shows the sign(+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.