namespace _02.ColoredRabbits
{
    using System;
    using System.Collections.Generic;

    public class ColoredRabbits
    {
        public static void Main()
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int rabbitsMinCount = 0;

            short lines = short.Parse(Console.ReadLine());
            int answer = 0;
            for (int i = 0; i < lines; i++)
            {
                answer = int.Parse(Console.ReadLine()) + 1;
                if (dic.ContainsKey(answer))
                {
                    dic[answer]++;
                }
                else
                {
                    dic.Add(answer, 1);
                }
            }

            foreach (int key in dic.Keys)
            {
                if (key >= dic[key])
                {
                    rabbitsMinCount += key;
                }
                else
                {
                    rabbitsMinCount += (float)dic[key] / key > dic[key] / key ? (dic[key] / key + 1) * key : (dic[key] / key) * key;
                }
            }

            Console.WriteLine(rabbitsMinCount);
        }
    }
}
