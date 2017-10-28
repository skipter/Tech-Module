namespace _03.ExactSumOfRealNumbers
{
    using System;
    public class Program
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            decimal exactSum = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());
                exactSum += currentNumber;
            }
            Console.WriteLine(exactSum);
        }
    }
}
