namespace Tests
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        public static void Main()
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            Console.WriteLine(set.Contains(1));
        }
    }
}
