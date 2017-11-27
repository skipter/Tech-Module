namespace _05.Largest_N_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class LargestNelements
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());
            numbers.Sort();
            numbers.Reverse();
            List<int> result = numbers.GetRange(0, num);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
