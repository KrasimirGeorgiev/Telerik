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
            string str = "12345";
            str = str.Remove(2, 1);
            str = str.Insert(2, "0");
            Console.WriteLine(str);
        }
    }
}
