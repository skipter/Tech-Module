namespace _02.Count_Substring_Occurrences
{
    using System;
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string toMatch = Console.ReadLine().ToLower();
            int lastIndex = text.IndexOf(toMatch);
            int counter = 0;

            while (lastIndex > -1)
            {
                counter++;
                lastIndex = text.IndexOf(toMatch, lastIndex + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
