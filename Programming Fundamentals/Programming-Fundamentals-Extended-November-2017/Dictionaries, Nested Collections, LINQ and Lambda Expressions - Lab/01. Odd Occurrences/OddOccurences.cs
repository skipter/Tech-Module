namespace _01.Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    public class OddOccurences
    {
        public static void Main()
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            List<string> result = new List<string>();
            string input = Console.ReadLine().ToLower();
            var hhh = input.Split(new char[] { ' ', }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in hhh)
            {
                if (!words.ContainsKey(item))
                {
                    words.Add(item, 1);
                }
                else
                {
                    words[item]++;
                }
            }
            foreach (var item in words)
            {
                if ((item.Value % 2 == 1))
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
