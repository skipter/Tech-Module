namespace SumOfOddNumbers
{
    using System;
    public class Program
    {
        static void Main()
        {
            int oddCOunter = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            for (int cnt = 1; ; cnt++)
            {
                if (cnt % 2 == 1)
                {
                    Console.WriteLine(cnt);
                    sum += cnt;
                    counter++;
                }
                if (counter == oddCOunter)
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
