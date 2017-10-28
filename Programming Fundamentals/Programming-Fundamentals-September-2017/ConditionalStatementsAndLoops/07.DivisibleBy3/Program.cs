namespace DivisibleBy3
{
    using System;
    public class Program
    {
        static void Main()
        {
            for (int cnt = 1; cnt < 100; cnt++)
            {
                if (cnt % 3 == 0)
                {
                    Console.WriteLine(cnt);
                }
            }
        }
    }
}
