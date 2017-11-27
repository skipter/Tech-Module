namespace _02.Odd_Numbers_at_Odd_Positions
{
    using System;
    using System.Linq;
    public class OddNumberAtOddPosition
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string prefix = "Index";
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (i % 2 != 0 && currentNumber % 2 != 0)
                {
                    Console.WriteLine($"{prefix} {i} -> {numbers[i]}");
                }
            }
        }
    }
}
