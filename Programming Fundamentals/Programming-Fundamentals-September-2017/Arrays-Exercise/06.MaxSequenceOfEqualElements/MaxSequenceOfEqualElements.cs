
namespace _06.MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    start = array[i];
                    len++;
                }
                else
                {
                    start = array[1];
                    len = 1;
                }

                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }
            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(bestStart + " ");
            }
            Console.WriteLine();
        }
    }
}
