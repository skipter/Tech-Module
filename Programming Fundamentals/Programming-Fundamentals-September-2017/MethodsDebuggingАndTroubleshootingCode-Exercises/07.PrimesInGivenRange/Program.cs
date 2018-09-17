namespace _07.PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            int startNumber = Math.Abs(int.Parse(Console.ReadLine()));
            int stopNumber = Math.Abs(int.Parse(Console.ReadLine()));

            List<int> primes = GetPrimeNumber(startNumber, stopNumber);
            Console.WriteLine(String.Join(", ", primes));
        }
        static List<int> GetPrimeNumber(int startNum, int stopNum)
        {
            List<int> primeList = new List<int>();

            for (int i = startNum; i <= stopNum; i++)
            {
                if (IsPrime(i))
                {
                    primeList.Add(i);
                }
            }
            return primeList;
        }
        static bool IsPrime(int number)
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
