namespace _03.DivideBy7And5
{
    using System;

    public class DivideBy7And5
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            string canBeDidided = string.Empty;
            canBeDidided = inputNumber % 5 == 0 && inputNumber % 7 == 0 ? "true" : "false";

            Console.WriteLine("{0} {1}", canBeDidided, inputNumber);
            //// Input Output
            //// 3     false 3
            //// 0     true 0
            //// 5     false 5
            //// 7     false 7
            //// 35    true 35
            //// 140   true 140
        }
    }
}

// Write a program that does the following:
// 
// Reads an integer number from the console.
// Stores in a variable if the number can be divided by 7 and 5 without remainder.
// Prints on the console "true NUMBER" if the number is divisible without remainder by 7 and 5. 
// Otherwise prints "false NUMBER". In place of NUMBER print the value of the input number.