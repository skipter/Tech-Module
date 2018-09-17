namespace _04.Sum_Min_Max_Average
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SmMinMaxAverage
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < count; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers.Add(currentNumber);
            }
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
