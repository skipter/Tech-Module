namespace _06.PrimeChecker
{
    using System;
    public class Program
    {
        static void Main()
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));
            Console.WriteLine(IsPrime(number));
        }
        static bool IsPrime(long number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
