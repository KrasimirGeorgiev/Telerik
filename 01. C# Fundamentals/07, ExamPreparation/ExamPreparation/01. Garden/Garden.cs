namespace _01.Garden
{
    using System;

    public class Garden
    {
        public static void Main()
        {
            int area = 250;
            decimal result = 0M;
            decimal tomato = 0.5M;
            decimal cucumber = 0.4M;
            decimal potato = 0.25M;
            decimal carrot = 0.6M;
            decimal cabbage = 0.3M;
            decimal beans = 0.4M;

            int tomatoSeeds = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine());
            area -= tomatoArea;
            result += tomatoSeeds * tomato;
            int cucumberSeeds = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine());
            area -= cucumberArea;
            result += cucumberSeeds * cucumber;
            int potatoSeeds = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());
            area -= potatoArea;
            result += potatoSeeds * potato;
            int carrotSeeds = int.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine());
            area -= carrotArea;
            result += carrotSeeds * carrot;
            int cabbageSeeds = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());
            area -= cabbageArea;
            result += cabbageSeeds * cabbage;
            int beansSeeds = int.Parse(Console.ReadLine());
            result += beansSeeds * beans;

            Console.WriteLine("Total costs: {0:F2}", result);
            if (area == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else if (area < 0)
            {
                Console.WriteLine("Insufficient area");
            }
            else if (area > 0)
            {
                Console.WriteLine("Beans area: {0}", area);
            }
        }
    }
}

// Telerik Academy Exam 1 @ 24 June 2013 Evening
// http://bgcoder.com/Contests/Practice/Index/93#0