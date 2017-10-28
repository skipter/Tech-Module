namespace _03.MatchHexadecimalNumbers
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    public class MatchHexadecimalNumbers
    {
        public static void Main()
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            string textNumbers = Console.ReadLine();
            var numbers = Regex.Matches(textNumbers, pattern)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
