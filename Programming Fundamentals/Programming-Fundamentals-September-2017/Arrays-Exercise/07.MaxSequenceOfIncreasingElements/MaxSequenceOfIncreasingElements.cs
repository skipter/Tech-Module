namespace _07.MaxSequenceOfIncreasingElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class MaxSequenceOfIncreasingElements
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int start = 0;
            int len = 0;
            int bestStart = 0;
            int bestLen = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] - array[i - 1] >= 1)
                {
                    len++;
                    start = i - len;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                }
                else
                {
                    start = array[1];
                    len = 0;
                }
            }

            for (int i = bestStart; i <= bestStart + bestLen; i++)
            {
                Console.Write("{0} ",array[i]);
            }
            Console.WriteLine();
        }
    }
}


