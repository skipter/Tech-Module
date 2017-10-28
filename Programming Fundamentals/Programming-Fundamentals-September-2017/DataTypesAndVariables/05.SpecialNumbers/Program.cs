namespace _05.specialNumberNumbers
{
    using System;
    public class Program
    {
        static void Main()
        {
            int stopNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            for (int i = 1; i <= stopNumber; i++)
            {
                sum = i % 10;
                num = i / 10;
                int specialNumber = sum + num;
                bool isSpecial = i == 5 || i == 7 || specialNumber == 5 || specialNumber == 7 || specialNumber == 11;

                if (isSpecial)
                {
                    Console.WriteLine($"{i} -> True");
                } else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
