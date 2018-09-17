namespace _13.Factorial
{
    using System;
    using System.Numerics;
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            FindFactorial(number);
        }
        static void FindFactorial (int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
