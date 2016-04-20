namespace Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tests
    {
        public static void Main(string[] args)
        {
            string result = string.Empty;
            string str = "123456";
                result = str.Substring(str.Length - 5, 5);
            Console.WriteLine(result);
        }
    }
}
