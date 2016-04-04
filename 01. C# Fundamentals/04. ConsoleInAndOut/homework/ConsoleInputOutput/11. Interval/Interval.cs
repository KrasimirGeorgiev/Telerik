namespace _11.Interval
{
    using System;

    public class Interval
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (n == m || n + 1 == m)
            {
                Console.WriteLine(0);
            }
            else
            {
                int count = 0;
                int currentN = n + 1;
                while (true)
                {
                    if (currentN % 5 == 0 && currentN < m)
                    {
                        count++;
                        break;
                    }

                    currentN++;
                }

                if (count == 1)
                {
                    while (true)
                    {
                        currentN += 5;

                        if (currentN < m)
                        {
                            count++;
                        }

                        if (currentN > m)
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine(count);
            }

            // Input Output  
            // 6
            // 11    1   
            
            // 20
            // 37    3   
            
            // 2
            // 2     0   
        }
    }
}

// Write a program that reads two positive integer numbers N and M and prints how many numbers exist between them 
// such that the reminder of the division by 5 is 0.