namespace _02.RandomizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class RandomizeWords
    {
        public static void Main()
        {
            List<string> text = Console.ReadLine().Split(' ').ToList();
            Random rnd = new Random();

            for (int i = 0; i < text.Count + 1; i++)
            {
                int index = rnd.Next(0, text.Count);
                string rem = text[index];
                int newIndex = rnd.Next(0, text.Count);
                text[index] = text[newIndex];
                text[newIndex] = rem;
            }
            for (int i = 0; i < text.Count; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
