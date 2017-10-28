namespace _9.RefactorSpecialNumbers
{
    using System;
    public class Program
    {
        static void Main()
        {
            int stopNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            bool isSpecial = false;

            for (int ch = 1; ch <= stopNumber; ch++)
            {
                num = ch;
                while (ch > 0)
                {
                    sum += ch % 10;
                    ch = ch / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{num} -> {isSpecial}");
                sum = 0;
                ch = num;
            }
        }
    }
}
