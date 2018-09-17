namespace _02.SignOfIntegerNumber
{
    using System;
    public class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintNumberSign(number);
        }
        static private void PrintNumberSign(int num)
        {
            if (num >= 1)
            {
                Console.WriteLine("The number {0} is positive.", num);
            } else if (num <= - 1)
            {
                Console.WriteLine("The number {0} is negative.", num);
            } else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}
