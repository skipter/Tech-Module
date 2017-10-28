namespace TestNumbers
{
    using System;
    public class Program
    {
        static void Main()
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int m = Math.Abs(int.Parse(Console.ReadLine()));
            int stopNum = int.Parse(Console.ReadLine());

            int counterCombinations = 0;
            int sum = 0;
            bool isStopNumber = false;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (sum >= stopNum)
                    {
                        isStopNumber = true;
                        break;
                    }
                    else
                    {
                        counterCombinations++;
                        sum += 3 * (i * j);
                    }
                }
                if (sum >= stopNum)
                {
                    isStopNumber = true;
                    break;
                }
            }
            Console.WriteLine("{0} combinations", counterCombinations);

            if (isStopNumber)
            {
                Console.WriteLine("Sum: {0} >= {1}", sum, stopNum);
            } else
            {
                Console.WriteLine("Sum: {0}", sum);
            }
        }
    }
}
