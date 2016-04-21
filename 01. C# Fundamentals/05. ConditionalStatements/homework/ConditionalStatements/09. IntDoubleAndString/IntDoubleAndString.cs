namespace _09.IntDoubleAndString
{
    using System;

    public class IntDoubleAndString
    {
        public static void Main()
        {
            string inputType = Console.ReadLine();
            string input = Console.ReadLine();
            if (inputType == "real")
            {
                double inputToNumber = double.Parse(input);
                inputToNumber++;
                Console.WriteLine("{0:F2}", inputToNumber);
            }
            else if (inputType == "integer")
            {
                long inputToNumber = long.Parse(input);
                inputToNumber++;
                Console.WriteLine(inputToNumber);
            }
            else
            {
                input += "*";
                Console.WriteLine(input);
            }
        }
    }
}

// Write a program that, depending on the first line of the input, reads an int, double or string variable.
// If the variable is int or double, the program increases it by one.
// If the variable is a string, the program appends* at the end.
// Print the result at the console. Use switch statement.
//
// On the first line you will receive the type of input as string in the following form:
// integer for int
// real for double
// text for string
// On the second line you will be given the value of the variable.