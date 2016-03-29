namespace _03.VariableInHexadecimalFormat
{
    using System;

    public class VariableInHexadecimalFormat
    {
        public static void Main()
        {
            int value = 254;
            string valueToHexadecimal = Convert.ToString(value, 16);

            Console.WriteLine(valueToHexadecimal);
            Console.WriteLine(Convert.ToInt64(valueToHexadecimal, 16));
        }
    }
}

// Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). 
// Use Windows Calculator to find its hexadecimal representation. 
// Print the variable and ensure that the result is 254.
//
// CheatSheet: 
// To convert from decimal to hex do...
//  string hexValue = decValue.ToString("X");
// or
//  string hexValue = Convert.ToString(decValue, 16);
// or
//  string value = string.Format("{0:x}", decValue);
// To convert from hex to decimal do either...
//  int decValue = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
// or
//  int decValue = Convert.ToInt64(hexValue, 16);