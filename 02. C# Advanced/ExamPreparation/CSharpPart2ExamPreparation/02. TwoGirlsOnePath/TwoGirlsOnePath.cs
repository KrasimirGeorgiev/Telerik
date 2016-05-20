namespace _02.TwoGirlsOnePath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public class TwoGirlsOnePath
    {
        public static void Main()
        {
            List<BigInteger> pathOfFlowers = Console.ReadLine().Split().Select(BigInteger.Parse).ToList();
            int n = pathOfFlowers.Count;
            pathOfFlowers.Insert(0, 0);
            int indexMolly = 1;
            int indexDolly = n;
            BigInteger mollyFlowers = 0;
            BigInteger dollyFlowers = 0;
            bool dollySteppedInZero = true;
            bool mollySteppedInZero = true;
            while (true)
            {
                if (pathOfFlowers[indexMolly] == 0 || pathOfFlowers[indexDolly] == 0)
                {
                    if (pathOfFlowers[indexMolly] != 0)
                    {
                        mollyFlowers += pathOfFlowers[indexMolly];
                        mollySteppedInZero = false;
                    }

                    if (pathOfFlowers[indexDolly] != 0)
                    {
                        dollyFlowers += pathOfFlowers[indexDolly];
                        dollySteppedInZero = false;
                    }

                    break;
                }

                if (indexMolly == indexDolly)
                {
                    if (pathOfFlowers[indexMolly] % 2 != 0)
                    {
                        int currentIndex = indexMolly;
                        mollyFlowers += (pathOfFlowers[currentIndex] - 1) / 2;
                        dollyFlowers += (pathOfFlowers[currentIndex] - 1) / 2;
                        indexMolly = (int)(((BigInteger)indexMolly + pathOfFlowers[currentIndex]) % n);
                        indexMolly = indexMolly == 0 ? currentIndex : indexMolly;
                        indexDolly = n - (int)(((BigInteger)indexDolly - pathOfFlowers[currentIndex]) % n);
                        indexDolly = indexDolly == 0 ? currentIndex : indexDolly;
                        pathOfFlowers[currentIndex] = 1;
                    }
                    else
                    {
                        int currentIndex = indexMolly;
                        mollyFlowers += pathOfFlowers[currentIndex] / 2;
                        dollyFlowers += pathOfFlowers[currentIndex] / 2;
                        indexMolly = (int)(((BigInteger)indexMolly + pathOfFlowers[currentIndex]) % n);
                        indexMolly = indexMolly == 0 ? n : indexMolly;
                        indexDolly = n - (int)(((BigInteger)indexDolly - pathOfFlowers[currentIndex]) % n);
                        indexDolly = indexDolly == 0 ? currentIndex : indexDolly;
                        pathOfFlowers[currentIndex] = 0;
                    }
                }
                else
                {
                    int pastMollyIndex = indexMolly;
                    int pastDollyIndex = indexDolly;
                    mollyFlowers += pathOfFlowers[indexMolly];
                    dollyFlowers += pathOfFlowers[indexDolly];
                    indexMolly = (int)(((BigInteger)indexMolly + pathOfFlowers[indexMolly]) % n);
                    indexMolly = indexMolly == 0 ? pastMollyIndex : indexMolly;
                    indexDolly = (int)(((BigInteger)indexDolly - pathOfFlowers[indexDolly]) % n);
                    indexDolly = indexDolly <= 0 ? n + indexDolly : indexDolly;
                    //// indexDolly = indexDolly == 0 ? pastDollyIndex : indexDolly;
                    pathOfFlowers[pastMollyIndex] = 0;
                    pathOfFlowers[pastDollyIndex] = 0;
                }
            }

            if (mollySteppedInZero == true && dollySteppedInZero == true)
            {
                Console.WriteLine("Draw");
            }
            else if (mollySteppedInZero)
            {
                Console.WriteLine("Dolly");
            }
            else if (dollySteppedInZero)
            {
                Console.WriteLine("Molly");
            }

            Console.WriteLine(mollyFlowers + " " + dollyFlowers);
        }
    }
}

// C# Part 2 - 2013/2014 @ 24 Jan 2014 - Evening
// http://bgcoder.com/Contests/Practice/Index/143#1