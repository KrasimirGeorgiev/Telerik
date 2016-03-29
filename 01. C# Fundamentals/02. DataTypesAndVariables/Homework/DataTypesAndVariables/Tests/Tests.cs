namespace Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Tests
    {
        static void Main()
        {

            string s = "\\u0042";
            char c = (char)int.Parse(s.Substring(2), NumberStyles.HexNumber);

            Console.WriteLine(c);
        }
    }
}
