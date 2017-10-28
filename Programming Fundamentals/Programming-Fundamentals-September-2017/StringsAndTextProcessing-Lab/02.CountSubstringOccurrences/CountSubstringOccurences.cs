namespace _02.CountSubstringOccurrences
{
    using System;
    public class CountSubstringOccurences
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string lookFor = Console.ReadLine().ToLower();

            int counter = 0;
            int index = text.IndexOf(lookFor);
            while (index != - 1)
            {
                counter++;
                index = text.IndexOf(lookFor, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
