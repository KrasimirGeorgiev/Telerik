namespace _06.BiggestOf5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BiggestOf5
    {
        public static void Main()
        {
            List<double> listOfNumbers = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                listOfNumbers.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine(listOfNumbers.Max());
        }
    }
}
