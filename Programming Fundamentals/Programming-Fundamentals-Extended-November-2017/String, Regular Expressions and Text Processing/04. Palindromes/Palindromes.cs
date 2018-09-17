namespace _04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Palindromes
    {
        public static void Main()
        {
            string[] text = Console.ReadLine()
                .Split(new char[] { '!', ' ', '.', '?', ':', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var result = new SortedSet<string>();

            foreach (var word in text)
            {
                if (!IsPalindrome(word))
                {
                    continue;
                }
                result.Add(word);
            }
            Console.WriteLine(string.Join(", ", result));
        }

        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (a != b)
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
