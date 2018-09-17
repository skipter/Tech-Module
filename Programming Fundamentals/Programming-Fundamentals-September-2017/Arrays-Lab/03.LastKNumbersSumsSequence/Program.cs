namespace _03.LastKNumbersSumsSequence
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] number = new long[n];
            int sum = 0;
            number[0] = 1;

            for (int i = 1; i < number.Length; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    if (i - j >= 0)         //This if() is for "number[i-j] to be positive."
                    {
                        number[i] += number[i - j];
                        continue;
                    }
                    break;
                }
            }
            Console.WriteLine(string.Join(" ", number));
        }
    }
}
