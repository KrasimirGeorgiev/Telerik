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
            string str = "12345";
            str = str.Remove(str.Length - 1);
            Console.WriteLine(str); 
        }
    }
}
