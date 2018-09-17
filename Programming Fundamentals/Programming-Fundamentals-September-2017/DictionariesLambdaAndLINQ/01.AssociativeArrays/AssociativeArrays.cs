namespace _01.AssociativeArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class AssociativeArrays
    {
        public static void Main()
        {
            double[] arr = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

           var counts = new SortedDictionary<double, int>();

            foreach (var number in arr)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }

            foreach (var number in counts.Keys)
            {
                Console.WriteLine($"{number} -> {counts[number]}");
            }
        }
    }
}
