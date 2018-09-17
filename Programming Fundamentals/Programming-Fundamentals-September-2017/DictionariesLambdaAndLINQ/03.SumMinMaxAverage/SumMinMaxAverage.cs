namespace _03.SumMinMaxAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SumMinMaxAverage
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int currentNumber = 0;
            List<int> numbers = new List<int>();

            for (int i = 0; i < numbersCount; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());
                numbers.Add(currentNumber);
            }
            Console.WriteLine("Sum = " + numbers.Sum());
            Console.WriteLine("Min = " + numbers.Min());
            Console.WriteLine("Max = " + numbers.Max());
            Console.WriteLine("Average = " + numbers.Average());
        }
    }
}
