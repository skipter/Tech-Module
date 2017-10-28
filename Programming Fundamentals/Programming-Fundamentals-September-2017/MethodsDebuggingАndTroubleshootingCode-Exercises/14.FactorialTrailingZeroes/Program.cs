namespace _14.FactorialTrailingZeroes
{
    using System;
    using System.Numerics;
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(FindFactorial(number));
        }

        // Calculating factorial with n - number and find treiling zeros.
        static int FindFactorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            string text = factorial.ToString();
            string[] zeros = text.Split('0');

            int count = 0;
            for (int i = zeros.Length - 1; i >= 0; i--)
            {
                if (zeros[i] == "")
                {
                    count = count + 1;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}

    

