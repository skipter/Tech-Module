namespace _05.FibonacciNumbers
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonaciNthNumber(number));
        }
        private static int GetFibonaciNthNumber(int n)
        {
            int a = 1;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
