namespace Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tests
    {
        public static void Main()
        {
            string str = "(3+4)*4-(3*3)";
            int oppeningIndex = str.IndexOf('(', 0);
            int closingIndex = str.IndexOf(')', 0);
            string subString = str.Substring(oppeningIndex + 1, closingIndex - (oppeningIndex + 1));
            Console.WriteLine(subString);
        }
    }
}
