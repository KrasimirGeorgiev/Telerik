using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Buses
{
    public class Buses
    {
        public static void Main()
        {
            int busesCount = int.Parse(Console.ReadLine());
            int countGroups = 1;
            int currentSpeed = int.Parse(Console.ReadLine());
            for (int i = 0; i < busesCount - 1; i++)
            {
                int currentBusSpeed = int.Parse(Console.ReadLine());
                if (currentBusSpeed <= currentSpeed)
                {
                    countGroups++;
                    currentSpeed = currentBusSpeed;
                }
            }

            Console.WriteLine(countGroups);
        }
    }
}
