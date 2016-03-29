namespace _06.StringsAndObjects
{
    using System;

    public class StringsAndObjects
    {
        public static void Main()
        {
            string firstValue = "Hello";
            string secondValue = "World";
            object objValue = firstValue + " " + secondValue;
            string thirdValue = (string)objValue; // you can also use objValue.ToString()

            Console.WriteLine(thirdValue);
        }
    }
}

// Declare two string variables and assign them with Hello and World.
// Declare an object variable and assign it with the concatenation of the first two variables(mind adding an interval between). 
// Declare a third string variable and initialize it with the value of the object variable(you should perform type casting).