namespace _12.NullValuesArithmetic
{
    using System;

    public class NullValuesArithmetic
    {
        public static void Main()
        {
            int? someInteger = null;
            double? someDouble = null;
            Console.WriteLine("Null integer: {0}\nNull double: {1}", someInteger, someDouble);
            Console.WriteLine("Null integer + 1: {0}\nNull double + 1: {1}", someInteger + 1, someDouble + 1);
        }
    }
}

// Create a program that assigns null values to an integer and to a double variable.
// 
// Try to print these variables at the console.
// Try to add some number or the null literal to these variables and print the result.