namespace _09.MultiplyEvensByOdds
{
    using System;
    public class Program
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfOddAndEvenNumbers(number));
        }
        private static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                } 
                number /= 10;
            }
            return oddSum;
        }
        private static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;
            while (number > 0)  
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
                number /= 10;
            }
            return evenSum;
        }
        public static int GetMultipleOfOddAndEvenNumbers(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            return evenSum * oddSum;
        }
    }
}
