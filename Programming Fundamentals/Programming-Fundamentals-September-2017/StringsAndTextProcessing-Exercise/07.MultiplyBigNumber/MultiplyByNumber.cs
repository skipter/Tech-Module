namespace _07.MultiplyBigNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class MultiplyByNumber
    {
        public static void Main()
        {
            var first = Console.ReadLine().ToCharArray().Select(n => int.Parse(n.ToString())).ToList();
            int secondNum = int.Parse(Console.ReadLine());

            first.Reverse(); // За да не ги върти цикъла на обратно.
            var result = new List<int>();
            int sum = 0;
            for (int i = 0; i < first.Count; i++)
            {
                int num = (first[i] * secondNum) + sum;
                result.Add(num % 10);
                sum = (int)num / 10;
            }

            if (sum != 0)
            {
                result.Add(sum);
            }
            result.Reverse();
            bool cutZeros = true;
            for (int i = 0; i < result.Count; i++)
            {
                if (cutZeros)
                {
                    if (result[i] != 0)
                    {
                        Console.Write(result[i]);
                        cutZeros = false;
                    }
                }
                else
                {
                    Console.Write(result[i]);
                }
            }
            if (result.All(x => x == 0))
            {
                Console.WriteLine(0);
            }
            Console.WriteLine();
        }
    }
}
