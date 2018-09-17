namespace _07.CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountNumbers
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] {' ', }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            numbers.Sort();
            numbers.Add(int.MaxValue);

            int counter = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                } else
                {
                    Console.WriteLine($"{numbers[i]} -> {counter}");
                    counter = 1;
                }
            }
        }
    }
}
