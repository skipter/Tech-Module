namespace _08.MostFrequentNumber
{
    using System;
    using System.Linq;
    public class MostFrequentNumber
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
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
           Console.WriteLine("{0}", freqNumber);
        }
    }
}
