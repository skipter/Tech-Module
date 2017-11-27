namespace _04.Sort_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SortNumbers
    {
        public static void Main()
        {
           List<decimal> numbers = Console.ReadLine().Split(new char[] { ' ', }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse).ToList();
            numbers.Sort();
            Console.WriteLine(String.Join(" <= ", numbers));
        }
    }
}
