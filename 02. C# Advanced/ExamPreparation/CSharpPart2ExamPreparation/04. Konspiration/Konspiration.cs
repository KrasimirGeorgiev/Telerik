namespace _04.Konspiration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Konspiration
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lines = Enumerable.Range(0, n).Select(x => Console.ReadLine()).ToArray();
        }
    }
}

// C# Part 2 - 2015/2016 @ 5 March 2015 - Evening
// http://bgcoder.com/Contests/Practice/Index/221#3