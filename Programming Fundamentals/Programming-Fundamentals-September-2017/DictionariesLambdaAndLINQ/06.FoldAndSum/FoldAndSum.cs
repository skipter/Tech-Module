namespace _06.FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class FoldAndSum
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int k = numbers.Count / 4;
            var left = numbers.Take(k).Reverse().ToList();
            numbers.Reverse();
            var right = numbers.Take(k).ToList();    
            var newArr = left.Concat(right).ToList();
            numbers.Reverse();
            var middlePartOfK = numbers.Skip(k).Take(2 * k).ToList();

            var result = newArr.Select((x, index) => x + middlePartOfK[index]);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
