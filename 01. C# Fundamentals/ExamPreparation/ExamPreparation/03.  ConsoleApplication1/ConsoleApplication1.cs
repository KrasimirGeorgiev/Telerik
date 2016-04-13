namespace _03.ConsoleApplication1
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ConsoleApplication1
    {
        public static void Main()
        {
            List<string> numbers = new List<string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                numbers.Add(input);
                input = Console.ReadLine();
            }

            CountDiggits(numbers);
        }

        private static void CountDiggits(List<string> input)
        {
            BigInteger result = 1;
            BigInteger result2 = 1;
            List<long> resultList1 = new List<long>();
            List<long> resultList2 = new List<long>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i < 10)
                {
                    if (i % 2 != 0)
                    {
                        string currentNumber = input[i];
                        if (currentNumber == "0")
                        {
                            resultList1.Add(1);
                        }
                        else
                        {
                            long currentResult = 1;
                            foreach (char symbol in currentNumber.ToString())
                            {
                                int n = symbol - '0';
                                if (n != 0)
                                {
                                    currentResult *= n;
                                }
                            }

                            resultList1.Add(currentResult);
                        }
                    }
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        string currentNumber = input[i];
                        if (currentNumber == "0")
                        {
                            resultList2.Add(1);
                        }
                        else
                        {
                            long currentResult = 1;
                            foreach (char symbol in currentNumber.ToString())
                            {
                                int n = symbol - '0';
                                if (n != 0)
                                {
                                    currentResult *= n;
                                }
                            }

                            resultList2.Add(currentResult);
                        }
                    }
                }
            }

            foreach (var number in resultList1)
            {
                result *= number;
            }

            Console.WriteLine(result);

            if (resultList2.Count > 0)
            {
                foreach (var number in resultList2)
                {
                    result2 *= number;
                }

                Console.WriteLine(result2);
            }


        }
    }
}

// Telerik Academy Exam 1 @ 3 February 2015 Morning
// http://bgcoder.com/Contests/Practice/Index/204#2