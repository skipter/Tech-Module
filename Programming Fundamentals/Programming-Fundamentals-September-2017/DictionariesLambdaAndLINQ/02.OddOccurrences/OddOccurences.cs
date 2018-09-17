namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class OddOccurences
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToArray();

            var words = new Dictionary<string, int>();

            foreach (var word in arr)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                } 
                else
                {
                    words[word] = 1;
                }
            }
            var result = new List<string>();
            foreach (var word in words)
            {
                if (word.Value % 2 != 0)
                {
                    result.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
