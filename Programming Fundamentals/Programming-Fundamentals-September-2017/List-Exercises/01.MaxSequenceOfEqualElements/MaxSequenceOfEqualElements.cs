namespace _01.MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { })
                .Select(int.Parse)
                .ToList();

            int counter = 1;
            int maxCounter = 0;
            int longestNumber = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    
                }
                else
                {
                    counter = 1;
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    longestNumber = numbers[i];
                }
            }
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(longestNumber + " ");
            }
            Console.WriteLine();
        }
    }
}
