namespace _03.Endurance_Rally
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {                       
                                                    // 80/100 Point - Missing cases !!
            List<string> drivers = Console.ReadLine().Split(' ').ToList();
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] index = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //List<int> index = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int reachedIndex = 0;
            for (int i = 0; i < drivers.Count; i++)
            {
                double fuel = drivers[i][0];
                int temp = 0;
                for (int k = 0; k < numbers.Length; k++)
                {
                    temp++;
                    if (index.Contains(k))
                    {
                        fuel += numbers[k];
                        if (fuel <= 0)
                        {
                            break;
                        }
                    }
                    else if (numbers[k] > 0)
                    {
                        fuel -= numbers[k];
                        if (fuel <= 0)
                        {
                            //Console.WriteLine($"{drivers[i]} - reached 0");
                            break;
                        }
                    }
                    else if (numbers[k] < 0 && (!index.Contains(k)))
                    {
                        fuel += Math.Abs(numbers[k]);
                        if (fuel <= 0)
                        {
                            break;
                        }
                    }
                }
                reachedIndex = temp;
                temp = 0;
                if (fuel >= 0)
                {
                    Console.WriteLine($"{drivers[i]} - fuel left {fuel:F2}");
                }
                else
                {
                    Console.WriteLine($"{drivers[i]} - reached {reachedIndex - 1}");
                }
            }
        }
    }
}
