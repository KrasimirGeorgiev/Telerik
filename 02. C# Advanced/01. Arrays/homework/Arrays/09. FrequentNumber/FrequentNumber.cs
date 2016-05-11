namespace _09.FrequentNumber
{
    using System;
    using System.Linq;

    public class FrequentNumber
    {
        public static void Main()
        {
            ushort n = ushort.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            int groupCount = 0;
            int groupVal = 0;
            var groups = arr.GroupBy(group => group);
            foreach (var group in groups)
            {
                if (count == 0)
                {
                    groupCount = group.Count();
                    groupVal = group.Key;
                    count++;
                }
                else
                {
                    if (group.Count() > groupCount)
                    {
                        groupCount = group.Count();
                        groupVal = group.Key;
                    }
                }
            }

            Console.WriteLine("{0} ({1} times)", groupVal, groupCount);
        }
    }
}

// Write a program that finds the most frequent number in an array of N elements.