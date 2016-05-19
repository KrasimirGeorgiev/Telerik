namespace Tests
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        public static void Main(string[] args)
        {
            List<int> a = new List<int> { 1, 2, 3, 4, 5 };
            a.Insert(5, 1);
            a.RemoveAt(0);
            Console.WriteLine(string.Join(", ", a));
        }
    }
}
