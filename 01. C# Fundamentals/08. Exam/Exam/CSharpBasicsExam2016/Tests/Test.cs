using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class Test
    {
        public static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            char c = Console.ReadLine()[0];

            StringBuilder result = new StringBuilder();
            int wingsAndBody = 0;
            switch (s)
            {
                case 5: wingsAndBody = 1; break;
                case 7: wingsAndBody = 2; break;
                case 9: wingsAndBody = 3; break;
                case 11: wingsAndBody = 4; break;
                case 13: wingsAndBody = 5; break;
                case 15: wingsAndBody = 6; break;
                case 17: wingsAndBody = 7; break;
                case 19: wingsAndBody = 8; break;
                case 21: wingsAndBody = 9; break;
                case 23: wingsAndBody = 10; break;
                case 25: wingsAndBody = 11; break;
                case 27: wingsAndBody = 12; break;
                case 29: wingsAndBody = 13; break;
                case 31: wingsAndBody = 14; break;
                case 33: wingsAndBody = 15; break;
                case 35: wingsAndBody = 16; break;
                case 37: wingsAndBody = 17; break;
                case 39: wingsAndBody = 18; break;
                case 41: wingsAndBody = 19; break;
                case 43: wingsAndBody = 20; break;
                case 45: wingsAndBody = 21; break;
                case 47: wingsAndBody = 22; break;
                case 49: wingsAndBody = 23; break;
                case 51: wingsAndBody = 24; break;
            }

            int justNumber = 0;
            for (int i = 0; i < (s - 1) / 2; i++)
            {
                if (i != ((s - 1) / 2) - 1)
                {
                    result.Append(new string(' ', i));
                    result.Append(new string(c, s - i));
                    result.Append(new string(' ', s));
                    result.AppendLine(new string(c, s - i));
                }
                
                if (i == ((s - 1) / 2) - 1)
                {
                    justNumber = s - (i + 1);
                    result.Append(new string(' ', s - justNumber));
                    result.Append(new string(c, justNumber));
                    result.Append(new string(' ', (s - 3) / 2));
                    result.Append(new string(c, 1));
                    result.Append(new string(' ', 1));
                    result.Append(new string(c, 1));
                    result.Append(new string(' ', (s - 3) / 2));
                    result.AppendLine(new string(c, justNumber));
                }
            }

            

            for (int i = 0; i < ((s - 1) / 2) - 1; i++)
            {
                result.Append(new string(' ', s - (justNumber - 1)));
                result.AppendLine(new string(c, (2 * (justNumber - 1)) + s));
            }

            int randomNumber = GiveMe((s - 1) / 2);
            for (int i = (s - 1) / 2; i >= 1; i -= 1)
            {
                result.Append(new string(' ', (s * 3 - randomNumber) / 2));
                result.AppendLine(new string(c, randomNumber));
                randomNumber -= 2;
            }

            result.Length = result.Length - 1;
            Console.WriteLine(result.ToString());
        }

        private static int GiveMe(int n)
        {
            int result = 1;
            int count = 1;
            while (count < 4)
            {
                result += 2;
                count++;
            }

            return result;
        }
    }
}
