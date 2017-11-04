namespace _03.Hornet_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {                                                          // 100/100 Points
            List<long> beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count <= 0)
                {
                    break;
                }
                if (hornets.Sum() > beehives[i])
                {
                    beehives.RemoveAt(i);
                    i--;
                }
                else
                {
                    beehives[i] -= hornets.Sum();
                    hornets.RemoveAt(0);
                }
            }
            if (beehives.Where(x => x > 0).ToList().Count > 0)
            {
                Console.WriteLine(String.Join(" ", beehives.Where(h => h > 0)));
            }
            else
            {
                Console.WriteLine(String.Join(" ", hornets));
            }
        }
    }
}
