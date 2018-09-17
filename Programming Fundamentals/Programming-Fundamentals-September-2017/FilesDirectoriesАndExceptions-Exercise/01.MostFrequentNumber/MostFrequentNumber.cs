namespace _01.MostFrequentNumber
{
    using System;
    using System.IO;
    using System.Linq;
    public class MostFrequentNumber
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines("input.txt");
            File.Delete("output.txt");

            foreach (var line in lines)
            {
                int[] array = line
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

                int repeats = 0;
                int freqNumber = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    int currentNumber = array[i];
                    int counter = 0;
                    for (int k = i; k < array.Length; k++)
                    {
                        if (currentNumber == array[k])
                        {
                            counter++;
                        }
                    }
                    if (counter > repeats)
                    {
                        freqNumber = currentNumber;
                        repeats = counter;
                    }
                }
                var output = freqNumber.ToString();
                File.AppendAllText("output.txt", output);
            }
        }
    }
}