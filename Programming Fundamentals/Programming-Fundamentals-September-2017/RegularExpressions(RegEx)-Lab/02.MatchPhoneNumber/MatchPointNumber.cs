namespace _02.MatchPhoneNumber
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class MatchPointNumber
    {
        public static void Main()
        {
            string regex = @"(\+359([ |-])2\2\d{3}\2\d{4})\b";
            var phones = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phones, regex);

            var matchedPhones = phoneMatches.Cast<Match>().Select(nameof => nameof.Value).ToArray();
            Console.WriteLine(String.Join(", ", matchedPhones));
        }
    }
}
