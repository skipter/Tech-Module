namespace _05.Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Larges3Numbers
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            Console.WriteLine(String.Join(" ", numbers.OrderByDescending(x => x).Take(3)));
        }
    }
}
