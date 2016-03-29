namespace _04.UnicodeCharacter
{
    using System;
    using System.Globalization;

    public class UnicodeCharacter
    {
        public static void Main()
        {
            int decValue = 42;
            string hexValue = Convert.ToString(decValue, 16);
            if (hexValue.Length < 4)
            {
                hexValue = new string('0', 4 - hexValue.Length) + hexValue;
            }

            hexValue = "\\u" + hexValue;
            char symbol = (char)int.Parse(hexValue.Substring(2), NumberStyles.HexNumber);

            Console.WriteLine(symbol);
        }
    }
}

// Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
// Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.
// char c = (char)int.Parse(s.Substring(2), NumberStyles.HexNumber);