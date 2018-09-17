namespace _15.FastPrimeChecker_Refactor
{
    using System;
    public class Program
    {
        static void Main()
        {
            int stopNumber = int.Parse(Console.ReadLine());
            for (int i = 2; i <= stopNumber; i++)
            {
                bool isPrime = true;
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (i % k == 0)
                    {
                        isPrime = false;
                        break;
                    } 
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}
