namespace _04.MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("input.txt");
            File.Delete("output.txt");
            foreach (var line in input)
            {
                List<int> numbers = line
                .Split(new char[] { ' ' })
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
                    string output = longestNumber + " ";
                    File.AppendAllText("output.txt", output);
                }
            }
        }
    }
}