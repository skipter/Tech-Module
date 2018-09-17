namespace _03.Anonymous_Vox
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class AnonymousThreat
    {
        public static void Main()
        {
            string encodedText = Console.ReadLine();
            var placeHolders = Console.ReadLine()
                .Split(new char[] { '{', '}', }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string pattern = @"([a-zA-Z]+)(.+)\1";  // \1 - Match the same text as first group.
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(encodedText);
            int placeholderIndex = 0;
            foreach (Match match in matches)
            {
                if (placeholderIndex >= placeHolders.Count)
                {
                    break;
                }
                encodedText = ReplaceFirst(encodedText, match.Groups[2].Value, placeHolders[placeholderIndex++]);
            }
            Console.WriteLine(encodedText);
        }
        static string ReplaceFirst(string text, string oldValue, string newValue)
        {
            string substringWithOldValue = text.Substring(0, text.IndexOf(oldValue) + oldValue.Length);
            string substringWithNewValue = substringWithOldValue.Replace(oldValue, newValue);
            return substringWithNewValue + text.Substring(substringWithOldValue.Length);
        }
    }
}

