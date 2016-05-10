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
            int[] numbers = { 1, 3, 4, 9, 2, 4 };
            int numToRemove = 4;
            int numIndex = Array.IndexOf(numbers, numToRemove);
            numbers = numbers.Where((emt, idx) => idx != numIndex).ToArray();
            Console.WriteLine(string.Join(string.Empty, numbers));
        }
    }
}

// int[] numbers = { 1, 3, 4, 9, 2, 4 };
// int numToRemove = 4;
// int numIndex = Array.IndexOf(numbers, numToRemove);
// numbers = numbers.Where((val, idx) => idx != numIndex).ToArray();