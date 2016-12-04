namespace _01.RecursiveSimulationOfLoops
{
    using System;
    using System.Text;

    public class SimulationOfLoops
    {
        public static void Main()
        {
            var sb = new StringBuilder();
            Console.WriteLine(PrintLoops(0, 2, string.Empty, sb));
        }

        public static StringBuilder PrintLoops(int counter, int n, string str, StringBuilder sb)
        {
            if (counter == n)
            {
                return sb.AppendLine(str);
            }

            for (int i = 1; i <= n; i++)
            {
                PrintLoops(counter + 1, n, str + " " + i, sb);
            }

            return sb;
        }
    }
}

// Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.
// Examples:
//              1 1
//  n= 2   ->   1 2
//              2 1
//              2 2